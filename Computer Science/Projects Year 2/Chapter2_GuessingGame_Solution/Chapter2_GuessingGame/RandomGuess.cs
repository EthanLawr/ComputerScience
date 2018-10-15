using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter2_GuessingGame
{
    class RandomGuess : TaskShortener
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
                    Random random = new Random();

                    int someNumber = random.Next(1, 100);

                    Console.WriteLine("There is a random integer between 0 and 100. Please try to guess what it is!");
                    int userGuess = AskUserForInt("a number.");
                    while (userGuess != someNumber)
                    {
                        while (userGuess < someNumber)
                        {
                            Console.WriteLine($"Sorry! That's incorrect! The answer is higher than {userGuess}");
                            userGuess = AskUserForInt("another number.");
                        }
                        while (userGuess > someNumber)
                        {
                            Console.WriteLine($"Sorry! That's incorrect! The answer is lower than {userGuess}.  Please try again!");
                            userGuess = AskUserForInt("another number.");
                        }
                    }
                    if (userGuess == someNumber) Console.WriteLine($"Great job! The answer was {someNumber}.");
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
