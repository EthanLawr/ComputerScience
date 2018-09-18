using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace House_Program
{
    class Housing : TaskShortener
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
                    skyFont();
                    Console.WriteLine("######                                      ");
                    Console.WriteLine("####           # # #                        ");
                    Console.WriteLine("###             # #                         ");
                    Console.WriteLine("#                #                          ");
                    Console.WriteLine("                 #                          ");
                    skyHouseFont();
                    Console.WriteLine("                 H                          ");
                    Console.WriteLine("               _H________________________   ");
                    GreenFont();
                    Console.Write("     @@@      ");
                    WhiteFont();
                    Console.WriteLine("/                         /1  ");
                    GreenFont();
                    Console.Write("    @@@@@    ");
                    WhiteFont();
                    Console.WriteLine("/                         / l  ");
                    GreenFont();
                    Console.Write("    @@@@@   ");
                    WhiteFont();
                    Console.WriteLine("l~~~~~~~~~~~~~~~~~~~~~~~~~l~~l  ");
                    GreenFont();
                    Console.Write("     @@@    ");
                    WhiteFont();
                    Console.WriteLine("l                         l  l  ");
                    skyHouseFont();
                    Console.Write("      l     ");
                    WhiteFont();
                    Console.WriteLine("l                         l  l  ");
                    skyHouseFont();
                    Console.Write("      l     ");
                    WhiteFont();
                    Console.WriteLine("l              __         l  l  ");
                    skyHouseFont();
                    Console.Write("      l     ");
                    WhiteFont();
                    Console.WriteLine("l             l  l        l  l  ");
                    skyHouseFont();
                    Console.Write("      l     ");
                    WhiteFont();
                    Console.WriteLine("l             l .l        l _l  ");
                    skyHouseFont();
                    Console.Write("      l     ");
                    WhiteFont();
                    Console.Write("l_____________L__L________l/    ");

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
