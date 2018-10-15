using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_HelloWorld
{
    class Day2_Per78_HelloWorld
    {
        static void Main(string[] args)
        {
            //Comments are in green
            //The compiler does not check comments for 
            //syntax violations
            
            #region Header
            //Header
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Author: Mr. Lynch");//cw-tab-tab --- this is the code
            //snipet for a  Console.WriteLine();
            Console.WriteLine("\t\t\tTitle: HelloWorld\n");// \t is a tab
            Console.WriteLine("\t\t\tDate: 10/1/18\n");
            Console.WriteLine("Purpose: Is to get familiar with c# and create "
                + "a kickA$3 header");
            //use the + operator to deal with long WriteLines
            Console.WriteLine("************************************************"
                + "*****************************\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion


            //The actual code
            Console.WriteLine("Hello World . . .");

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
