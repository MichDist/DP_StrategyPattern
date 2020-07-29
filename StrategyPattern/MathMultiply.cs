using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MathMultiply : IMathOperator
    {
        public double Operation(int a, int b)
        {
            return a * b;
        }
    }
}
