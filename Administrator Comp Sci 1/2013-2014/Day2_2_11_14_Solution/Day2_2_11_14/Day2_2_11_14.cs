//Header here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_2_11_14
{
    class Day2_2_11_14
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
            string yesOrNo = AskUserForInput();

            if (yesOrNo == "yes")
            {
                Console.WriteLine("Thank you, now let's continue...");
               
            }
            else
            {
                Console.WriteLine("You're a knucklehead, why wouldn't you"
                    +" want to continue?");
            }
            #endregion

            Console.WriteLine("\nHow tall was the xmas tree at Rockefeller"
                + " Square in NYC this year?");
            Console.WriteLine("Your guess can be correct within 5 feet");
            int theirAnswer = Convert.ToInt32(Console.ReadLine());

            if (theirAnswer >= 71 && theirAnswer <= 81)
            {
                Console.WriteLine("\nYou are correct!");
                if (theirAnswer == 76)
                {
                    Console.WriteLine("\nYou are a freakin genius!");
                    Console.WriteLine("\nThat is exactly correct!");
                }
            }
            else if (theirAnswer < 71)
            {
                Console.WriteLine("You guessed too low!");
            }
            else if (theirAnswer > 81)
            {
                Console.WriteLine("You guessed too high!");
            }

            //switch (theirAnswer)
            //{
            //    case 71:
            //        Console.WriteLine("You are correct!");
            //        break;
            //    case 72:
            //        Console.WriteLine("You are correct!");
            //        break;
            //    case 73:
            //    case 74:
            //    case 75:
            //    case 77:
            //    case 78:
            //    case 79:
            //    case 80:
            //    case 81:
            //        Console.WriteLine("You are correct!");
            //        break;
            //    case 76:
            //        Console.WriteLine("You guessed exactly correct!");
            //        break;
            //    default:
            //        Console.WriteLine("You are wrong!");
            //        break;
            //}



            Console.WriteLine("\nWe will now end the program. . . ");
            Console.WriteLine("\nHit Any Key to end the program . . .");
            Console.ReadKey();
        }
        public static string AskUserForInput()
        {
            Console.WriteLine("\nWould you like to continue?");
            Console.WriteLine("\nPlease enter 'yes' or 'no'");
            string theirInput = Console.ReadLine();
            return theirInput;
        }
    }
}
