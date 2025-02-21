using System;
using System.Reflection;

namespace Delegates_Refelection
{
    public  class ReflectionDemo
    {
        public void ReflectionEx()
        {

            string myName = "Puja";
            Type nameType = myName.GetType();  
            Console.WriteLine("Type is : " + nameType);
            Console.WriteLine();
            
            Type t = typeof(ReflectionDemo);
            Console.WriteLine(t.Assembly);
            Console.WriteLine();


            // get typeof Enumerable and load it to Type variable e   
            Type e = typeof(Enumerable);
            Console.WriteLine("Name : {0}", e.Name);
            Console.WriteLine("Namespace : {0}", e.Namespace);
            Console.WriteLine("Base Type : {0}", e.BaseType);
            Console.WriteLine();


            // get typeof String and load it to Type variable
            Type s = typeof(String);
            Console.WriteLine("Name : {0}", s.Name);
            Console.WriteLine("Namespace : {0}", s.Namespace);
            Console.WriteLine("Base Type : {0}", s.BaseType);



        }

    }
}
