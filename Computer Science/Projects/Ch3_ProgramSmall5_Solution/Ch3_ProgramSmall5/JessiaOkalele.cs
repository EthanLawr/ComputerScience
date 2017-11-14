using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_ProgramSmall5
{
    class JessiaOkalele
    {
        static void Main(string[] args)
        {
            #region Header
            Console.ForegroundColor = ConsoleColor.Cyan; //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To find Jessica's earnings!";
            //Shows the purpose of the current project
            string endheader = "\n***********************************"
                + "*********************************************\n\n";
            //Ends the header
            Console.WriteLine(name); //Writes my name
            Thread.Sleep(50); //Sustains my name
            Console.Clear(); //Clears my name
            Thread.Sleep(70); //"Loading" time
            Console.WriteLine(name + date);
            //Writes my name and the date w/ the time
            Thread.Sleep(70); //Sustains my name and the date w/ the time
            Console.Clear(); //Clears my name and the date w/ the time
            Thread.Sleep(90); //"Loading" time
            Console.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Console.Clear(); //Clears my name, the date w/ the time, and the period
            Thread.Sleep(110); //"Loading" Time
            Console.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            Thread.Sleep(130);
            Console.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Console.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(150); //"Loading" Time
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
            #endregion Header

            #region Declared Things
            string employeeName = "Jessica Oakley";
            double salesThisWeek = 28000;
            const decimal INCOME_RECEIVED_PERCENT = 0.07M;
            const decimal FEDERAL_TAX_PERCENT = 0.18M;
            const decimal SOCIAL_SECURITY_PERCENT = 0.06M;
            const decimal RETIREMENT_PLAN_PERCENT = 0.10M;
            //Time for calculations

            decimal incomeReceived = (decimal) salesThisWeek * INCOME_RECEIVED_PERCENT;
            decimal federalTax = (decimal)salesThisWeek * FEDERAL_TAX_PERCENT;
            decimal socialSecurity = (decimal)salesThisWeek * SOCIAL_SECURITY_PERCENT;
            decimal retirementPlan = (decimal)salesThisWeek * RETIREMENT_PLAN_PERCENT;
            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style stuff or something

            Console.WriteLine("Name: {0}\nSales Earned This Week: {1:C}\n\nIncome"
                + " Recieved This Week: {2:C}\nFederal Tax Cost: {3:C}\nSocial Security"
                + "Cost: {4:C}\nRetirement Plan Cost: {5:C}", employeeName, salesThisWeek
                , incomeReceived, federalTax, socialSecurity, retirementPlan);

            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer

            Console.ReadKey();
        }
    }
}
