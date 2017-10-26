using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Form;

namespace Day1_Per3_SetUpProgram
{
    class Day1_Per3_SetUpProgram
    {
        public static void NewMethod()
        {


        }
        static void Main(string[] args)
        {
            #region Header
            //Create a header
            System.Console.WriteLine("Author: Mr. Lynch \t\t\t"
                + "Title: Chapter 2 Practice Program");
            // \t tabs over\
            Console.WriteLine(""); //This is an empty string
            Console.WriteLine("Date: 10/12/17");
            Console.WriteLine("\nPurpose: This program is meant "
                + "to show students \nhow to append _Solution "
                + "when we first open a program");// \n creates a new line
            Console.WriteLine("****************************************"
                + "********************");
            #endregion

            //This is where we code
            Console.WriteLine("Dan");
            Console.Write("Lynch"); //Write() does not 
            //advance to next line
            Console.WriteLine("Comp Sci");
            Console.Write("Teacher\n");//No difference bewteen
            Console.WriteLine("Teacher");//These two lines
            Console.WriteLine("Knucklehead");


            #region End of Program
            //This is how we will end our program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please hit ENTER key to end program...");
            System.Console.Read(); //System is not needed in front
            #endregion
        }
        public static void OtherMethod()
        {

        }
    }
}
