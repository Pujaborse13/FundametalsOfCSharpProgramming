using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp
{
    internal class UniqueCharactersString
    {
        public bool HasUniqueCharacters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        return false;
                }
            }
            return true;
        }

        public void CheckString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool result = HasUniqueCharacters(input);

            Console.WriteLine(result ?
                "All characters are unique." :
                "Duplicate characters found.");
        }

    }
}
