using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Ch2_SetUpPractice
{
    class Day2_Per78_Ch2_SetUpPractice
    {
        static void Main(string[] args)
        {
            Day2_Per78_Ch2_SetUpPractice.Header();

            //This is where we program

            System.Console.WriteLine("This");
            //System is not needed since we are "using System" on line 1
            //WriteLine() automatically advances to the next line
            //after the text is printed
            System.Console.Write("is");
            //Write() will print the next thing on the same line
            Console.WriteLine("Crazy");

            //These two do the same thing
            Console.WriteLine("________________");
            Console.Write("Knucklehead\n");
            Console.WriteLine("\nKuncklehead");
            Console.WriteLine("________________");

            EndProgram();
        }
        public static void EndProgram()
        {
            #region End of Program
            //This is where we end our programs
            Console.WriteLine("\n\n\nPlease hit ENTER to end program...");
            Console.Read();//Read() only accepts the ENTER key
            #endregion
        }
        public static void Header()
        {
            #region Header            
            //Change the size of your console window
            Console.SetWindowSize(80, 60);
            //Create a Header
            Console.WriteLine("Author: Mr. Lynch\t\tTitle: Chapter 2 Practice");
            Console.WriteLine("\n\t\tDate: 10/13/2017");//\n is a new line
            Console.WriteLine("\nPurpose: The purpose of this"
                + " program is to show all you knuckleheads\n "
                + " how to set up a program at initialization");
            Console.WriteLine("*******************************"
                + "*****************************************\n\n");

            #endregion

        }
    }
}
