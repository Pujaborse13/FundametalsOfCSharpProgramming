using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp.LambdaExpression
{
    internal class SquareOfNum_LambdaEx
    {

        public void SquareOFNum()
        { 
            //Using var
             var square = (int num) => num * num;
             Console.WriteLine("Square of Number :"+square(5));



            //Using Func Delegate with Statement Lambda
            Func<int, int> square1 = (num) => {
                int result = num * num;
                return result;
            };

            Console.WriteLine(square1(5));



            // delegate using lambda expression 
            Func<int, int> square2 = num => num * num;
            Console.WriteLine(square2(8));




            // Using Statement Lambda with User Input
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Func<int, int> square3 = (n) => {
                Console.WriteLine($"Calculating square of {n}");
                int result = n * n;
                return result;
            };

            Console.WriteLine($"Square: {square3(num)}");




        }

    }
}
