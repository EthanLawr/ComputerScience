using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_BermudaTriangle
{
    class Triangle : TaskShortener
    {
        static void Main(string[] args)
        {
            ConsoleChangeSize();
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(TetrisSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    Header();
                    #region Important Code
                    int userInput = AskUserForInt("A number between 1 and 10 for a multiplication triangle");
                    // Nastygram so that they cant enter any value not between 1 and 10
                    int h, j;
                    for (h = 1; h <= userInput; h++)
                    {
                        for (j = 1; j < h + 1; j++)
                        {
                            Console.Write(h * j + " "); // Basic multiplication 
                        }

                        Console.Write("\n"); // Ending of the line of multiplication
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
