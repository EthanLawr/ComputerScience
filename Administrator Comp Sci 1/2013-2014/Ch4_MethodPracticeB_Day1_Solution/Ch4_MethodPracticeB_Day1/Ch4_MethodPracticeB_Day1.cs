/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch4_MethodPracticeB_Day1
{
    class Ch4_MethodPracticeB_Day1
    {
        static void Main(string[] args)
        {
            ConsoleHeader();
            #region Full Name
            HitAnyKeyToContinue();
            string firstName = AskUserForInput("first name");

            HitAnyKeyToContinue();
            string lastName = AskUserForInput("last name");

            HitAnyKeyToContinue();
            Console.WriteLine("\nYou entered {0} as your first name.", firstName);
            Console.WriteLine("\nYou entered {0} as your last name.", lastName);

            HitAnyKeyToContinue();
            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            HitAnyKeyToContinue();
            #endregion

            double exam1 = AskUserForExamScore("first");
            double exam2 = AskUserForExamScore("second");
            double exam3 = AskUserForExamScore("third");

            double examAverage = CalculateExamAverage(exam1, exam2, exam3);
            Console.WriteLine("Your exam average is {0:N2}",examAverage);

            //To end my program
            Console.WriteLine("\nPlease hit Any key to end program . . .");
            Console.ReadKey();
        }

        public static double CalculateExamAverage(double x, double y, double z)
        {
            double average = (x + y + z) / 3;
            return average;
        }

        public static double AskUserForExamScore(string specificQuestion)
        {
            Console.WriteLine("Please enter your {0} exam score", specificQuestion);
            string inputString = Console.ReadLine();
            double inputDouble = Convert.ToDouble(inputString);
            return inputDouble;
        }

        public static string AskUserForInput(string specificQuestion)
        {
            Console.WriteLine("Please enter your {0}", specificQuestion);
            string inputString = Console.ReadLine();
            return inputString;
        }

        public static void ConsoleHeader()
        {
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter 4 - Method Practice B";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: Method PracticeB\n");
            Console.WriteLine("\t\t\tDate: 11/22/2013\n");
            Console.WriteLine("\tThis program is meant to work with methods \n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void HitAnyKeyToContinue()
        {
            Console.WriteLine("\nHit any key to continue. . . ");
            Console.ReadKey();
            Console.Clear();
            ConsoleHeader();
        }

    }
}
