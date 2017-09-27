using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorDay2
{
    class CarpetCalculatorDay2
    {
        static void Main(string[] args)
        {
            #region ConsoleHeader
            Console.SetWindowSize(80, 50);
            Console.Title = "CarpetCalculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: CarpetCalculator\tAuthor: Mr. Lynch");
            Console.WriteLine("\nDate: 10/27/2015");
            Console.WriteLine("\nThis program is meant to work with"
                +" Chapter 3 stuff. . .");
            Console.WriteLine("*******************************************"
                +"****\n\n\n");
            #endregion

            //Declare and Initialize Variables
            double lengthInFeet;
            double widthInFeet;
            const int INCHES_IN_FOOT = 12, FEET_IN_YARD = 3;
            double lengthInYards, widthInYards, areaInSqYards;
            const double BERBER_SQ_YARDS = 27.95, PILE_SQ_YARDS = 15.95;
            double berberCost, pileCost;

            //Unit Conversions
            //To Feet
            lengthInFeet = 13 + (1 / (double)INCHES_IN_FOOT);
            Console.WriteLine("test: lenght is {0}",lengthInFeet);
            widthInFeet = 16 + (5 / (double)INCHES_IN_FOOT);

            //To Yards
            lengthInYards = lengthInFeet / FEET_IN_YARD;
            widthInYards = widthInFeet / FEET_IN_YARD;

            //Calculate Area
            areaInSqYards = lengthInYards * widthInYards;
            Console.WriteLine("Test: Area is {0}",areaInSqYards);

            //Display the cost
            berberCost = areaInSqYards * BERBER_SQ_YARDS;
            pileCost = areaInSqYards * PILE_SQ_YARDS;
            Console.WriteLine("\n\nThe cost for Berber is {0:C2}",berberCost);
            Console.WriteLine("\n\nThe cost for Pile is {0:C2}",pileCost);

            #region End of Program
            //Wait for use to acknowledge results
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPlease hit ENTER to end program . . .");
            Console.Read();
            #endregion
        }
    }
}
