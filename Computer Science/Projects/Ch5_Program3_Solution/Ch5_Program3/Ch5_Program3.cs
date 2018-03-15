﻿using System;
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
            for (int i = 0; i < 2; i++)                                  //Error looping
            {
                try
                {
                    #region Threads
                    Thread tid1 = new Thread(new ThreadStart(TetrisSong));
                    tid1.Start(); //Runs a song while you run the program.
                    #endregion

                    Header();

                    #region Important Code
                    double equality = AskUserForDouble("a positive number"); //Asks for a double
                    double equalityTwo = AskUserForDouble("a second number"); //Asks a second time
                    SuperCheck(equality, equalityTwo); //Checks the numbers
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

        internal static void SuperCheck(double x, double y)
        {
            Loading();
            GreenFont();

            #region Negative/Zero Checks
            if (x <= 0 & y <= 0)
            {
                Console.WriteLine("Please enter a value higher than 0 for both numbers.");
            }
            else if (x <= 0)
            {
                Console.WriteLine("Please enter a value higher than 0 for your first number.");
            }
            else if (y <= 0)
            {
                Console.WriteLine("Please enter a value higher than 0 for your second number.");
            }
            #endregion

            #region Greater than, less than, or equal check
            else if (x == y)
            {
                Console.WriteLine("Please enter two different values. Knucklehead.");
            }
            else if (x > y)
            {
                Console.WriteLine("{0} is bigger than {1}", x, y);
            }
            else if (x < y)
            {
                Console.WriteLine("{0} is bigger than {1}", x, y);
            }
            #endregion

        }
    }
}
