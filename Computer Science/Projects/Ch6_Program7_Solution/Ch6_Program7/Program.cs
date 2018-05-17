using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program7
{
    class Program : TaskShortener
    {
        static void Main()
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
                    for (int a = 1; a <= 10; a++)
                    {
                        for (int b = 1; b <= 10; b++)
                        {
                            int number = a * b;
                            Console.Write("{0}\t", number);
                        }
                        Console.WriteLine("\n");
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