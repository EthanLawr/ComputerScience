using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter4_Program1_SchoolInfo
{
    class SchoolInfo : TaskShortener
    {
        static void Main(string[] args)
        {
            ConsoleChangeSize(1.5, 2.2);
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion

            Header();
            #region Important Code
            SchoolInformation info = new SchoolInformation("Superman West", "2200", ConsoleColor.Red);
            string colorOne = $"{info.SchoolColoring()}";
            Console.WriteLine(info.Name);
            string colorTwo = $"{info.SchoolColoring()}";
            Console.WriteLine($"{info.StudentCount}\n{info.ColorNames}");
            #endregion
            Footer();
        }
    }
}
