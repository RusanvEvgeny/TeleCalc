using ITUniver.TeleCalc.Core.Operaions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    public class Calc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Sum(double x, double y)
        {
            var sum = new Sum();
            sum.Args = new double[] { x, y };
            return (double)sum.Result;
        }

        public double Minus(double x, double y)
        {
            return x - y;
        }

        public double Umn(double x, double y)
        {
            return x * y;
        }

        public double Del(double x, double y)
        {
            return x / y;
        }

        public double Step(double x, int y)
        {
            return Math.Pow(x, y);
        }

        public double Sqr(double x)
        {
            return Math.Pow(x, 2);
        }
    }
}
