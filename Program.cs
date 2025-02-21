using Delegates_Refelection;
namespace Delegates_Refelection
{ 

    public class Program
    {

            static void Main(string[] args)
            {

                MessagePrint msgprint = new MessagePrint(DelegatesDemo.MessagePrinting);
                msgprint += DelegatesDemo.FilePrinting;
                msgprint("Hello,Puja");




            }


    }
}