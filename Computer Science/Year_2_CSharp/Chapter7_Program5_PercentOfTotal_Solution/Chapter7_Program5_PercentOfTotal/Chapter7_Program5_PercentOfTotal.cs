using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program5_PercentOfTotal
{
    class Chapter7_Program5_PercentOfTotal : TaskShortener
    {
        static void Main(string[] args)
        {
            Header();
            // Getting the number of inputs needed
            int ValuesToInput = AskUserForInt("the amount of values that should be input.");
            int[] firstArray = new int[ValuesToInput];
            for (int i = 0; i < firstArray.Length; i++)
            {
                // Asking for each input number
                firstArray[i] = AskUserForInt("an integer");
            }

            int total = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                // Getting the sum of the values
                total += firstArray[i];
            }
            Console.WriteLine($"{(double)firstArray.First()/total} is the percent the first value contributes to the total.");
            Console.WriteLine($"{total} is the total value of the entered numbers");


            Footer();
        }
    }
}
