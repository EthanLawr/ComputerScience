using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Chapter6_Practice
{
    class Day1_Per45_Chapter6_Practice
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

            //Practicing with various loops :)
            //while loop - sentinel controlled 
            //sentinel = dummy value
            string name = AskForString("first");
            while (name != "-9999")
            {
                Console.WriteLine("enter -9999 to exit");
                name = AskForString("another");
            }
            Console.WriteLine("now outside the sentinel loop");

            //while loop - state(flag) controlled
            bool moreData = true;
            name = AskForString("city");
            while (moreData)
            { 
                Console.WriteLine("Do you want to continue?");
                Console.WriteLine("Press (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    name = AskForString("another city");
                }
                else
                {
                    moreData = false;
                }
            }
            Console.WriteLine("Outside the state loop");

            //Counter Controlled loop (while or for loop)
            //for loop is preferred
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Knucklehead : {0}",i + 1);
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
        public static string AskForString(string x)
        {
            Console.WriteLine("Please enter {0} name",x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
