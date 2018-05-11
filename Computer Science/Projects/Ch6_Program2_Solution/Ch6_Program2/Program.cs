using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program2
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

                    #region Important Code
                    int sideOne = AskUserForInt("one side of a triangle"),
                        sideTwo = AskUserForInt("a second side of a triangle"),
                    sideThree = AskUserForInt("a third side of a triangle");
                    PythagoreanTest(sideOne, sideTwo, sideThree);
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
        internal static void PythagoreanTest(int x, int y, int z)
        {
            int
        }
    }
}
