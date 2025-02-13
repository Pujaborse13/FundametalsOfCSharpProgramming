using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfCSharp
{
    class Dog
    {
        public string Name
        { get; set; }
        public int Age 
        { get; set; }
    }
     public class CheckName
    {

        public void CheckNameList()
        {

              List<Dog> dogs = new List<Dog>
                {
                new Dog { Name = "Rex", Age = 4 },
                new Dog { Name = "Sean", Age = 0 },
                new Dog { Name = "Stacy", Age = 3 }


                };

                 //print name
                var names = dogs.Select(x => x.Name);
                foreach (var name in names)
                {
                    Console.WriteLine(name);

                }

                //Print age and first letter of name
                var newDogList = dogs.Select(x => new {Age = x.Age , FirstLetter = x.Name[0] });

                    foreach (var item in newDogList)
                    {
                        Console.WriteLine(item);
                    }

                //Sorting using a lambda expression
                var sortedDogs = dogs.OrderByDescending(x => x.Age);
                foreach (var dog in sortedDogs)
                {
                    Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
                }
       
        }   
   
     }

}
