using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cents_Program
{
    class Cents_And_Dust : TaskShortener
    {
        static void Main(string[] args)
        {
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
                    int Cents = AskUserForInt("Please enter a value in cents (Under 100)"); // Gets the values
                    Console.WriteLine("You entered {0}", Cents); // Shows what you entered
                    TotalChangeCalc(Cents); // Shows the results
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
        public static void TotalChangeCalc(int x)
        {
            //Declaring what each is worth
            #region Stated Values
            var coinTypes = new[]
            {
                new { type = "One Dollar Bill(s)",    coinWorth = 100 },  //1$ Bills
                new { type = "Quarter(s)",            coinWorth = 25 },  //Quarters
                new { type = "Dime(s)",               coinWorth = 10 },  //Dimes
                new { type = "Nickel(s)",             coinWorth = 5 },  //Nickels
                new { type = "Pennie(s)",             coinWorth = 1 }   //Pennies
            };
            #endregion

            #region Console Display
            Console.Write("There is/are ");
            foreach (var coin in coinTypes)
            {
                //Reusing X over and over and getting remainders until the answer is acheived
                int countedChange = (int)(x / coin.coinWorth);
                x -= countedChange * coin.coinWorth;
                Console.ResetColor();
                GreenFont();
                TaskShortener.TypeLineSuperFast($"{countedChange} {coin.type} ");

                //Displays the stuff
            }
            YellowFont();
            Console.Write("in total.");
            #endregion
        }
    }
}
