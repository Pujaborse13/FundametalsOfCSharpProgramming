using Delegates_Refelection;
namespace Delegates_Refelection
{ 

    public class Program
    {

            static void Main(string[] args)
            {

                MessagePrint msgprint = new MessagePrint(DelegatesDemo.MessagePrinting);
                msgprint("Hello,Puja");



            }


    }
}