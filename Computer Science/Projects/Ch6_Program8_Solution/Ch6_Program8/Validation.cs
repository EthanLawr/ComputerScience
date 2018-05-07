using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace Ch6_Program8
{
    class Validation : TaskShortener
    {
        static void Main()
        {
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
                    int something = AskUserForInt("a number between 10 and 50");
                    while (something >= 50 || something <= 10)
                    {
                        Thread.Sleep(300); Console.Clear(); ErrorFont();
                        TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tInvalid response detected. Restarting");
                        TypeLineSlow(" . . .");
                        Thread.Sleep(500); Console.Clear();
                        Main();
                    }
                    #endregion
                    Console.WriteLine("Good job! You entered a valid number!");

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
