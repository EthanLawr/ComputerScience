using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_Program58b
{
    class RootsOfEquations
    {
        static void Main(string[] args)
        {
            Header(); //Header

            int numberSolved = 5;
            //X Number

            int numberOne = 10;
            //A Number
            int numberTwo = 12;
            //B Number
            int numberThree = 13;
            //C Number
            double sqrtpart = (12 * 12) - (4 * 10 * 13);
            double answer = (12 + Math.Round(Math.Sqrt(sqrtpart))) / (2 * 10);
            //numberOne(numberSolved ^ 2) + numberTwo * numberSolved + numberThree;

            Console.WriteLine("{0}\n{1:N5}", answer, Math.Round(Math.Sqrt(2)));

            Footer(); //Footer
            Console.ReadLine();
        }
        public static void Header()
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
            string purpose = "\nPurpose: To create a program that solves quadratic! "
                + "solutions";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************";
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
        }
        public static void Footer()
        {
            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer
        }
    }
}
