using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculation
{
    public class MyCalc
    {
        public double y(double a, double c, double x)
        {
            if ((c < 0) && (a != 0))
                return -a * x * x;
            else if ((c > 0) && (a == 0))
                return (a - x) / c / x;
            else
                return x / c;
        }
    }
}
