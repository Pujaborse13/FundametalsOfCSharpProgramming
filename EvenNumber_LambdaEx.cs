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

            //using FindAll method
            List<int> evenNumbers = input.FindAll(x => x % 2 == 0);
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);

            }
            //---------------------------------------------


            //Using LINQ Where Method
            List<int> evenNumbers1 = input.Where(x => x % 2 == 0).ToList();
            evenNumbers.ForEach(Console.WriteLine);

            //------------------------------------------

            //Using ForEach with Lambda Expression
            input.FindAll(x => x % 2 == 0).ForEach(x => Console.WriteLine(x));


            //Using ForEach on LINQ Result
            input.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);



        }





    }
}
