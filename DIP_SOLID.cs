using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{
    //Dependency Inversion Principle (DIP)
    //Rule: High-level modules should not depend on low-level modules.Both should depend
    //on abstractions (interfaces).
    internal class DIP_SOLID
    {
        //Without DIP Rule
        class MySQLDatabase{
            public void SaveData() { }
        }

        class BusinessLogic
        {
            private MySQLDatabase db = new MySQLDatabase();  // Hard dependency
        }


        //-----------------------------------------------------
        //With DIP Rule
        interface IDatabase1
        {
            void SaveData1();
        }

        class MySQLDatabase1 : IDatabase1
        {
            public void SaveData1() { }
        }

        class PostgreSQLDatabase : IDatabase1
        {
            public void SaveData1() { }
        }

        class BusinessLogic1
        {
            private IDatabase1 db;

            public BusinessLogic1(IDatabase1 database)
            {
                db = database;
            }
        }








    }
}
