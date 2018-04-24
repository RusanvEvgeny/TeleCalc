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

        private string[] outClasses = Directory.GetFiles("D:\\ItUniver\\TeleCalc\\dll", "*.dll");

        public Calc()
        {
            var opers = new List<IOperation>();

            //поучит текущую сбоку
            var assembly = Assembly.GetExecutingAssembly();
            
            //получить все типы в ней
            var classes = assembly.GetTypes();
            foreach (var item in outClasses) Assembly.LoadFile(item);

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
