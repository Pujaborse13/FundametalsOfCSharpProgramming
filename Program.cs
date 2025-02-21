using Delegates_Refelection;
namespace Delegates_Refelection
{ 

    public class Program
    {

            static void Main(string[] args)
            {
            /*
            //Single method
            MessagePrint msgprint = new MessagePrint(DelegatesDemo.MessagePrinting);
            msgprint("Hello,Puja");

            //Multiple Methods
            MessagePrint msgprint = new MessagePrint(DelegatesDemo.MessagePrinting);
            msgprint += DelegatesDemo.FilePrinting;
            msgprint("Hello,Puja");
            */


            // ---------------------------------------------------------------
            Dictionary<string, MenueAction> menu = new Dictionary<string, MenueAction> {
                    {"1",ConsoleMenuSystem.ShowDate},
                    {"2",ConsoleMenuSystem.ShowTime},
                    {"3",ConsoleMenuSystem.Exit}       
                };


            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show Date");
                Console.WriteLine("2. Show Time");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (menu.ContainsKey(choice))
                {
                    menu[choice]();
                    if (choice == "3") break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }




            }
        }


    }
}