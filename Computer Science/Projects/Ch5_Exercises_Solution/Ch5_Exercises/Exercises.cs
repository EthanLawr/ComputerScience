using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Exercises
{
    class Exercises : TaskShortener
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

                    #region Activity 1
                    int numberThing = AskUserForInt("a cool number");
                    ActivityOneCoolNumber(numberThing);
                    #endregion

                    #region Activity 2
                    int numberThingTwo = AskUserForInt("a cool number");
                    ActivityTwoCoolNumber(numberThingTwo);
                    #endregion

                    #region Activity 3
                    int numberThingThree = AskUserForInt("a cool number");
                    int numberThingFour = AskUserForInt("a cool number");
                    ActivityThreeCoolNumber(numberThingThree, numberThingFour);
                    #endregion

                    Footer();
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    ErrorCatch();
                }
                #endregion
            }
        }

        internal static void ActivityOneCoolNumber(int x)
        {
            if (x == 5)
            {
                Console.WriteLine("Number 5 is a cool number!");
                Loading();
                Console.Clear();
                SecondHeader();
            } else
            {
                Loading();
                Console.Clear();
                SecondHeader();
            }
        }

        internal static void ActivityTwoCoolNumber(int x)
        {
            if (x == 5)
            {
                Console.WriteLine("Number 5 is a cool number!");
                Loading();
                Console.Clear();
                SecondHeader();
            }
            else
            {
                Console.WriteLine("You didn’t pick 5! Not Cool!");
                Loading();
                Console.Clear();
                SecondHeader();
            }
        }

        internal static void ActivityThreeCoolNumber(int x, int y)
        {
            if (x == 5)
            {
                Console.WriteLine("Number 5 is a cool number!");
            }
            else if (y == 5)
            {
                Console.WriteLine("The second number, 5, is a cool number!");
            }
            else 
            {
                Console.WriteLine("You didn’t pick 5! Not Cool!");
            }
        }

    }
}
