using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUniver.TeleCalc.ConCalc;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            double x, y;
            int z;
            string d = null;
            while (true)
            {
                Console.Write("\nДействие: ");
                d = Console.ReadLine();
                Console.Clear();

                if ((d == "Sum") || (d == "+"))
                {
                    Console.WriteLine("\nСумма\nВведите слогаемые:");
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nСумма равна {0}", calc.Sum(x, y));
                }
                else if ((d == "Minus") || (d == "-"))
                {
                    Console.WriteLine("\nВычитание\nВведите уменьшаемое:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вычитаемое:");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nРазница равна {0}", calc.Minus(x, y));
                }
                else if ((d == "Umn") || (d == "*"))
                {
                    Console.WriteLine("\nУмножение\nВведите множители:");
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nПроизведение равно {0}", calc.Umn(x, y));
                }
                else if ((d == "Del") || (d == "/"))
                {
                    Console.WriteLine("\nДеление\nВведите Делимое:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите делитель:");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nЧастное равно {0}", calc.Del(x, y));
                }
                else if ((d == "Step") || (d == "^"))
                {
                    Console.WriteLine("\nВозведене в степень\nВведите основание:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите показатель:");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nРезультат возведеия {0}", calc.Step(x, z));
                }
                else if ((d == "Exit")||(d == "q")) return;
                else
                {
                    Console.Write("\nТакого действия нету.");
                }
            }
        }
    }
}
