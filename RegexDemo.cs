using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_DemoProject
{
   public class RegexDemo
    {
        
        public void DemoEx ()
        {
            // Quantifiers, Special Characters, Character Classes, Grouping & Alternatives

            // * Used to match the preceding character zero or more times.
            Regex regex1 = new Regex(@"a*b");
            Match match1 = regex1.Match("aaaabcd");

            // + Used to match the preceding character one or more times.
            Regex regex2 = new Regex(@"a+b");
            Match match2 = regex2.Match("aaabcd");

            //? Used to match the preceding character zero or one time.
            Regex regex3 = new Regex(@"a?b");
            Match match3 = regex3.Match("aaaabcd");

            //{n}Used to match the preceding character exactly n times.
            Regex regex4 = new Regex(@"a{1}b");
            Match match4 = regex4.Match("aaaabcd");

            //{ n, }Used to match the preceding character at least n times.
            Regex regex5 = new Regex(@"p{4,}b");
            Match match5 = regex5.Match("ppppbcd");

            //{ n,m } Used to match the preceding character from n to m times.
            Regex regex6 = new Regex(@"a{2,6}bck");
            Match match6 = regex6.Match("aaaabcd");


            if (match1.Success)
            {
                Console.WriteLine("1.Match Value : " + match1.Value);
            }

            if (match2.Success)
            {
                Console.WriteLine("2.Match Value : " + match2.Value);
            }


            if (match3.Success)
            {
                Console.WriteLine("3.Match Value : " + match3.Value);
            }

            if (match4.Success)
            {
                Console.WriteLine("4.Match Value : " + match4.Value);
            }

            if (match5.Success)
            {
                Console.WriteLine("5.Match Value : " + match5.Value);
            }

            if (match6.Success)
            {
                Console.WriteLine("6.Match Value : " + match6.Value);
            }


            //_____________________________________________________________
            //          ******Special Characeter **********

            // ^ Word after this element matches at the beginning of the string or line.
            Regex regex7 = new Regex(@"^Shyam");
            Match match7 = regex7.Match("Shyam is my pet name");

                if (match7.Success)
                {
                    Console.WriteLine("7.Match Value: " + match7.Value);
            }


            //$	Word before this element matches at the end of the line or string.
            Regex regex8 = new Regex(@"Parth$");
            Match match8 = regex8.Match("My name is Parth");

            if (match8.Success)
            {
                Console.WriteLine("8.Match Value: " + match8.Value);
            }

            //.(Dot)  Matches any character only once expect \n(new line).
            Regex regex9 = new Regex(@"s..t");
            Match match9 = regex9.Match("This is my seat");

            if (match9.Success)
            {
                Console.WriteLine("9.Match Value: " + match9.Value);
            }

            //\d It is use to match the digit character.
            Regex regex10 = new Regex(@"\d");
            Match match10 = regex10.Match("I am 19 years old");

            if (match10.Success)
            {
                Console.WriteLine("10.Match Value: " + match10.Value);  // Output: 1 (First matched digit)
            }

            //\D It is use to match the non - digit character.
            Regex regex11 = new Regex(@"\D");
            Match match11 = regex11.Match("I am 19 years old");

            if (match11.Success)
            {
                Console.WriteLine("11.Match Value: " + match11.Value); // Output: I (First matched non-digit)
            }


            Regex regex12 = new Regex(@"\w");
            Match match12 = regex12.Match("Hello_World123");

            if (match12.Success)
            {
                Console.WriteLine("12.Match Value: " + match12.Value);  // Output: H (First matched alphanumeric character)
            }

            // \W - Matches any non-word character (e.g., space, punctuation).
            Regex regex13 = new Regex(@"\W");
            Match match13 = regex13.Match("Hello, World!");

            if (match13.Success)
            {
                Console.WriteLine("13.Match Value: " + match13.Value);  // Output: , (First matched non-word character)
            }

            // \s - Matches any whitespace character (space, tab, newline).
            Regex regex14 = new Regex(@"\s");
            Match match14 = regex14.Match("Hello World");

            if (match14.Success)
            {
                Console.WriteLine("14.Match Value: (Whitespace Found)");  // Output: (Whitespace Found)
            }

            // \S - Matches any non-whitespace character.
            Regex regex15 = new Regex(@"\S");
            Match match15 = regex15.Match("   Hello");

            if (match15.Success)
            {
                Console.WriteLine("15.Match Value: " + match15.Value);  // Output: H (First non-whitespace character)
            }

            // \n - Matches a newline character.
            Regex regex16 = new Regex(@"\n");
            Match match16 = regex16.Match("Hello\nWorld");

            if (match16.Success)
            {
                Console.WriteLine("16.Newline Found!");  // Output: Newline Found!
            }

            //______________________________________________________________________________
            //****************  Character Class **********


            //[] It is used to match the range of character
            Regex regex17 = new Regex(@"[abc]");
            Match match17 = regex17.Match("xyz abc");

            if (match17.Success)
            {
                Console.WriteLine("17.Match Value : "+match17.Value);  
            }

            //[a - z]   It is used to match any character in the range of a-z.
            Regex regex18 = new Regex(@"[a-z]");
            Match match18 = regex18.Match("Hello123");

            if (match18.Success)
            {
                Console.WriteLine("18.Match Value: " + match18.Value);  // Output: e (First lowercase letter matched)
            }


            //[^a - z]  It is used to match any character not in the range of a-z.
            Regex regex19 = new Regex(@"[^a-z]");
            Match match19 = regex19.Match("hEllo123");

            if (match19.Success)
            {
                Console.WriteLine("19.Match Value: " + match19.Value);  // Output: 1 (First non-lowercase character)
            }



            // [0-9] - Matches any digit from 0 to 9
            Regex regex20 = new Regex(@"[0-9]");
            Match match20 = regex20.Match("Price is 250$");

            if (match20.Success)
            {
                Console.WriteLine("20.Match Value: " + match20.Value);  // Output: 2 (First digit matched)
            }


            //\	It is used to match Escaped special character.
            Regex regex21 = new Regex(@"\.");
            Match match21 = regex6.Match("File name: example.txt");

            if (match21.Success)
            {
                Console.WriteLine("21.Match Value: " + match21.Value);  // Output: . (Dot matched)
            }

            // Escaped Special Character (\) - Matches a literal dollar sign ($)
            Regex regex22 = new Regex(@"\$");
            Match match22 = regex22.Match("The price is $100");

            if (match22.Success)
            {
                Console.WriteLine("22.Match Value: " + match22.Value);  // Output: $ (Dollar sign matched)
            }


            // Escaped Special Character (\) - Matches a literal backslash (\)
            Regex regex23 = new Regex(@"\\");
            Match match23 = regex23.Match("C:\\Users\\Puja\\Documents");

            if (match23.Success)
            {
                Console.WriteLine("23.Match Value: " + match23.Value);  // Output: \ (Backslash matched)
            }
            //_____________________________________________________________
            //*************** Grouping and Alternatives ***********


            // () - Grouping: Used to treat multiple characters as a single unit
            Regex regex24 = new Regex(@"(Hello) World");
            Match match24 = regex24.Match("Hello World");

            if (match24.Success)
            {
                Console.WriteLine("24.Match Value: " + match24.Value);  // Output: Hello World
            }

            // (a|b) - OR operator: Matches either 'a' or 'b'
            Regex regex25 = new Regex(@"(cat|dog)");
            Match match25 = regex25.Match("I love my dog");

            if (match25.Success)
            {
                Console.WriteLine("25.Match Value: " + match25.Value);  // Output: dog
            }

            // (?(exp) yes|no) - Conditional Matching
            // If 'Hello' is present, it should match 'Yes'; otherwise, 'No'.
            Regex regex26 = new Regex(@"(?(Hello) Yes|No)");
            Match match26 = regex26.Match("Hello");

            if (match26.Success)
            {
                Console.WriteLine("26.Match Value: " + match26.Value);  // Output: Yes
            }
            else
            {
                Console.WriteLine("26.Match Value: No");  // If 'Hello' is not found, Output: No
            }



        }
    }
}
