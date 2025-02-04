using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  3 Write a program which takes input of a place name  where you would like to visit most and 
 displays that with place with  uppercase once and then all lower case once
*/

namespace FundamentalsOfCSharp
{
    internal class VisitPlace
    {
        public void DisplayVisitPlaces()
        {
            Console.Write("Enter the place name where you would like to visit most : ");
            string placeName = Console.ReadLine();

            string upperCasePlaceName = placeName.ToUpper();
            string lowerCasePlaceName = placeName.ToLower();


            Console.WriteLine("Place Name in Uppercase: " + upperCasePlaceName);
            Console.WriteLine("Place Name in Lowercase: " + lowerCasePlaceName);
        }
    }
}
