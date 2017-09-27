/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_2_12_2014
{
    class Day1_2_12_2014
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

            #region practice
            string yesOrNo = AskUserForYesOrNo();
            string yORn = yesOrNo.ToLower();

            if (yORn == "yes")
            {
                Console.WriteLine("Thank you for wanting to continue . . . ");
            }
            else
            {
                Console.WriteLine("You're a knucklehead, why don't you want"
                    + " to continue?");
            }
            #endregion

            Console.WriteLine("\n\n\nHow tall was the xmas tree at Rockefeller"
                + " center in NYC this year?  \nAccurate within 5 feet?");
            int theirAnswer = Convert.ToInt32(Console.ReadLine());

            if (theirAnswer >= 71 && theirAnswer <= 81)
            {
                Console.WriteLine("\nyou're right!");
                if (theirAnswer == 76)
                {
                    Console.WriteLine("\nYou're a genius! That is exactly right.");
                }
            }
            else if (theirAnswer<71)
            {
                Console.WriteLine("\nyou guessed too low");
            }
            else if (theirAnswer>81)
            {
                Console.WriteLine("\nyou guessed too high");
            }




            //switch (theirAnswer)
            //{
            //    case 71:
            //    case 72:
            //    case 73:
            //    case 74:
            //    case 75:
            //    case 76:
            //    case 77:
            //    case 78:
            //    case 79:
            //    case 80:
            //    case 81:
            //        Console.WriteLine("you're correct");
            //        break;
            //    default:
            //        Console.WriteLine("You guessed incorrectly");
            //        break;
            //}



            Console.WriteLine("\nPress ANY key to end program");
            Console.ReadKey();
        }
        public static string AskUserForYesOrNo()
        {
            Console.WriteLine("\nWould you like to continue?");
            Console.WriteLine("\nPlease enter 'yes' or 'no'");
            string inputString = Console.ReadLine();
            return inputString;
        }

    }
}
