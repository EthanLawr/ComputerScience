using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_UlamHypothesis
{
    class UlamHypothesisPrgm : TaskShortener
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
                    int j, k;
                    for (j = 1; j <= 25; j++)
                    {
                        if (j > 9) Console.Write("{0} |", j); // Lists numbers for organization
                        else Console.Write("{0}  |", j);
                        k = j;
                        if (k % 2 == 1) // Even
                        {
                            k = k * 3 + 1;
                            Console.Write(" {0}", k); 
                        }
                        while (k % 2 == 0 && k != 1) // Odd
                        {
                            k = k / 2;
                            Console.Write(" {0}", k);
                        }
                        Console.WriteLine();
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
    }
}
