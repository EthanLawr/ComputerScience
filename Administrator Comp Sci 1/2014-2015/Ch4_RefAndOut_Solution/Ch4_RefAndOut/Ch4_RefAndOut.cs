/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch4_RefAndOut
{
    class Ch4_RefAndOut
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

            string favoriteColor, saying, nickname;
            string eyeColor = "hazel";

            Console.WriteLine("\nInitially eye color is {0}",eyeColor);

            favoriteColor = AskUserForInputString("your favorite color", ref eyeColor);

            Console.WriteLine("\nYour favorite color is {0}",favoriteColor);
            Console.WriteLine("\nAfter you referenced it in the method you created"
                +" your eye \ncolor will now be {0}",eyeColor);

            TestingOutParameter(out saying, out nickname);

            Console.WriteLine("\nYour favorite saying is \"{0}\""
                +"\n\nand your nickname is '{1}'",saying, nickname);

            #region End Program
            //Wait for user to acknoledge the results.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nPlease hit Enter to exit program. . ." );
            Console.Read();
            #endregion
        }

        public static string AskUserForInputString(string x, ref string y)
        {
            y = "blue";
            Console.WriteLine("\nPlease enter ... {0}",x);
            string theirInput = Console.ReadLine();
            return theirInput;
        }

        public static void TestingOutParameter(out string x, out string y)
        {
            x = "Live Life to the fullest";
            y = "knucklehead";

        }

    }
}
