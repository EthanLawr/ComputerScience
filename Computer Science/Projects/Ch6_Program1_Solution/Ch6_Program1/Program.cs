using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program1
{
    class Program : TaskShortener
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
                    Random r = new Random();
                    Header();
                    int[] something = new int[1000];
                    #region Important Code
                    int max = -1;
                    int min = 1001;
                    for (int f = 1; f < 101; f++)
                    {
                        something[f] = r.Next(0, 1000);
                        if (max < something[f])
                            max = something[f];
                        if (min > something[f])
                            min = something[f];
                        GreenFont();
                        Console.Write("[{0}]\t", f);
                        YellowFont();
                        int even = something[f] % 2;
                        if (even == 0)
                        Console.Write("{0}\t[Odd Number]\n", something[f], even);
                        if (even == 1)
                            Console.Write("{0}\t[Even Number]\n", something[f]);
                    }
                    int calcRange = max - min;
                    PinkFont();
                    Console.WriteLine("\nRange: {0}", calcRange);
                    Console.WriteLine("\nMax: {0}", max);
                    Console.WriteLine("\nMin: {0}", min);
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
    }
}