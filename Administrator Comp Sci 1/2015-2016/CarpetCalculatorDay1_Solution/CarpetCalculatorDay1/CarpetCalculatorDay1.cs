using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorDay1
{
    class CarpetCalculatorDay1
    {
        static void Main(string[] args)
        {
            #region ConsoleHeader
            Console.SetWindowSize(80, 50);
            Console.Title = "Carpet Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: CarpetCalculator\tAuthor: Mr. Lynch");
            Console.WriteLine("\nDate: 10/26/2015");
            Console.WriteLine("\nThis program is meant to work with all"
                +" concepts from Chapter 3");
            Console.WriteLine("*******************************************"
                +"****\n\n\n");
            #endregion

            //Declare and Initialize variables
            const int INCHES_PER_FEET = 12, FEET_PER_YARD = 3;
            const double BERBER_PER_SQYARD = 27.95;
            const double PILE_PER_SQYARD = 15.95;
            double lengthInFeet, widthInFeet, lengthInYards, widthInYards;
            double areaInSqYards, berberCost, pileCost;

            //Unit Conversions
            // convert to feet
            lengthInFeet = 13 + (5 / (double)INCHES_PER_FEET);
            //Console.WriteLine("Test : length is {0}",lengthInFeet);
            widthInFeet = 17 + (1 / (double)INCHES_PER_FEET);

            // Convert to Yards
            lengthInYards = lengthInFeet / FEET_PER_YARD;
            widthInYards = widthInFeet / FEET_PER_YARD;
            //Console.WriteLine("Test: width is {0}",widthInYards);

            //Find Area of Room
            areaInSqYards = lengthInYards * widthInYards;

            //Calculate Costs
            berberCost = BERBER_PER_SQYARD * areaInSqYards;
            pileCost = PILE_PER_SQYARD * areaInSqYards;

            //Display Results
            Console.WriteLine("The cost for Berber Carpet is {0:C2}",berberCost);
            Console.WriteLine("The cost for Pile Carpet is {0:C2}",pileCost);
            #region End Program
            //Wait for use to acknowledge results
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPlease hit ENTER to end program . . .");
            Console.Read();
            #endregion
        }
    }
}
