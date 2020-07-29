using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MathMinus : IMathOperator
    {
        public double Operation(int a, int b)
        {
            return a - b;
        }
    }
}
