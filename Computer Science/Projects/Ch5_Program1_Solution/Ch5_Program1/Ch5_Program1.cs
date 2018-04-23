using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program1
{
    class Ch5_Program1 : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(TetrisSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 100; i++)                                  //Error looping
            {
                try
                {


                    Header();

                    #region Important Code
                    double equality = AskUserForDouble("a positive number"), //Asks for a double
                     equalityTwo = AskUserForDouble("a second number"); //Asks a second time

                    Loading();

                    SuperCheck(equality, equalityTwo); //Checks the numbers
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

        internal static void SuperCheck(double x, double y)
        {
            GreenFont();

            #region Negative/Zero Checks
            if (x <= 0 && y <= 0) //Checks if they are invalid
                Console.WriteLine("Please enter a value higher than 0 for both numbers.");
            else if (x <= 0) //Checks if x is invalid
                Console.WriteLine("Please enter a value higher than 0 for your first number.");
            else if (y <= 0) //Checks if y is invalid
                Console.WriteLine("Please enter a value higher than 0 for your second number.");
            #endregion

            #region Greater than, less than, or equal check
            else if (x == y) //Checks if they are equal
                Console.WriteLine("Please enter two different values. Knucklehead.");
            else if (x > y) //Checks if x is greater
                Console.WriteLine("The first number ({0}) is bigger than the second"
                    + " number ({1})", x, y);
            else if (x < y) //Checks if y is greater
                Console.WriteLine("The second number ({0}) is bigger than the first"
                    + " number ({1})", y, x);
            #endregion

        }
    }
}
