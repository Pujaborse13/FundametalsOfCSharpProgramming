using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Write a program which displays 5 your friends' names

namespace FundamentalsOfCSharp
{
    internal class DisplayFriendsName
    {
        public void DisplayFriends()
        {
            Console.WriteLine("My Friends");
            Console.WriteLine("Asmita");
            Console.WriteLine("Disha");
            Console.WriteLine("Pratibha");
            Console.WriteLine("Komal");
            Console.WriteLine("Mansi");
            Console.WriteLine("_________________________");

        }



        string[] friendsName = { "Asmita", "Disha", "Mansi", "Pratibha" };
        public void DisplayFriendsNameUsingForeachLoop()
        {
            Console.WriteLine("My Friends");
            foreach (string name in friendsName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("_________________________");

        }


        public void DisplayFriendsNameUsingForLoop()
        {
            Console.WriteLine("My Friends");
            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine(friendsName[i]);
            }
            Console.WriteLine("_________________________");

        }


        public void DisplayFriendsNameUsingWhileLoop()
        {
            Console.WriteLine("My Friends");
            int i = 0;
            while (i < friendsName.Length)
            {
                Console.WriteLine(friendsName[i]);
                i++;
            }
            Console.WriteLine("_________________________");

        }




        public void DisplayFriendNameUserInput()
        {
            int friendsNameToEnter = 5;
            String[] friendsName = new string[friendsNameToEnter];

            for (int i = 0; i < friendsNameToEnter; i++)
            {
                Console.WriteLine("Enter your Friends name");
                friendsName[i] = Console.ReadLine();
            }

            Console.WriteLine("My Friends");
            for (int i = 0; i < friendsNameToEnter; i++)
            {
                Console.WriteLine($"- {friendsName[i]}");
            }
        }


        
            
    }

}