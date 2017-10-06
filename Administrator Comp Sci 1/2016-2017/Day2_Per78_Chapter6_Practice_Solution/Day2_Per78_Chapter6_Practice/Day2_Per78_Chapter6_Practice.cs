using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter6_Practice
{
    class Day2_Per78_Chapter6_Practice
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

            //Practicing with loops

            //while loop - sentinel controlled 
            //sentinel = dummy value
            string name;
            name = AskUserForString("first name");

            while (name != "-999")
            {
                Console.WriteLine("enter -999 to exit loop");
                name = AskUserForString("another name");
            }
            Console.WriteLine("Outside of while sentinel loop");

            //while loop - state controlled (flag controlled)
            bool moreData = true;
            int i = 0; // declare outside loop
            while (moreData)
            {
                i++;
                Console.WriteLine("Inside loop");
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = AskUserForString("answer (y/n)");
                if (answer == "Y" || answer == "y")
                {
                    name = AskUserForString("city name");
                }
                else
                {
                    Console.WriteLine("You are now exiting the loop, goofball");
                    moreData = false;
                }
            }
            Console.WriteLine("Outside the while state loop");
            Console.WriteLine("You ran this loop {0} times",i);

            //for loop - counter controlled
            for (int j = 0; j <= 7; j++)
            {
                Console.WriteLine("Knucklehead:\t{0}",j+1);
            }

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
        public static string AskUserForString(string x)
        {
            Console.WriteLine("Please enter your . . . {0}",x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
