/* Author: Mr. Lynch    Title: Carpet Calculator
 * Date: 10/15/2014
 * This program is meant to . . . practice with variables and formatting
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_Chapter3_CarpetCalculator_Practice
{
    class Day1_Chapter3_CarpetCalculator_Practice
    {
        static void Main(string[] args)
        {
            #region Console Header
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter 3 - Carpet Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: Carpet Calculator\n");
            Console.WriteLine("\t\t\tDate: 10/15/2014\n");
            Console.WriteLine("\tThis program is meant to . . ."
                +"work with variables and formatting\n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Declare and initialize variables and constants
            const int INCHES_PER_FOOT = 12;
            const int FEET_PER_YARD = 3;
            const double BERBER_COST_PER_SQ_YARD = 27.95, PILE_COST_PER_SQ_YARD = 15.95;
            double lengthInFeet, widthInFeet, lengthInYards, widthInYards;
            double areaInSqYards, berberCost, pileCost;

            #region Unit Conversions
            //Unit Conversions
            //Convert Length and Width to Feet
            lengthInFeet = 23 + (5 / (double)INCHES_PER_FOOT);
            Console.WriteLine("The length in feet is {0:F4}.",lengthInFeet);
            widthInFeet = 17 + (10 / (double)INCHES_PER_FOOT);
            Console.WriteLine("The width in feet is " + widthInFeet + " more words.");

            //Convert Length and Width to Yards
            lengthInYards = (lengthInFeet / FEET_PER_YARD);
            widthInYards = (widthInFeet / FEET_PER_YARD);
            Console.WriteLine("");
            Console.WriteLine("\n\nThe length in yards is {0:F3} and the width"
                +" in yards is {1:F3}.",lengthInYards,widthInYards);
            #endregion

            //Find the area of the room
            areaInSqYards = lengthInYards * widthInYards;
            Console.WriteLine("\n\nThe area of the room in square yards is {0:N3}.",areaInSqYards);

            //Calculate the cost and display the results
            berberCost = BERBER_COST_PER_SQ_YARD * areaInSqYards;
            pileCost = PILE_COST_PER_SQ_YARD * areaInSqYards;
            Console.WriteLine("\n\n\nThe cost for Berber carpet is {0:C2}.",berberCost);
            Console.WriteLine("\n\nThe cost for Pile carpet is {0:C2}.",pileCost);

            //Practice
            //using the ++ or -- increment operator
            int g = 12;
            g = g + 5;
            double t = (g++ / (double)3);
            Console.WriteLine("\n\n\n\n\nThe double t will be {0:f3}",t);
            Console.WriteLine("\n\n\n\nThe integer g will read {0}",g);
            Console.WriteLine("\nThe second integer g will read {0}",--g);
            Console.WriteLine("\nThe third integer g will read {0}",++g);

            //using boolean variables
            bool b;
            b = ((35/5) == 7) && (4==5) && ((51-6)==45);
            Console.WriteLine("\n\n\n\nThe boolean variable b will say '{0}'",b);


            //Wait for user to acknoledge the results.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nPlease hit Enter to exit program. . ." );
            Console.Read();
        }
    }
}
