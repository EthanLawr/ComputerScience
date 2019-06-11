using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sum_Of_Years
{
    class Sum_Of_Year : TaskShortener
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
                    int years = AskUserForInt("the years");
                    double original = AskUserForDouble("the original cost"), scrap = AskUserForDouble("the scrap cost");
                    Console.WriteLine("Year\tAnnual Dep\tAccum. Dep\tValue");
                    YearStuff(years, original, scrap);
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
        internal static void YearStuff(int x, double y, double z)
        {
            double h = 0, j = 0, hh = 0, dep = y - z; // Sets values for later use
            for (int i = x; i > 0; i--)
            {
                j += i; //Sets of a part of a fraction for later use
            }
            
            // (i / j) * y) = annual dep
            // ((h / j) * y) = total dep
            for (int i = x; i > 0; i--) {
                h += i;
                hh++; //The year
                double total_dep = (h / j) * dep, // Value of the total depreciation
                 this_dep = (i / j) * dep, // Value of the annual depreciation
                 end_cost = y - total_dep; //Final value of a year
                
                Console.WriteLine("{0}\t{1:C2}\t\t{2:C2}\t\t{3:C2}\t\t", hh, this_dep, total_dep, end_cost);
            }
        }
    }
}