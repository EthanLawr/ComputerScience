using System;
using System.Linq;
using System.Threading;

namespace Ch6_Program3
{
    class AverageScores : TaskShortener
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
                    #region Important Code
                    double scoreOne = AskUserForDouble("one grade"), //Asks for the grades
                       scoreTwo = AskUserForDouble("a second grade"),
                       scoreThree = AskUserForDouble("a third grade"),
                       scoreFour = AskUserForDouble("a fourth grade"),
                       scoreFive = AskUserForDouble("a fifth grade"),
                       averageGrade = Calculations(scoreOne, scoreTwo, scoreThree,
                        scoreFour, scoreFive); //Calculate those grades
                    SuperCheckOne(averageGrade);
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
        internal static double Calculations(double v, double w, double x, double y, double z)
        {
            double totalSum = v + w + x + y + z, //Sum
             averageGrade = totalSum / 5; //Average
            return averageGrade;
        }

        internal static void SuperCheckTwo(double x)
        {
            GreenFont();
            #region Checks
            if (x <= 100 && x >= 89.6) //Checks for A scores
                Console.Write("You have an A!");
            else if (x <= 89.5 && x >= 79.6) //Checks for B scores
                Console.Write("You have a B!");
            else if (x <= 79.5 && x >= 69.6) //Checks for C scores
                Console.Write("You have a C!");
            else if (x <= 69.5 && x >= 59.6) //Checks for D scores
                Console.Write("You have a D!");
            else if (x <= 59.5 && x >= 0) //Checks for F scores
                Console.Write("You have an F!");
            else //You did a dumb...
                Console.Write("Please enter a valid score!");
            #endregion

        }

        internal static void SuperCheckOne(double x)
        {
            GreenFont();

            #region Checks
            if (Enumerable.Range(90, 100).Contains((int)x)) //Checks for A scores
                Console.Write("You have an A!");
            else if (Enumerable.Range(80, 89).Contains((int)x)) //Checks for B scores
                Console.Write("You have a B!");
            else if (Enumerable.Range(70, 79).Contains((int)x)) //Checks for C scores
                Console.Write("You have a C!");
            else if (Enumerable.Range(60, 69).Contains((int)x)) //Checks for D scores
                Console.Write("You have a D!");
            else if (Enumerable.Range(0, 59).Contains((int)x)) //Checks for F scores
                Console.Write("You have an F!");
            else //You did a dumb...
                Console.Write("Please enter a valid score!");
            #endregion

        }
    }
}