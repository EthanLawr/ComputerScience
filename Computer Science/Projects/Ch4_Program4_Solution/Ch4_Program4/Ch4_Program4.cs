using System;
using System.Threading;

namespace Ch4_Program4
{
    class Ch4_Program4 : Colors //A base added for convenience
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) //Error looping
            {
                try
                {
                    HeaderFooter.Header(); //Header
                    double lengthOfHouse = AskUserForDouble("length"); //Input the length!
                    double widthOfHouse = AskUserForDouble("width"); //Input the width!

                    AreaOfHouse(lengthOfHouse, widthOfHouse);
                    //Display and calculation (many methods in one line)
                    HeaderFooter.Footer(); //Footer
                    break; 
                } catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    RedFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Buddy.");
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return.
                }
            }
        }

        public static double AskUserForDouble(string x)
        {
            MagentaFont(); //Robots are magenta. Apparantly they like pink.
            Console.Write("Please enter the {0} of the house (in feet)\t\t", x);
            YellowFont(); //Humans are yellow. Atleast in this.
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }

        public static void AreaOfHouse(double x, double y)
        {
            MagentaFont();
            Console.WriteLine("If the length of the house is {0:N2} feet, \nAnd the width"
                + " of the house is {1:N2} feet...\n", x, y); //Declares the dimensions
            double AreaCalculationResult = AreaCalculation(x, y); //Calculation method
            MagentaFont(); //Reinstates font
            Console.WriteLine("Calculating {0:N2} times {1:N2}", x, y); //Shows the calculation
            HeaderFooter.Loading(); //"Loading"
            MagentaFont(); //Reinstates font
            Console.WriteLine("Then the area of the house is {0:N2} feet squared."
                , AreaCalculationResult); //Shows the area
        }

        public static double AreaCalculation(double x, double y)
        {
            double areaInFeet = x * y; //Simple return with multiplication
            return areaInFeet; //Return statement!
        }
        static void TypeLine(string x)
        {
            for (int i = 0; i < x.Length; i++) //Loop
            {
                Console.Write(x[i]);
                Thread.Sleep(150); // Sleep for 150 milliseconds
            }
        }
    }
}
