using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operaions
{
    internal class Mul : IOperation
    {
        public string Name => "mul";

        public double[] Args
        {
            set
            {
                var mul = 0d;
                foreach (var item in value)
                {
                    mul *= item;
                }
                Result = mul;
            }
            get
            {
                return new double[0];
            }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }

    
}
