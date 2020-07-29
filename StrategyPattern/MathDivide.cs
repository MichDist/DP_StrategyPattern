using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MathDivide : IMathOperator
    {
        public double Operation(int a, int b)
        {
            return a / b;
        }
    }
}
