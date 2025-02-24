using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples_CSharp
{
    //YAGNI (You Ain't Gonna Need It) :Implement only what is required at the moment.

   // internal class YAGNI{


        //Without YAGNI rule
        class ReportGenerator1
        {
            public void GenerateReport(string type)
            {

                if (type == "PDF")
                {
                    Console.WriteLine("Generating PDF report...");
                }
                else if (type == "Excel")
                {
                    Console.WriteLine("Generating Excel report...");
                }
                else if (type == "Word")
                {
                    Console.WriteLine("Generating Word report...");
                }
                else if (type == "HTML")
                {
                    Console.WriteLine("Generating HTML report...");
                }
            }
        }
    //_______________________________________
    //With Yagni Rule
            class ReportGenerator2
            {
                public void GeneratePDFReport()
                {
                    Console.WriteLine("Generating PDF report...");
                }
            }// ✔ Add new report types only when required!





}

