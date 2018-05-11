using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program1
{
    class Randomizer : TaskShortener
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
                    Random r = new Random();
                    RandomNumbers(r);
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
        internal static void RandomNumbers(Random r)
        {
            int[] something = new int[1000];
            int max = -1;
            int min = 1001;
            for (int f = 1; f < 101; f++) //Loops for 100 fast random numbers
            {
                something[f] = r.Next(0, 1000); //Between 0 and 1000 for the random number
                if (max < something[f]) //Sets the Max accurately
                    max = something[f];
                if (min > something[f]) //Sets the Min accurately
                    min = something[f];
                GreenFont();
                Console.Write("[{0}]\t", f); // Displays the counter
                YellowFont();
                Console.Write(something[f]); // Displays the random number
                int even = something[f] % 2; //Gets either a 0 or a 1 for even or odd
                if (even == 0)
                {
                    CyanFont();
                    Console.Write("\t[Odd Number]\n");
                    Console.ResetColor();
                }
                if (even == 1)
                {
                    CyanFont();
                    Console.Write("\t[Even Number]\n");
                    Console.ResetColor();
                }

            }
            int calcRange = max - min; //Gets the range
            PinkFont();
            Console.WriteLine("\nRange: {0}", calcRange); //Display
            Console.WriteLine("\nMax: {0}", max);
            Console.WriteLine("\nMin: {0}", min);
        }
    }
}
 