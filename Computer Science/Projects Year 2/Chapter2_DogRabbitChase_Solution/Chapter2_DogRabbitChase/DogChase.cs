using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_DogRabbitChase
{
    class DogChase : TaskShortener
    {
        static void Main(string[] args)
        {
            ConsoleChangeSize();
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
                    // 3 jumps, 1 distance jump, 13 rabbit jumps ahead
                    // 2 jumps, 2 distance jump, 0 jump start
                    int d = 0, f = 0; // F states the amount of jumps
                    double rres = 0;
                    for (int r = 13; r >= d; r += 1) // R is 13 for the 13 jump headstart
                    {
                        f++;
                        rres += 1;
                        if (rres >= 1.5) // Done so that the rabbit jumps more often than the dog
                        {
                            rres -= 1.5;
                            f++;
                            d += 2;
                        }

                        if (r - d <= 0) break;
                        Console.Write("{0}d{1}r\n", repeat(' ', d), repeat(' ', r - d)); // Repeat allows the amount of jumps to be done automatically

                    }
                    Console.Write("It took the dog {0} jumps to catch up to the rabbit", f);
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
        private static string repeat(char x, int n)
        {
            return new String(x, n);
        }
    }
}
