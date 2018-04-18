using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operaions
{
    internal class Sub : IOperation
    {
        public string Name => "sub";

        public double[] Args
        {
            set
            {
                var sub = value[0];
                for(int i = 1; i < value.Length; i++)
                {
                    sub -= value[i];
                }
                Result = sub;
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
