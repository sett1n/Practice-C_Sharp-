using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Function
    {
        public static double f (double x) 
        {
            if (Math.Abs(x) <= 0.1) return Math.Pow(3, x) - 0.1;
            else if (0.1 < x & x <= 0.2) return 0.2 * 2 - 0.1;
            else return Math.Pow(3, x) + 0.1;
        }
    }
}
