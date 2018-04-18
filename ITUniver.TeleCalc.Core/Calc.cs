using ITUniver.TeleCalc.Core.Operaions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ITUniver.TeleCalc.Core
{
    public class Calc
    {
        private IOperation[] operations { get; set; }

        public Calc()
        {
            var opers = new List<IOperation>();

            //поучит текущую сбоку
            var assembly = Assembly.GetExecutingAssembly();

            //получить все ипы в ней
            var classes = assembly.GetTypes();

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

        public double Exec(string operName, double x, double y)
        {
            IOperation operation = operations.FirstOrDefault(o => o.Name == operName);

            if (operations == null) return double.NaN;

            operation.Args = new double[] { x, y };
            return (double)operation.Result;
        }

        public void printOper()
        {
            foreach(var i in operations)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
