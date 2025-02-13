using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp.LambdaExpression
{
    internal class ListLambdaOperation
    {
        public void listLambda()
        { 
            List<int> input = new List<int>(){10,12,13,14,15,16,17,18,19};
            
            //All numbers in list
            Console.Write("list numbers");
            foreach (int i in input)
            {
                Console.Write("{0} ",i);

            }
            Console.WriteLine();


            //Square of each number
            var square = input.Select(x => x * x);
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();


            //Divisible by 3
            List<int> divBy3 = input.FindAll(x => x % 3 == 0);
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();




        }


    }
}
