using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_AmericanFlag
{
    class Day2_Per78_AmericanFlag
    {
        static void Main(string[] args)
        {
            #region Header
            //Header
            Console.SetWindowSize(80, 60);//This changes the dimensions of 
            //the black console window
            Console.Title = "American Flag";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Author: Mr. Lynch");//cw-tab-tab --- this is the code
            //snipet for a  Console.WriteLine();
            Console.WriteLine("\t\t\tTitle: AmericanFlag\n");// \t is a tab
            Console.WriteLine("\t\t\tDate: 10/3/18\n");
            Console.WriteLine("Purpose: Is to work with color and formatting "
                + "using Write() \nand WriteLine() use \\t and \\n");
            //use the + operator to deal with long WriteLines
            Console.WriteLine("************************************************"
                + "*****************************\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Actual Code
            //First stripe (blue with white stars and red stripe)
            Console.ForegroundColor = ConsoleColor.White;//white stars
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            //2nd stripe (blue with white stars and white stripe)
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * ");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            //7th stripe
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * *");//Write() does not advance
            //to a new line
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            //NOw I need the solid red and white stripes
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

            #region Footer
            //End of Program
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\nPlease hit ENTER to end program . . . ");
            // \n is a new line 
            Console.Read();
            #endregion

        }
    }
}
