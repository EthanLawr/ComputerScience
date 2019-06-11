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
            for (int i = 0; i < 100; i++)                                  //Error looping
            {
                try
                {
                    Header();

                    #region Important Code
                    Console.WriteLine("Rectangular Prisim (Rp)     Sphere (S)      Cylinder (C)");
                    string shapeChosen = AskUserForString("one of the previosly mentioned three "
                        + "dimensional shapes."); //Asks for the shape
                    Loading();
                    Console.Clear();
                    SecondHeader();
                    
                    double volume = shapeCheck(shapeChosen); //Gets the shape and calculates its volume
                    if (volume <= 0) //Did you pick no shape? Or did you enter an invalid number
                        Console.WriteLine("Try again. Enter something valid.");
                    else
                        Console.WriteLine("The shape is {0} inches cubed", volume);
                    #endregion

                    Footer();
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    RedFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.");
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
                    Console.Clear();
                }
                #endregion
            }
        }
        internal static double shapeCheck(string x)
        {
            char[] charsToTrim = { '*', ' ' };
            string shapeWanted = (x.Trim(charsToTrim)).ToLower();
            GreenFont();

            if (shapeWanted == "rectangular prisim" || shapeWanted == "rp") //Is it a rectangular prisim?
            {
                double height = AskUserForDouble("the height in inches."),
                 length = AskUserForDouble("the length in inches."),
                 width = AskUserForDouble("the width in inches."),
                 volume = rectangleCalculation(height, length, width);
                return volume;
            }
            else if (shapeWanted == "sphere" || shapeWanted == "s") //Is it a sphere?
            {
                double radius = AskUserForDouble("the radius in inches.");
                double volume = sphereCalculation(radius);
                return volume;
            }
            else if (shapeWanted == "cylinder" || shapeWanted == "c") //Is it a cylinder?
            {
                double height = AskUserForDouble("the height in inches."),
                 radius = AskUserForDouble("the radius in inches."),
                 volume = cylinderCalculation(height, radius);
                return volume;
            } else //Choose one of the options bruh
            {
                Console.WriteLine("Oops"); 
                return 0;
            }

        }

        internal static double rectangleCalculation(double h, double l, double w)
        {
            Console.WriteLine("Calculating {0} * {1} * {2}", h, l, w); 
            Loading();
            double volume = h * l * w; //Volume of a Rectangular Prisim
            return volume;
        }

        internal static double sphereCalculation(double r)
        {
            Console.WriteLine("Calculating (4/3)(Pi){0}^3", r);
            Loading();
            double volume = (4/3)*Math.PI* Math.Pow(r, 3); //Volume of a sphere
            return volume;
        }

        internal static double cylinderCalculation(double h, double r)
        {
            Console.WriteLine("Calculating (Pi){0}^2*{1}", r, h); //Volume of a cylinder
            Loading();
            double volume = Math.PI * Math.Pow(r, 2) * h;
            return volume;
        }
    }
}
