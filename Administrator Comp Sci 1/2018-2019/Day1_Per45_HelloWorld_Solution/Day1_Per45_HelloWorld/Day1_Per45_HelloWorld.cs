using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_HelloWorld
{
    class Day1_Per45_HelloWorld
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 60);
            Console.Beep(2000, 1500);

            #region Header
            //Comments show up in green
            //This means the compiler (C#) does not check
            //for syntax violations

            //All programing starts and ends in the Main()

            //Header
            Console.ForegroundColor = ConsoleColor.Cyan;
            //code snippet cw-tab-tab
            Console.Write("Author: Mr. Lynch\t\t\t");
            // \t escaped sequence for tab
            //Console.Write() does not advance to next line
            Console.WriteLine("Per: 4/5 Day 1\n");
            // \n new line escape sequence
            Console.WriteLine("\t\t\tDate: 9/28/18\n");
            Console.WriteLine("Purpose: Using HelloWorld to continue to"
                + " familiarize ourselves with the\nins and outs of c#");
            // use + operator to deal with "run on" sentences
            Console.WriteLine("\n****************************************"
                + "****************************************\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            Console.WriteLine("\a\a\a");

            CreateMethod();


            //Program
            Console.WriteLine("Hello World . . . ");

            CreateMethod();

            #region
            //End of Program (Footer)
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\nPlease hit ENTER to end program . . . ");
            Console.Read();
            #endregion

        }
        public static void CreateMethod()
        {
            /* Block Comment */
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\nKnucklehead\n\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
        }
    }
}
