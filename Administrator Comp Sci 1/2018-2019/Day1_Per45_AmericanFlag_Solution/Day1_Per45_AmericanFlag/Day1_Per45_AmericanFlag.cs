using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_AmericanFlag
{
    class Day1_Per45_AmericanFlag
    {
        static void Main(string[] args)
        {
            #region Header
            //Header
            Console.SetWindowSize(80, 60);//makes the black console window
            //larger
            Console.Title = "American Flag Program";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //code snippet cw-tab-tab
            Console.WriteLine("\t\t\tTitle: AmericanFlag");
            Console.Write("Author: Mr. Lynch\t\t\t\t");
            // \t escaped sequence for tab
            //Console.Write() does not advance to next line
            Console.WriteLine("Per: 4/5 Day 1\n");
            // \n new line escape sequence
            Console.WriteLine("\t\t\tDate: 10/2/18\n");
            Console.WriteLine("Purpose: to create and American Flag"
                + " and work with color and spacing");
            // use + operator to deal with "run on" sentences
            Console.WriteLine("\n****************************************"
                + "****************************************\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            
            #region Actual Code
            //Actual Code
            //first stripe (blue with white stars and red stripe
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            //2nd strip (blue with white stars and white stripe
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            //2nd strip (blue with white stars and white stripe
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            //2nd strip (blue with white stars and white stripe
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            //7th stripe
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            //first full white stripe
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");


            #endregion

            #region Footer
            //End of Program (Footer)
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\nPlease hit ENTER to end program . . . ");
            Console.Read();
            #endregion
        }
    }
}
