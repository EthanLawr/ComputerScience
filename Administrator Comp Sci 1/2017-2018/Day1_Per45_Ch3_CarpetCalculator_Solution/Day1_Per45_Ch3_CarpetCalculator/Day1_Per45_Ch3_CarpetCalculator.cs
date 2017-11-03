using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Ch3_CarpetCalculator
{
    class Day1_Per45_Ch3_CarpetCalculator
    {
        static void Main(string[] args)
        {
            #region Header
            //Create a header
            Console.WriteLine("Author: Mr. Lynch \t\t\tTitle: Ch 3 - CarpetCalculator");
            // \t tabs over\
            Console.WriteLine(""); //This is an empty string
            Console.WriteLine("Date: 11/03/17");
            Console.WriteLine("\nPurpose: This program is meant "
                + "to show students \nsome of the basics in "
                + "programming of the chapter using the\ncarpet calculator example");
            // \n creates a new line
            Console.WriteLine("****************************************"
                + "********************\n\n\n");
            #endregion

            //Declare Constants
            const int INCHES_PER_FOOT = 12;
            const int FEET_PER_YARD = 3;
            const double BERBER_PER_SQ_YARD = 27.95, PILE_PER_SQ_YARD = 15.95;

            //Declare and initialize Variables
            int lengthFeet = 16, lengthInches = 1, widthFeet = 12, widthInches = 8;

            //Calculation . . . Don't forget to CAST!!!!!
            double lengthOfRoomInFeet = lengthFeet + (double)lengthInches / INCHES_PER_FOOT;
            Console.WriteLine(lengthOfRoomInFeet);
            double widthOfRoomInFeet = widthFeet + (double)widthInches / INCHES_PER_FOOT;
            Console.WriteLine(widthOfRoomInFeet);

            //Convert to Yards
            double lenghtYards = lengthOfRoomInFeet / FEET_PER_YARD;
            double widthYards = widthOfRoomInFeet / FEET_PER_YARD;

            double areaInYards = lenghtYards * widthYards;

            //Display the values
            Console.WriteLine("\nThe length in yards is {0:N3} and"
                + " the width in yards is {1:F3},\nthen the area in "
                + "squares yards is {2:N2}", lenghtYards, widthYards, areaInYards);

            //Find the total cost and display
            double costBerber = areaInYards * BERBER_PER_SQ_YARD;
            double costPile = areaInYards * PILE_PER_SQ_YARD;

            Console.WriteLine("\n\nThe total cost for Berber carpet is {0:C2}\nand the"
                + " total cost for Pile carpet is {1:C2}", costBerber, costPile);


            #region Footer
            //This is how we will end our program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please hit ENTER key to end program...");
            Console.Read();
            #endregion
        }
    }
}
