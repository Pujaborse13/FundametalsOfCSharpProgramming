using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Read a number from user as string and print 10 times of that number as string only
namespace FundamentalsOfCSharp
{
    internal class ReadNumberAsAString
    {
        public void ReadNumberUsingToInt32()
        {
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();
            Console.WriteLine((Convert.ToInt32(input) * 10).ToString());

        }

        public void ReadNumberUsingParse()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            Console.WriteLine((int.Parse(input) * 10).ToString());
        }


    }
}
