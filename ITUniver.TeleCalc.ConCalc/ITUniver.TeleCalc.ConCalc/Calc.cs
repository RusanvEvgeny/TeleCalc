using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    public class Calc
    {
        public double Sum(double x, double y)
        {
            return x + y;
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
            double a = 1;
            while (y > 0)
            {
                a *= x;
                y--;
            }
            return a;
        }
    }
}
