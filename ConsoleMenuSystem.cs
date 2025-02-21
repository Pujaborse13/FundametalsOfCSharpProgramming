using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Refelection
{
    public delegate void MenueAction();
    public class ConsoleMenuSystem
    {
        public static void ShowDate()
        {

            Console.WriteLine("Current Date :" + DateTime.Now.ToShortDateString());

        }

        public static void ShowTime()
        {

            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        public static void Exit()
        {
            Console.WriteLine("Existing Application");

        }
    }
}
