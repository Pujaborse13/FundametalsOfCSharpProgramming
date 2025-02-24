using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{
    //KISS (Keep It Simple, Stupid) :  Write simple and clear code instead of over-engineering.
    //Withoud KISS Rule
    internal class KISS
    {
        class Calculator
        {
            public int Add(int a, int b)
            {
                if (a > 0 && b > 0)
                {
                    return a + b;
                }
                else if (a > 0 && b < 0)
                {
                    return a + b;
                }
                else if (a < 0 && b > 0)
                {
                    return a + b;
                }
                else
                {
                    return a + b;
                }
            }
        }

        //-----------------------------------------
        //With KISS Rule
        class Calculator1
        {
            public int Add1(int a, int b)
            {
                return a + b;
            }
        }



    }
}
