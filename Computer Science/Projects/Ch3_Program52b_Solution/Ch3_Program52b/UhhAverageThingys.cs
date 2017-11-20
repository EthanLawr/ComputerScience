using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_Program52b
{
    class UhhAverageThingys
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
            string purpose = "\nPurpose: To calculate averages and sums!";
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

            #region Variable Thing
            const int NUMBER_ONE = 369; const int NUMBER_THREE = 562;
            const int NUMBER_TWO = 821; const int NUMBER_FOUR = 475; 
            //Declared variables to use in later variables
            int numbersTotalSum = NUMBER_ONE + NUMBER_TWO + NUMBER_THREE
                + NUMBER_FOUR;
            //Added variables into one variable
            const int NUMBER_OF_NUMBERS = 4;
            //Amount of variables stated before
            double averageNumberThing = ((double)numbersTotalSum / NUMBER_OF_NUMBERS);
            //Average of the Numbers
            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style stuff or something

            Console.WriteLine("If the given numbers are {0}, {1}, {2},"
                + " and {3}, and there are {4} numbers...\nAnd they add up to {5}..."
                + " \nthen the average is {6:N2}. ", NUMBER_ONE,
                NUMBER_TWO, NUMBER_THREE, NUMBER_FOUR, NUMBER_OF_NUMBERS, 
                numbersTotalSum, averageNumberThing);

            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer

            Console.ReadKey();
        }
    }
}
