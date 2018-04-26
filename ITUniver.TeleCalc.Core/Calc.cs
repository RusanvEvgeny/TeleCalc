using ITUniver.TeleCalc.Core.Operaions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ITUniver.TeleCalc.Core
{
    public class Calc
    {
        private IOperation[] operations { get; set; }

        public IEnumerable<string> GetOperNames()
        {
            return operations.Select(o => o.Name);
        }

        private const string ExtensionPath = "D:/ItUniver/TeleCalc/dll";
        private IEnumerable<IOperation> LoadOperation(Assembly assembly)
        {
            var opers = new List<IOperation>();

            var classes = new Type[] { };
            try
            {
                classes = assembly.GetTypes();
            }
            catch
            {

            }

            foreach (var item in classes)
            {
                var interfaces = item.GetInterfaces();

                var isOperation = interfaces.Any(i => i == typeof(IOperation));
                
                if (isOperation)
                {
                    var obj = Activator.CreateInstance(item) as IOperation;
                    if (obj != null)
                    {
                        opers.Add(obj);
                    }
                }
            }

            return opers;
        }


        public Calc()
        {
            var opers = new List<IOperation>();
            
            var assembly = new List<Assembly>() { Assembly.GetExecutingAssembly() };
            
            if (Directory.Exists(ExtensionPath))
            {
                var dlls = Directory.GetFiles(ExtensionPath, "*.dll");

                assembly.AddRange(dlls.Select(Assembly.LoadFile));
            }

            foreach (var item in assembly) opers.AddRange(LoadOperation(item));
            
            operations = opers.ToArray();
        }

        [Obsolete("Исользйте Exec(operName, args)")]
        public double Exec(string operName, double x, double y)
        {
            return Exec(operName, new double[] { x, y });
        }

        public double Exec(string operName, IEnumerable<double> args)
        {
            IOperation operation = operations
                .FirstOrDefault(o => o.Name == operName);

            if (operations == null)
                return double.NaN;

            operation.Args = args.ToArray();
            return (double)operation.Result;
        }
    }
}
