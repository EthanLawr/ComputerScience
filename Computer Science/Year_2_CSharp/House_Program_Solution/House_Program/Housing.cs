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
                    Console.WriteLine(repeat('#', 6)+ repeat(' ', 38));
                    Console.WriteLine(repeat('#', 4) + repeat(' ', 11) + "# # #" + repeat(' ', 24));
                    Console.WriteLine(repeat('#', 3) + repeat(' ', 13) + "# #" + repeat(' ', 25));
                    Console.WriteLine("#" + repeat(' ', 16) + "#" + repeat(' ', 26));
                    Console.WriteLine(repeat(' ', 17)+ "#" + repeat(' ', 26));
                    skyHouseFont();
                    Console.WriteLine(repeat(' ', 17) + "H" + repeat(' ', 26));
                    Console.WriteLine(repeat(' ', 15) + "_H" + repeat('_', 23) + repeat(' ', 4));
                    GreenFont();
                    Console.Write(repeat(' ', 5) + repeat('@', 3) + repeat(' ', 6));
                    redDoor();
                    Console.Write("/" + repeat(' ', 25) + "/1");
                    GreenFont();
                    Console.Write("  \n    @@@@@    ");
                    redDoor();
                    Console.Write("/" + repeat(' ', 25) + "/ l");
                    GreenFont();
                    Console.Write("  \n    @@@@@   ");
                    WhiteFont();
                    Console.Write("l" + repeat('~', 25) + "l~~l");
                    GreenFont();
                    Console.Write("  \n     @@@    ");
                    WhiteFont();
                    Console.Write("l" + repeat(' ', 25) + "l  l");
                    skyHouseFont();
                    Console.Write("  \n" + repeat(' ', 6) + "l" + repeat(' ', 5));
                    WhiteFont();
                    Console.Write("l" + repeat(' ', 25) + "l  l");
                    skyHouseFont();
                    Console.Write("  \n" + repeat(' ', 6) + "l" + repeat(' ', 5));
                    WhiteFont();
                    Console.Write("l" + repeat(' ', 13) + "__" + repeat(' ', 10) + "l  l");
                    skyHouseFont();
                    Console.Write("  \n" + repeat(' ', 6) + "l" + repeat(' ', 5));
                    WhiteFont();
                    Console.Write("l             ");
                    redDoor();
                    Console.Write("l  l");
                    WhiteFont();
                    Console.Write("        l  l");
                    skyHouseFont();
                    Console.Write("  \n" + repeat(' ', 6) + "l" + repeat(' ', 5));
                    WhiteFont();
                    Console.Write("l             ");
                    redDoor();
                    Console.Write("l .l");
                    WhiteFont();
                    Console.Write("        l _l");
                    skyHouseFont();
                    Console.Write("  \n" + repeat(' ', 6) + "l" + repeat(' ', 5));
                    WhiteFont();
                    Console.Write("l_____________");
                    redDoor();
                    Console.Write("L__L");
                    WhiteFont();
                    Console.Write("________l/");
                    GreenFont();
                    Console.Write("    ");

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
        private static string repeat(char x, int n)
        {
            return new String(x, n);
        }
    }
}
