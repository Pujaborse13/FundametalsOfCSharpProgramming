using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp
{
    internal class SquareOfSumAndDifference
    {
        public void SumAndDifference()
        
        {
            Console.Write("Enter the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Enter the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());



            double sum = firstNumber + secondNumber;
            double difference = firstNumber - secondNumber;

            double squareOfSum = sum * sum;
            double squareOfDifference = difference * difference;

            Console.WriteLine("The square of sum is: " + squareOfSum);

            Console.WriteLine("The square of difference is: " + squareOfDifference);
        }

    }
}
