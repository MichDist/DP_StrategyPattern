using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StrategyPattern
{
    interface IMathOperator
    {
        double Operation(int a, int b);
    }
}
