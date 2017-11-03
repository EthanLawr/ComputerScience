using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_Program4
{
    class VariableStuff
    {
        static void Main(string[] args)
        {
            int originalWidth = Console.WindowWidth;
            int originalHeight = Console.WindowHeight;
            Console.SetWindowSize(originalWidth, originalHeight*2);
            //Eliminating the need to use the scroll bar
            
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
            string purpose = "\nPurpose: To use variables!";
            //Shows the purpose of the current project
            string endheader = "\n********************************************************************************";
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

            int integerOne = 100; //Integer one is used through out the program
            double doubleOne = 100.01; //Double example!
            float floatOne = 100.00000001F; //Automatically rounds!
            decimal decimalOne = 100.0001M; //Decimal example!
            string numberFormat = "Standard Numeric Format Specifiers";
            //Used for the collumn length

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Base Numbers
            Console.WriteLine("The following Variables are represented:\nInt: {0}"
                + "\nDouble: {1}\nFloat: {2}\nDecimal: {3}\n\n"
                , integerOne, doubleOne, floatOne, decimalOne, numberFormat);

            //Integer
            Console.WriteLine("These {4} are represented using an integer:"
                + "\nCurrency: {0:C}\nScientific: {0:E2}\nFixed: {0:F2}"
                + "\nNumber: {0:N2}\n\n"
                , integerOne, doubleOne, floatOne, decimalOne, numberFormat);

            //Double
            Console.WriteLine("These {4} are represented using a double:"
                + "\nCurrency: {1:C}\nScientific: {1:E2}\nFixed: {1:F2}\n"
                + "Number: {1:N2}\n\n"
                , integerOne, doubleOne, floatOne, decimalOne, numberFormat);

            //Float
            Console.WriteLine("\nThese {4} are represented using a float:"
                + "\nCurrency: {2:C}\nScientific: {2:E2}\nFixed: {2:F2}\n"
                + "Number: {2:N2}\n\n"
                , integerOne, doubleOne, floatOne, decimalOne, numberFormat);

            //Decimal
            Console.WriteLine("These {4} are represented using a decimal:"
                + "\nCurrency: {3:C}\nScientific: {3:E2}\nFixed: {3:F2}"
                + "Number: {3:N2}\n\n"
                , integerOne, doubleOne, floatOne, decimalOne, numberFormat);
            Console.ResetColor();

            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer

            Console.ReadKey();
        }
    }
}
