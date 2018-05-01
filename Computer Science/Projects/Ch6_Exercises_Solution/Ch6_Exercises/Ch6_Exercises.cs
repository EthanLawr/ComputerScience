using System;
using System.Threading;

namespace Ch6_Exercises
{
    class Ch6_Exercises : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 5; i++)                                  //Error looping
            {
                try
                {


                    Header();
                    #region Exercise One
                    for (int j = 10; j > -1;)
                    {
                        Console.WriteLine(j);
                        j--;
                    }
                    #endregion
                    Loading();
                    SecondHeader();
                    #region Exercise Two
                    int h = 30;
                    while (h > -1)
                    {
                        Console.WriteLine(h);
                        h -= 2;
                    }
                    #endregion

                    Footer();
                    break;
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    RedFont(); //Red!
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
