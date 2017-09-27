using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Chapter6_Practice
{
    class Day2_Chapter6_Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of program");

            #region Counter
            //counter controlled loop
            int counter = 8;
            while (counter < 15)
            {
                Console.WriteLine("Lynch");
                counter = counter + 3;
            }
            #endregion
            #region Sentinel
            //Sentinel Controlled While loop
            Console.WriteLine("Sentinel loop");
            string firstName = AskUserForInput("first name");
            int numberOfLoop = 0;
            while (firstName != "-9999")
            {
                Console.WriteLine("Inside loop");
                firstName = AskUserForInput("another first name");
                numberOfLoop++;
            }
            Console.WriteLine("we looped {0} times", numberOfLoop);
            #endregion

            //State Controlled While Loop
            bool moreData = true;
            while (moreData)
            {
                Console.WriteLine("enter a number greater than 100");
                string numString = AskUserForInput("an integer");
                int numInt = Convert.ToInt32(numString);
                if (numInt > 100)
                {
                    Console.WriteLine("Awesome job, keep going");
                }
                else
	            {
                    Console.WriteLine("Knucklehead");
                    moreData = false;
                }
            }

            //end program
            Console.WriteLine("Please hit ENTER to end program");
            Console.Read();
        }
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("Please enter a {0} or '-9999' to exit loop",x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
