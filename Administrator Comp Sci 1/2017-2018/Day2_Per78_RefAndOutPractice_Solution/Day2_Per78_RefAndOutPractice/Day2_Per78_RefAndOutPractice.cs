using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_RefAndOutPractice
{
    class Day2_Per78_RefAndOutPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ref and Out Practice\n\n");

            //ref and out parameters
            string lunch = "pb and j";//uses "ref" because declared and initialized
            double battingAverage;//uses "out" because only declared
            Console.WriteLine("\nYou ate {0} for lunch today", lunch);

            string dinner = AskUserForString("dinner", ref lunch, out battingAverage);
            //lunch and battingAverage will be sent into the AskUserForString();
            //and when they are changed in that method they will be stored as
            //different valued back here in the Main();

            Console.WriteLine("\nAfter using the method with ref and out"
                + " you ate {0} for lunch, {1} for dinner, and {2} was"
                + " your batting average", lunch, dinner, battingAverage);

            Console.Read();
        }
        public static string AskUserForString(string x, ref string y, out double z)
        {
            Console.WriteLine("\n\nPlease enter what you at for {0}",x);
            string input = Console.ReadLine();
            y = "pizza";//y is the placeholder for lunch, so if it's changed
            //inside the method, it will also change in the Main();
            z = 0.3343;//z is the placeholder for battingAverage and it
            //was never initiallized so it gets assigned a value inside 
            //this method and stores that value back in the Main();
            return input;//officially returns one thing from the method
            //What you ate for "dinner"

        }

    }
}
