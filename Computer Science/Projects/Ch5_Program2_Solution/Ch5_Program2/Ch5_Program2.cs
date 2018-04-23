using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program2
{
    class Ch5_Program2 : TaskShortener
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
                    int month = AskUserForInt("a number that corresponds to a month (1 to 12)");

                    SuperCheck(month); //Checks the month by numbers

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
        internal static void SuperCheck(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("January - 31 days");
                    break;
                case 2:
                    Console.WriteLine("February - 28 days");
                    break;
                case 3:
                    Console.WriteLine("March - 31 days");
                    break;
                case 4:
                    Console.WriteLine("April - 30 days");
                    break;
                case 5:
                    Console.WriteLine("May - 31 days");
                    break;
                case 6:
                    Console.WriteLine("June - 30 days");
                    break;
                case 7:
                    Console.WriteLine("July - 31 days");
                    break;
                case 8:
                    Console.WriteLine("August - 31 days");
                    break;
                case 9:
                    Console.WriteLine("September - 30 days");
                    break;
                case 10:
                    Console.WriteLine("October - 31 days");
                    break;
                case 11:
                    Console.WriteLine("November - 30 days");
                    break;
                case 12:
                    Console.WriteLine("December - 31 days");
                    break;
                default:
                    Console.WriteLine("Please enter a valid month, as {0} is not valid...", x);
                    break;
            }
        }
    }
}