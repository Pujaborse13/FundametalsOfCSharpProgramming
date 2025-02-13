using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp.LambdaExpression
{
    internal class EvenNumber_LambdaEx
    {
        public void LambdaExpressionDemo()
        {
            List<int> input = new List<int> { 10, 15, 20, 25, 30, 35, 40 };
            List<int> evenNumbers = input.FindAll(x => x % 2 == 0);


            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);

            }

        }





    }
}
