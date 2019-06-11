using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_DogRabbitChase
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
                    Header();
                    /* 3 jumps - 3 distance - rabbit 13 lead
                       2 jumps - 4 distance - dog
                    */
                    #region Important Code
                    int d = 0;
                    for (int r = 13; r <= 90; r+=3) 
                    {
                        if (r - d <= 0) { Console.Write("{0}dr\n", repeat(' ', r)); break; }
                        Console.Write("{0}d{1}r\n", repeat(' ', d), repeat(' ', r-d));
                        d += 4;
                    }
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
