using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{   // *** Single Responsibility Principle (SRP)
    // The Single Responsibility Principle states that a class should have only one reason to change.

            //Without SRP Rule(Violating SRP)
    internal class SRP_SOLID
    {

        public void CalculateSalary() { }  // Salary calculation
        public void SaveToDatabase() { }   // Database operation (wrong!)
        public void GenerateReport() { }   // Report generation (wrong!)
    }


    //_____________________________________________________________________________

        //With SRP Rule
        class Employee
        {
            public void CalculateSalary() { }
        }

        class EmployeeRepository
        {
            public void SaveToDatabase() { }
        }

        class ReportGenerator
        {
            public void GenerateReport() { }
        }










}
