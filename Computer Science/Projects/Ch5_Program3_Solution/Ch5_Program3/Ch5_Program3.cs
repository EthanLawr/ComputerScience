using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program3
{
    class Ch5_Program3 : TaskShortener
    {
        static void Main(string[] args)
        {
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
                    double scoreOne = AskUserForDouble("one grade");
                    /*   scoreTwo = AskUserForDouble("a second grade"),
                       scoreThree = AskUserForDouble("a third grade"),
                       scoreFour = AskUserForDouble("a fourth grade"),
                       scoreFive = AskUserForDouble("a fifth grade");*/

                    SuperCheckOne(scoreOne);
                    #endregion
                    Footer();
                    break;
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    ErrorCatch();
                }
                #endregion
            }
        }
        internal static void SuperCheckOne(double x)
        {
            GreenFont();

            #region Checks
            if (Enumerable.Range(90, 100).Contains((int)x))
            {
                Console.Write("You have an A!");
            }
            else if (Enumerable.Range(80, 89).Contains((int)x))
            {
                Console.Write("You have a B!");
            }
            else if (Enumerable.Range(70, 79).Contains((int)x))
            {
                Console.Write("You have a C!");
            }
            else if (Enumerable.Range(60, 69).Contains((int)x))
            {
                Console.Write("You have a D!");
            }
            else if (Enumerable.Range(0, 59).Contains((int)x))
            {
                Console.Write("You have an F!");
            } else
            {
                Console.Write("Please enter a valid score!");
            }
            #endregion

        }
    }
}
