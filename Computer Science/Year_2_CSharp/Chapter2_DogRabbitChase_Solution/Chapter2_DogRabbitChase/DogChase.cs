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
                    int d = 0;
                    double rres = 0;
                    for (int r = 13; r >= d; r += 3)
                    {
                        if (r - d <= 0) // Check so that the loop doesn't miscalculate an extra few jumps
                        {
                            Console.WriteLine("{0}DR", repeat(' ', d));
                            break;
                        } 
                        Console.Write("{0}D{1}R\n", repeat(' ', d), repeat(' ', r-d)); // Automatic jump counts and stuff
                        //Console.Write("{0}D{1}R\n", d, r);
                        d += 4;
                        rres += 3; // Jump count
                    }
                    Console.Write("The rabbit took {0} jumps before the dog caught up", rres + 13);
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
