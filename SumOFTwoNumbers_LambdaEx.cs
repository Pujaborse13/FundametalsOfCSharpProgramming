using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp.LambdaExpression
{
    internal class SumOFTwoNumbers_LambdaEx
    {
        public void SumOfNum()
        {
            //Using Statement lambda
            var result = (int a, int b) =>
            {
                int calculatedSum = a + b;
                return calculatedSum;
            };

            Console.WriteLine("Total sum: " + result(5, 6));



            //Using Func Delegate
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(10, 20));

            //Using Action Delegate (Without Return)
            Action<int, int> addAndPrint = (a, b) => Console.WriteLine(a + b);
            addAndPrint(10, 20);

            //Using Lambda Expression Inside LINQ
            int[] numbers = { 10, 20 };
            int sum = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine(sum);

        }
    }
}
