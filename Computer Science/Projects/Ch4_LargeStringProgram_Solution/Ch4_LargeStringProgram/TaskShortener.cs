using System;
using System.Threading;

namespace Ch4_LargeStringProgram
{
    internal class TaskShortener : Colors
    {

        #region Global Variables
        internal static string name = "Ethan Lawrence\t   ", period = "\t   Period 4,5,6",
            teacher = "\t    Mr. Lynch", purpose = "\nPurpose: To create a program that calculates "
                + "earnings from selling bars", endheader = "\n*************************************"
                + "*******************************************\n\n";
        internal static DateTime date = DateTime.Now;
        #endregion

        #region Headers and Footers
        internal static void Header()
        {
            CyanFont(); //Sets the color to Cyan
            TypeLineFast(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150);
        }

        internal static void Footer()
        {
            CyanFont(); //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            Console.ReadKey();
        }

        internal static void SecondHeader()
        {
            CyanFont(); //Sets the color to Cyan
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
        }
        #endregion

        internal static void ConsoleChangeSize()
        {
            int origWidth = Console.WindowWidth;
            int origHeight = Console.WindowHeight;
            Console.SetWindowSize((int)(origWidth * 1.5), (int)(origHeight * 1.5));
        }

        internal static void Loading()
        {
            CyanFont(); //Cyan Coloring
            Console.Write("\n\nLoading Results");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".\n\n");
            Thread.Sleep(500);
        }

        internal static void ErrorCatch()
        {
            Thread.Sleep(300);
            Console.Clear();
            RedFont(); //Red!
            TypeLineSlow("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.");
            //Try again buddy. Do not be a knucklehead.
            Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
        }

        #region Typing Individual Chars
        internal static void TypeLineSlow(string x)
        {
            for (int i = 0; i < x.Length; i++) //Loop
            {
                Console.Write(x[i]);
                Thread.Sleep(150); // Sleep for 150 milliseconds
            }
        }

        internal static void TypeLine(string x)
        {
            for (int i = 0; i < x.Length; i++) //Loop
            {
                Console.Write(x[i]);
                Thread.Sleep(60); // Sleep for 150 milliseconds
            }
        }

        internal static void TypeLineFast(string x)
        {
            for (int i = 0; i < x.Length; i++) //Loop
            {
                Console.Write(x[i]);
                Thread.Sleep(20); // Sleep for 150 milliseconds
            }
        }

        internal static void TypeLineSuperFast(string x)
        {
            for (int i = 0; i < x.Length; i++) //Loop
            {
                Console.Write(x[i]);
                Thread.Sleep(10); // Sleep for 150 milliseconds
            }
        }
        #endregion

        #region Ask User for....
        internal static int AskUserForInt(string x)
        {
            MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter the {0}\t\t", x);
            YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            int inputInt = Convert.ToInt32(input);
            return inputInt;
        }

        internal static double AskUserForDouble(string x)
        {
            MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter {0}\t\t", x);
            YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }

        internal static string AskUserForString(string x)
        {
            MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter {0}\t\t", x);
            YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            return input;
        }

        internal static decimal AskUserForDecimal(string x)
        {
            MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter {0}\t\t", x);
            YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            decimal inputDecimal = Convert.ToDecimal(input);
            return inputDecimal;
        }
        #endregion

    }
}