using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    internal class SubstractOperator : IOperator
    {
        public float run(float a, float b)
        {
            return a-b;
        }

        public override string ToString()
        {
            return "-";
        }
    }
}
