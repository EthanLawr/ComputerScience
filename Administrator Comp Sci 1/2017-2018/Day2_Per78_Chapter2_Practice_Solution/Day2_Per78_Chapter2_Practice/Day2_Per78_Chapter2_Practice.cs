using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter2_Practice
{
    class Day2_Per78_Chapter2_Practice
    {
        static void Main(string[] args)
        {//Programming must happen between the { }
           #region Header            
            //Change the size of your console window
            Console.SetWindowSize(80, 60);
            //Create a Header
            Console.WriteLine("Author: Mr. Lynch\t\tTitle: First Program");
            Console.WriteLine("\n\t\tDate: 9/29/2017");//\n is a new line
            Console.WriteLine("\nPurpose: The purpose of this"
                + " program is to show all you knuckleheads\n "
                + "some of the basics about programming");
            Console.WriteLine("*******************************"
                + "*****************************************\n\n");

            #endregion

            Console.WriteLine("Hello");
            Console.WriteLine("\\   \"    \'   ");
            Console.WriteLine("\\");//These are all Escape Sequences
            /*
            This is called a multi-line comment or a block comment
            Anything in here is not checked by the compiler for rule
            violations
            */

            //Insert Snipets (RMB)
            Console.WriteLine(""); //cw-tab-tab
            #region Name it here 
            //#region-tab-tab
            #endregion
            if (true)
            {
                //if-tab-tab
            }

            Console.WriteLine("");//Empty string
            Console.WriteLine("");
            
            Console.WriteLine("This is our first program");
            KnuckleHeadMethod();
            KnuckleHeadMethod();

            #region End PRogram
            //This is where we end our programs
            Console.WriteLine("\n\n\nPlease hit ENTER to end program...");
            Console.Read();//Read() only accepts the ENTER key
            #endregion
        }

        public static void KnuckleHeadMethod()
        {            
            //This new method is outside the Main() but still inside
            //the class

            Console.WriteLine("Knucklehead");
            Console.WriteLine("\a");
            Console.WriteLine("END OF KNUCKLEHEAD METHOD");
            //KnuckleHeadMethod(); Don't ever do this!
            //Because this will put you in an infinite loop



        }
    }
}
