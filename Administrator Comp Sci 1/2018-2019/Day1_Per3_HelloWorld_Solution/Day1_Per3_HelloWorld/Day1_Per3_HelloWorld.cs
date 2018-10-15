using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_HelloWorld
{
    class Day1_Per3_HelloWorld
    {
        static void Main(string[] args)
        {
            //Comments show up in green
            //The computer does not look for syntax errors 
            //for comments
            //All code starts in the Main();

            #region Header
            //Header
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HelloWorld Program\n");
            // \n advances to a new line
            //code snippet cw-tab-tab
            Console.Write("Date: 9/28/18");
            Console.WriteLine("\t\tAuthor: Mr. Lynch\n");
            // \t tab over twice in this case
            Console.WriteLine("Purpose: is to familiarize ourselves"
                + " with using c#\n");
            Console.WriteLine("************************************"
                + "************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion


            NewMethod();

            //Hello World
            Console.WriteLine("Hello World! . . .");

            NewMethod();
             

            #region End Program
            //End of program (Footer)
            Console.WriteLine("\n\n\n\nPlease hit ENTER to "
                + "end program");
            Console.Read();
            #endregion
        }
        public static void NewMethod()
        {
            //This is a BLOCK comment /* and end with */
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nKnucklehead");
            Console.WriteLine("Cool kid\n\n\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            

        }
    }
}
