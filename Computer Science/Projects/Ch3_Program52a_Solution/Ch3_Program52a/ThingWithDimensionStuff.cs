using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_Program52a
{
    class ThingWithDimensionStuff
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
            string purpose = "\nPurpose: To calculate dimensions!";
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

            const int LENGTH = 82;
            //Declared Length
            const int WIDTH = 143;
            //Declared Width
            int perimeter = (WIDTH * 2) + (LENGTH * 2);
            //Formula to find perimeter
            int area = WIDTH * LENGTH;
            //Formula to find the area
            #endregion
     
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style stuff or something

            Console.WriteLine($"If the length is {LENGTH} units and the"
            + $" width of the rectangle is {WIDTH} units...\nthen the "
            + $"perimeter is {perimeter} units and the area is {area} units.");

            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            #endregion Footer

            Console.ReadKey();
        }
    }
}
