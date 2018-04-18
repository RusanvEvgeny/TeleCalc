using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operaions
{
    internal class Div : IOperation
    {
        public string Name => "div";

        public double[] Args
        {
            set
            {
                var div = value[0];
                for (int i = 1; i < value.Length; i++)
                {
                    div /= value[i];
                }

                Result = div;
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
