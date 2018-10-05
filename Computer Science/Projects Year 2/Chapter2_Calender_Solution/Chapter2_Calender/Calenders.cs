using System;
using System.Threading;
using System.Globalization;

namespace Chapter2_Calender
{
    class Calenders : TaskShortener
    {
        private static int[,] calendar = new int[6, 7];
        private static DateTime date;
        static void Main(string[] args)
        {
            ConsoleChangeSize();
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
                    int year = AskUserForInt("the year?");
                    int month = AskUserForInt("the month? (January = 1):");

                    date = new DateTime(year, month, 1);//gives you a datetime object for the first day of the month
                    DrawHeader(year, month);
                    FillCalendar(year, month);
                    DrawCalendar();
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

        private static void DrawHeader(int x, int y)
        {
            Console.Write("\n\n");
            //gives you the month and year at the top of the calendar
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(y) + " " + x); // Translates the number of the month to the month name without a switch
            Console.WriteLine("Mo Tu We Th Fr Sa Su"); // Lists the days
        }

        private static void FillCalendar(int x, int y)
        {
            int days = DateTime.DaysInMonth(x, y), currentDay = 1; // Gets the day and days of the month
            var dayOfWeek = (int)date.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && y > j) calendar[i, j] = 0;
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        private static void DrawCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10) Console.Write(" " + calendar[i, j] + " "); // 10+ days (spacing)
                        else Console.Write(calendar[i, j] + " "); // First 9 days (spacing)
                    }
                    else Console.Write("   "); //Spacing of numbers (first week)
                }
                Console.WriteLine(""); // Spacing to get to the next week's line
            }
        }
    }
}
