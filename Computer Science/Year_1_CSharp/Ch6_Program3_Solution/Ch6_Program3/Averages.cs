using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program3
{
    class Averages : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 5; i++)                                  //Error looping
            {
                try
                {


                    Header();
                    int f = 0;
                    double g = 0;
                    #region Important Code

                    for (int j = 0; j == 0; f++)
                    {
                        double h = AskUserForDouble("a grade"); // Looped grade asking
                        if (f % 5 == 0)
                            Console.WriteLine("Remember, type -1 to cancel"); //Reminds user how to cancel
                        if (h == -1)
                            break;
                        g += h; // Total score added together
                    }
                    double averageGrade = g / f; //Average
                    string check = SuperCheck(averageGrade); //Checks the grades

                    Console.Write("Your average grade is {0:N2}.\nYour letter grade"
                        + " is: {1}", averageGrade, check);
                    #endregion

                    Footer();
                    break;
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
        internal static string SuperCheck(double x)
        {
            GreenFont();

            #region Checks
            if (Enumerable.Range(90, 100).Contains((int)x)) //Checks for A scores
                return "A";
            else if (Enumerable.Range(80, 89).Contains((int)x)) //Checks for B scores
                return "B";
            else if (Enumerable.Range(70, 79).Contains((int)x)) //Checks for C scores
                return "C";
            else if (Enumerable.Range(60, 69).Contains((int)x)) //Checks for D scores
                return "D";
            else if (Enumerable.Range(0, 59).Contains((int)x)) //Checks for F scores
                return "F";
            else //You did a dumb...
                return "NaN";
            #endregion

        }
    }
}
