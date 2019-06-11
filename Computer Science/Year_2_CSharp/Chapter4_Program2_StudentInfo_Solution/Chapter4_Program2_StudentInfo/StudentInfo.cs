using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter4_Program2_StudentInfo
{
    class StudentInfo : TaskShortener
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
            new StudentInformation();
            #endregion
            Footer();
        }
    }
}
