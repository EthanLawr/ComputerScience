/* Author: Mr. Lynch    Title: Chapter 3 - CarpetCalculator
 * Date: 10/14/2014
 * This program is meant to . . . work with different variables
 * and formatting.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_Chapter3_CarpetCalculator_Practice
{
    class Day2_Chapter3_CarpetCalculator_Practice
    {
        static void Main(string[] args)
        {
            #region Console Header
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter 3 - Carpet Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: CarpetCalculator\n");
            Console.WriteLine("\t\t\tDate: 10/14/2014\n");
            Console.WriteLine("\tThis program is meant to . . . work"
                +" with variables and formatting\n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Variables and Constants
            const int INCHES_PER_FEET = 12;
            const int FEET_PER_YARD = 3;
            const double BERBER_PER_SQ_YARD = 27.95, PILE_PER_SQ_YARD = 15.95;
            double lengthInFeet;
            double lengthInYards, widthInFeet, widthInYards, areaInSqYards;
            double berberCost, pileCost;

            #region Unit Conversions
            //convert length and width to feet
            lengthInFeet = 12 + (2 / (double)INCHES_PER_FEET);
            Console.WriteLine("The length in feet is " + lengthInFeet);
            widthInFeet = 14 + (7 / (double)INCHES_PER_FEET);
            Console.WriteLine("The width in feet is {0:F3}\n",widthInFeet);

            //convert length and width to yards
            lengthInYards = (lengthInFeet / FEET_PER_YARD);
            widthInYards = (widthInFeet / FEET_PER_YARD);
            Console.WriteLine("\nThe length in yards is {0}\n and the"
                +" width in yards is {1}",lengthInYards, widthInYards);
            #endregion

            //Find the area of the room in square yards
            areaInSqYards = lengthInYards * widthInYards;
            Console.WriteLine("\n\nThe area of the room in square yards is {0:F3}",areaInSqYards);
            Console.WriteLine("This can also be done like this " + areaInSqYards + " same thing");


            //Calculate the cost of each type of carpet
            berberCost = areaInSqYards * BERBER_PER_SQ_YARD;
            pileCost = areaInSqYards * PILE_PER_SQ_YARD;

            //Display the results
            Console.WriteLine("\n\n\nThe cost for Berber carpet is " + berberCost + "\n and the cost"
                +" for pile carpet is {0:C2}",pileCost);

            //Practice and notes
            //Using the ++ and -- increment operator
            int n = 42;
            n = n + 7;
            double j = (n-- / (double)3);
            Console.WriteLine("\n\n\n\n\nThe integer n is {0}",--n);
            Console.WriteLine("The integer n is now {0}",n);
            Console.WriteLine("The value for j is {0}",j);

            //working with boolean variables
            bool b;
            b = (35/5) == 7;
            Console.WriteLine("\n\n\n\nThe boolean variable b will read '{0}'",b);


            //Wait for user to acknoledge the results.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nPlease hit Enter to exit program. . ." );
            Console.Read();
        }
    }
}
