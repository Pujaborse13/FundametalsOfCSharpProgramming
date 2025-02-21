using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Refelection
{
    public delegate int Calculator(int x, int y);
    public class CalculatorDemo
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }


    }
}
