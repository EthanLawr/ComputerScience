using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Exercise3
{
    class Ch4_Exercise3
    {
        static void Main(string[] args)
        {
            HeaderFooter.Header(); //Header
            Colors.MagentaFont(); //Magenta Font
            double firstNumber = AskUserForDouble(" your first number"); //Whats your first name
            double secondNumber = AskUserForDouble(" your second number"); //Whats your last name
            HeaderFooter.Loading(); //Loading
            Console.Clear(); //Console cleared!
            HeaderFooter.SecondHeader(); //Second header after the reset
            Colors.YellowFont(); //Yellow font added
            NumberCalculation(firstNumber, secondNumber); //Bep. Your answers.

            Console.WriteLine("\n\n"); // Spacing!
            HeaderFooter.Footer(); //Footer 
        }

        public static double AskUserForDouble(string x)
        {
            Console.WriteLine("Please enter{0}", x);
            string input = Console.ReadLine();
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }

        public static void NumberCalculation(double a, double b)
        {
            if (a > b)
            {
                double numberCalculations = Math.Round(Math.Sqrt(b));
                Console.WriteLine("If your numbers are {0} and {1} then"
                    + " your smallest possible square root is {2}", a, b, numberCalculations);
            } else
            {
                double numberCalculations = Math.Round(Math.Sqrt(a));
                Console.WriteLine("If your numbers are {0} and {1} then"
                    + " your smallest possible square root is {2}", a, b, numberCalculations);
            }
        }
    }
}
