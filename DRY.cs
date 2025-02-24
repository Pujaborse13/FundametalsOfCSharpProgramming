using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{
    internal class DRY
    { 
    //DRY (Don't Repeat Yourself) : Repeated code into reusable functions or classes.
   
        class Employee
        {
            public void PrintEmployeeDetails(string name, int age)
            {
                Console.WriteLine("Employee Name: " + name);
                Console.WriteLine("Employee Age: " + age);
            }
        }

        class Manager
        {
            public void PrintManagerDetails(string name, int age)
            {
                Console.WriteLine("Manager Name: " + name);
                Console.WriteLine("Manager Age: " + age);
            }
        }

        //___________________________
        //With DRY rule

        class Person
        {
            public void PrintDetails(string role, string name, int age)
            {
                Console.WriteLine(role + " Name: " + name);
                Console.WriteLine(role + " Age: " + age);
            }
        }

    }
}
