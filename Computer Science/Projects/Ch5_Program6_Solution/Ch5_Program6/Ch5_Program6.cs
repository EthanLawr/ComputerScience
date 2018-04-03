using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program6
{
    class Ch5_Program6 : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(TetrisSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    Header();

                    #region Important Code
                    Console.WriteLine("Rectangular Prisim (Rp)     Sphere (S)      Cylinder (C)");
                    string shapeChosen = AskUserForString("one of the previosly mentioned three "
                        + "dimensional shapes."); //Asks for a double
                    Loading();
                    Console.Clear();
                    SecondHeader();
                    
                    double volume = shapeCheck(shapeChosen);
                    Console.WriteLine("The shape is {0} inches cubed", volume);
                    #endregion

                    Footer();
                    break;
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    ErrorCatch();
                }
                #endregion
            }
        }
        internal static double shapeCheck(string x)
        {
            char[] charsToTrim = { '*', ' ' };
            string shapeWanted = (x.Trim(charsToTrim)).ToLower();
            GreenFont();

            if (shapeWanted == "rectangular prisim" || shapeWanted == "rp")
            {
                double height = AskUserForDouble("the height in inches.");
                double length = AskUserForDouble("the length in inches.");
                double width = AskUserForDouble("the width in inches.");
                double volume = rectangleCalculation(height, length, width);
                return volume;
            }
            else if (shapeWanted == "sphere" || shapeWanted == "s")
            {
                double radius = AskUserForDouble("the radius in inches.");
                double volume = sphereCalculation(radius);
                return volume;
            }
            else if (shapeWanted == "cylinder" || shapeWanted == "c")
            {
                double height = AskUserForDouble("the height in inches.");
                double radius = AskUserForDouble("the radius in inches.");
                double volume = cylinderCalculation(height, radius);
                return volume;
            } else
            {
                Console.WriteLine("Oops");
                return double.NaN;
            }

        }

        internal static double rectangleCalculation(double h, double l, double w)
        {
            Console.WriteLine("Calculating {0} * {1} * {2}", h, l, w);
            Loading();
            double volume = h * l * w;
            return volume;
        }

        internal static double sphereCalculation(double r)
        {
            Console.WriteLine("Calculating (4/3)(Pi){0}^3", r);
            Loading();
            double volume = (4/3)*Math.PI* Math.Pow(r, 3);
            return volume;
        }

        internal static double cylinderCalculation(double h, double r)
        {
            Console.WriteLine("Calculating (Pi){0}^2*{1}", r, h);
            Loading();
            double volume = Math.PI * Math.Pow(r, 2) * h;
            return volume;
        }
    }
}
