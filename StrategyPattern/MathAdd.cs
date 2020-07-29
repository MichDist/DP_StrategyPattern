using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MathAdd : IMathOperator
    {
        public double Operation(int a, int b)
        {
            return a + b;
        }
    }
}
