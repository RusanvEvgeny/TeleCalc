using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUniver.TeleCalc.Core;
using System.Reflection;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            string operName = null;
            double x = 0;
            double y = 0;
            double? result = Double.NaN;
            if (args.Length != 3)
            {
                Console.WriteLine("Входные данные были неверны.\n");
                while (true)
                {
                    Console.WriteLine("Введите одно из действий");
                    calc.printOper();
                    Console.WriteLine("или 'exit' для выхода:");
                    operName = Console.ReadLine();
                    if (operName == "exit") return;
                    Console.WriteLine("Введите параметры через пробел");
                    var data = Console.ReadLine().Split(' ');
                    x = double.Parse(data[0]);
                    y = double.Parse(data[1]);
                    result = calc.Exec(operName, x, y);

                    Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, operName, y, result));
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                operName = args[0];

                x = Double.Parse(args[1]);
                y = Double.Parse(args[2]);
                result = calc.Exec(operName, x, y);

                Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, operName, y, result));
                Console.ReadKey();
            }
        }
    }
}
