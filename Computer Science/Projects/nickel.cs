using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace blah blah
{
    class blah blah
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
            string purpose = "\nPurpose: To find your change!";
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
            
            #region Variables
            //Total Change
            const decimal TOTAL_CHANGE = 0.92;
            
            //What the coins are worth
            const decimal WORTH_OF_A_QUARTER = 0.25;
            const decimal WORTH_OF_A_DIME = 0.10;
            const decimal WORTH_OF_A_NICKEL = 0.05;
            const decimal WORTH_OF_A_PENNY = 0.01;

            //How many coins of each there are
            decimal amountOfQuarters = (int)(TOTAL_CHANGE / WORTH_OF_A_QUARTER);
            decimal amountOfDimes = (int)((TOTAL_CHANGE % WORTH_OF_A_QUARTER) / WORTH_OF_A_DIME);
            decimal amountOfNickels = (int)(((TOTAL_CHANGE % WORTH_OF_A_QUARTER) % WORTH_OF_A_DIME) / WORTH_OF_A_NICKEL);
            decimal amountOfPennies = (int)((((TOTAL_CHANGE % WORTH_OF_A_QUARTER) % WORTH_OF_A_DIME) % WORTH_OF_A_NICKEL)
              / WORTH_OF_A_PENNY);
            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style stuff or something

            Console.WriteLine("If there is {0:C} total change in american dollars... then there are {1} quarters, "
            + "{2} dimes, {3} nickels, and {4} pennies of change", TOTAL_CHANGE, amountOfQuarters, amountOfDimes,
            amountOfNickels, amountOfPennies);

            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer

            Console.ReadKey();
        }
    }
