using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_Mystical6Primes
{
    class Primes : TaskShortener
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
                    bool isPrime = true;
                    Console.WriteLine("Prime Numbers : ");
                    for (int f = 2; f <= 500; f++)
                    {
                        for (int j = 2; j <= 500; j++)
                        {
                            if (f != j && f % j == 0) // Checks for if a number is prime
                            {
                                isPrime = false;
                                break;
                            }
                            if (f % 6 != 5 && f % 6 != 1) // Checks for multiples of 6
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime) Console.Write($"{f}\t" ); // Displays the primes 
                        isPrime = true; // Resets the isPrime value
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
        public static bool IsDivisible(int x, int y)
        {
            return (x % y) == 0;
        }
    }
}
