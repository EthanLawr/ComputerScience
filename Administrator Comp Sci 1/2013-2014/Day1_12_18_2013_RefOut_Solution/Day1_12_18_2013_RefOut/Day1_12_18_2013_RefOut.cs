/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_12_18_2013_RefOut
{
    class Day1_12_18_2013_RefOut
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter # Program # - <name of program>";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: <name of title>\n");
            Console.WriteLine("\t\t\tDate: ##/##/####\n");
            Console.WriteLine("\tThis program is meant to . . . \n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            double scott = 34.6;
            double cheese;

            //Old stuff, Test a default method
            Console.WriteLine("\n\nThe orginal value is {0}",scott);
            TestDefault(scott);
            Console.WriteLine("\nUpon return from TestDefault the value "
                + "is {0}",scott);

            //Use the ref parameter
            Console.WriteLine("\n\nThe orginal value is {0}", scott);
            TestRef(ref scott);
            Console.WriteLine("\nUpon return from TestRef the value "
                + "is {0}", scott);

            //Use the out parameter
            TestOut(out cheese);
            Console.WriteLine("\nUpon return from TestOut the value "
                + "is {0}", cheese);

            Console.Read();
        }
        public static void TestDefault(double x)
        {
            x = 12.87;
            Console.WriteLine("\nIn TestDefault, the value is {0}",x);
        }
       
        public static void TestRef(ref double x)
        {
            x = 0.47;
            Console.WriteLine("\nIn TestRef, the value is {0}", x);
        }

        public static void TestOut(out double x)
        {
            x = 5.0;
            Console.WriteLine("\nIn TestOut, the value is {0}", x);
        }
    }
}
