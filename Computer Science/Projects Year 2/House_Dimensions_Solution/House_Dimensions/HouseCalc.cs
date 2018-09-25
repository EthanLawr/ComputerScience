using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace House_Dimensions
{
    class HouseCalc : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    Header();
                    #region Important Code
                    double length = AskUserForDouble("the length in feet."), width = AskUserForDouble("the width in feet."); //Nastygram Included
                    Console.WriteLine("You entered {0} ft for length and {1} ft for width", length, width); //Repeat of the values entered
                    double area = Area(length, width);
                    Console.WriteLine("The house has {0} sq ft of space", area); //Display of the result
                    #endregion
                    Footer();
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    ErrorFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.");
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
                    Console.Clear();
                }
                #endregion
            }
        }
        private static double Area(double x, double y)
        {
            double area = x * y;
            return Math.Round(area, 2);
        }
    }
}