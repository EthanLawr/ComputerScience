using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Program4
{
    class Ch4_Program4
    {
        static void Main(string[] args)
        {
            HeaderFooter.Header();

            try
            {
                double lengthOfHouse = AskUserForDouble("length"); //Input the length!
                double widthOfHouse = AskUserForDouble("width"); //Input the width!

                AreaOfHouse(lengthOfHouse, widthOfHouse);
                //Display and calculation (many methods in one line)
            } catch(FormatException)
            {
                Console.Clear();
                HeaderFooter.Header();
                Colors.RedFont();
                Console.WriteLine("Try again. Dont be a knucklehead.");

                double lengthOfHouse = AskUserForDouble("length"); //Input the length!
                double widthOfHouse = AskUserForDouble("width"); //Input the width!

                AreaOfHouse(lengthOfHouse, widthOfHouse);
                //Display and calculation (many methods in one line)

                HeaderFooter.Footer();
            }





            HeaderFooter.Footer();
        }
        public static double AskUserForDouble(string x)
        {
            Colors.MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter the {0} of the house (in feet)\t\t", x);
            Colors.YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }
        public static void AreaOfHouse(double x, double y)
        {
            Colors.MagentaFont();
            Console.WriteLine("If the length of the house is {0:N2} feet, \nAnd the width"
                + " of the house is {1:N2} feet...\n", x, y);
            double AreaCalculationResult = AreaCalculation(x, y); //Calculation method
            Colors.MagentaFont(); //Reinstates font
            Console.WriteLine("Calculating {0:N2} times {1:N2}", x, y); //Shows the calculation
            HeaderFooter.Loading(); //"Loading"
            Colors.MagentaFont(); //Reinstates font
            Console.WriteLine("Then the area of the house is {0:N2} feet squared."
                , AreaCalculationResult); //Shows the area
        }
        public static double AreaCalculation(double x, double y)
        {
            double areaInFeet = x * y; //Simple return with multiplication
            return areaInFeet;
        }
    }
}
