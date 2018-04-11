using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ch5_Program5
{
    class Program5 : TaskShortener
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
                    double Purchased = AskUserForDouble("the cost");
                    int Amount = AskUserForInt("how many purchases you made");
                    string Charge = Calculation(Purchased, Amount);
                    //string ChargeTranslation = Translator(Charge);
                    Formatter(Charge, Purchased, Amount);
                    #endregion
                    Footer();
                    break;
                } 
                #region Catch
                catch (FormatException e) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    ErrorFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.\n");
                    Console.WriteLine(e);
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
                    Console.Clear();
                }
                #endregion
            }
        }
        public static string Calculation(double x, int y)
        {
            if (x >= 0 & x <= 250)
            {
                double Charge = 5 * y;
                string ChargeString = Convert.ToString(Charge);
                return ChargeString;
            }
            else if(x >= 250.1 & x <= 500)
            {
                double Charge = 8 * y;
                string ChargeString = Convert.ToString(Charge);
                return ChargeString;
            }
            else if (x >= 500.1 & x <= 1000)
            {
                double Charge = 10 * y;
                string ChargeString = Convert.ToString(Charge);
                return ChargeString;
            }
            else if (x >= 1000.1 & x <= 5000)
            {
                double Charge = 15 * y;
                string ChargeString = Convert.ToString(Charge);
                return ChargeString;
            }
            else if (x >= 5000.1)
            {
                double Charge = 20 * y;
                string ChargeString = Convert.ToString(Charge);
                return ChargeString;
            } else
            {
                return "knucklehead";
            }
        }
        internal static void Formatter(string x, double y, int z)
        {
            if (x == "knucklehead") { }
            int ChargeInt = Convert.ToInt16(x);
            Console.WriteLine("With {0} purchases, at the price of {1:C2}, you will be charged {2:C2}",
                z, y, (double)ChargeInt);
        }
    }
}