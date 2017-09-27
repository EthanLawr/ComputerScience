using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch4_MethodPractice2_Day2
{
    class Ch4_MethodPractice2_Day2
    {
        static void Main(string[] args)
        {
            #region AskUserForInput
            string firstName = AskUserForInput("first name");
            string lastName = AskUserForInput("last name");
            string password = AskUserForInput("password");

            Console.WriteLine("\nYour full name is {0} {1}",firstName,lastName);
            Console.WriteLine("\nYour password is {0}",password);
            #endregion

            double exam1 = AskUserForExamScore("exam 1 score");
            double exam2 = AskUserForExamScore("exam 2 score");

            double examAverage = CalculateExamAverage(exam1, exam2);
            Console.WriteLine("Your exam average is {0}",examAverage);

            Console.WriteLine("\nPlease hit ANY key to end program . . . ");
            Console.ReadKey();
        }
        public static double CalculateExamAverage(double x, double y)
        {
            double testAverage = (x + y) / 2;
            return testAverage;
        }

        public static double AskUserForExamScore(string specificQuestion)
        {
            Console.Write("\nPlease enter your {0}\t", specificQuestion);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string inputString = Console.ReadLine();
            double inputDouble = Convert.ToDouble(inputString);
            return inputDouble;
        }

        public static string AskUserForInput(string specificQuestion)
        {
            Console.WriteLine("\nPlease enter your {0}", specificQuestion);
            string inputString = Console.ReadLine();
            return inputString;
        }
    }
}
