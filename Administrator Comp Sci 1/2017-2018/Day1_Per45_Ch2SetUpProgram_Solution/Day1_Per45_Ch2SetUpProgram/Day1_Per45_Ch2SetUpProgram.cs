using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Form;

namespace Day1_Per45_Ch2SetUpProgram
{
    class Day1_Per45_Ch2SetUpProgram
    {
        public static void HeaderMethod()
        {
            #region Header
            //Let's create a header for our toolbox
            System.Console.WriteLine("Author: Mr. Lynch \t\t\t"
                + "Title: Chapter 2 Set Up Practice");
            //System. is not needed since we are "using System in line 1"
            // \t is the escape squence for tab over
            System.Console.WriteLine("Date: 10/12/17");
            System.Console.WriteLine("Purpose: The purpose of this program"
                + " is meant to teach you knuckleheads\n how to append "
                + "the projects when you first open them");
            // \n is used to create a new line
            Console.WriteLine("********************************************"
                + "*********************");
            #endregion
        }
        static void Main(string[] args)
        {
            HeaderMethod();

            //This is where the code begins
            Console.WriteLine("This");
            Console.WriteLine("Is");//WriteLine() automatically
            //advances to a new line once the text is printed
            Console.Write("Nuts");//Write() does not advance to next line
            Console.WriteLine("Isn't");
            Console.WriteLine("it?");

            //These do the same thing
            Console.WriteLine("Knucklehead");
            Console.Write("Knucklehead\n");

            #region End of Program
            //This is how we end the program
            //
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please hit ENTER to end program for this activity...");
            Console.Read();//You need to hit the ENTER key to end
            #endregion
            
        }
        public static void OtherMethod()
        {

        }
    }
}
