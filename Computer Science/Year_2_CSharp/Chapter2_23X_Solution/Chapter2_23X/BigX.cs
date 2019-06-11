using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_23X
{
    class BigX : TaskShortener
    {
        static void Main(string[] args)
        {
            ConsoleChangeSize(1.5, 2.2);
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
                    int j, k = 23;
                    for (j = 1; j <= 11; j++)
                    {
                        Console.WriteLine(repeat(' ', j - 1) + j + repeat(' ', k - j) + k-- + "\n");
                    }
                    Console.WriteLine(repeat(' ', k) + j+ "\n");
                    k++;
                    for (j = 11; j >= 1; j--)
                    {
                        Console.WriteLine(repeat(' ', j - 1) + j + repeat(' ', k - j) + k++ + "\n");
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
