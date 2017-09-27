/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_Ch4_RefAndOut
{
    class Day1_Ch4_RefAndOut
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter # Program # - <name of program>";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: <name of title>\n");
            Console.WriteLine("\t\t\tDate: ##/##/####\n");
            Console.WriteLine("\tThis program is meant to . . . work with ref and out \n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //working with ref and out parameters

            string nickname = "Knucklehead";
            string lastName;

            //TypicalMethod(nickname);

            //Using ref parameter
            //Console.WriteLine("\nOur original nickname is {0}",nickname);
            //RefMethod(ref nickname);
            //Console.WriteLine("\nUpon return from Ref method your nickname"
            //    +" is {0}",nickname);

            //Using ref and out paremeter
            Console.WriteLine("You never assigned lastName but your nickname"
                +" is {0} before it's run in the RefAndOutMethod",nickname);
            RefAndOutMethod(ref nickname, out lastName);
            Console.WriteLine("After returning we have {0} {1}",nickname,lastName);

            #region End program
            //Wait for user to acknoledge the results.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nPlease hit Enter to exit program. . ." );
            Console.Read();
            #endregion
        }
        public static void TypicalMethod(string x)
        {
            Console.WriteLine("Your nickname is {0}",x);
        }

        public static void RefMethod(ref string x)
        {
            Console.WriteLine("\nYour nickname is {0}",x);
            x = "Dummy";
            Console.WriteLine("\nInside the ref method: {0}",x);
        }

        public static void RefAndOutMethod(ref string x, out string y)
        {
            x = "Joker";
            y = "Lynch";
        }

    }
}
