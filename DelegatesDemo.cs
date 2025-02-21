using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates_Refelection
{

    public delegate void MessagePrint(string message);
        public class DelegatesDemo
        {

            public static void MessagePrinting(string message)
            {
                Console.WriteLine("Message : "+message);
        
            }

            public static void FilePrinting(string message)
            {

                Console.WriteLine("File : "+message);
            }

        }
}
