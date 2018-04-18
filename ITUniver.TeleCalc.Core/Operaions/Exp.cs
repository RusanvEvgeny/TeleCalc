using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operaions
{
    internal class Exp : IOperation
    {
        public string Name => "exp";

        public double[] Args
        {
            set
            {
                var exp = value[0];
                for (int i = 1; i < value.Length; i++)
                {
                    exp = Math.Pow(exp,value[i]);
                }

                Result = exp;
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
