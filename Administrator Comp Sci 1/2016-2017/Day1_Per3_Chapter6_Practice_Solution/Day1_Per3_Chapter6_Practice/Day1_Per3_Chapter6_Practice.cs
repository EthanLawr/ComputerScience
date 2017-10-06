using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_Chapter6_Practice
{
    class Day1_Per3_Chapter6_Practice
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //While Loop (sentinel controlled)
            //sentinel = dummy value
            string name = AskUserForString();
            while (name != "-99")
            {
                Console.WriteLine("-99 will exit loop");
                name = AskUserForString();
                
            }
            Console.WriteLine("Now . . . Outside of sentinel Loop");

            //while loop (state controlled = flag controlled)
            Console.WriteLine("Start of state controlled loop");
            bool moreData = true;
            string city = AskUserForString();
            while (moreData)
            {
                Console.WriteLine("Would you like to continue?");
                Console.WriteLine("Press (y/n)");
                string answer = Console.ReadLine();    
                if (answer == "y")
                {
                    city = AskUserForString();
                }
                else
                {
                    moreData = false;
                }
            }
            Console.WriteLine("Outside of state controlled loop");


            //Counter Controlled Loop (While or For loop)
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Knucklehead");
            }
            Console.WriteLine("Outside of for loop");

            #region This is where we end the program
            //End any program
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\nPlease hit the ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ENTER ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" key to end program . . . ");
            Console.Read();
            #endregion
        }
        public static string AskUserForString()
        {
            Console.WriteLine("Please enter a name . . .");
            string input = Console.ReadLine();
            return input;
        }
    }
}
