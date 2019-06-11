using System;
using System.Threading;
using System.Globalization;

namespace Chapter2_Calender
{
    class Calenders : TaskShortener
    {
        private static int[,] calendar = new int[6, 7]; // Global variable that will change as time goes
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
                    int day = AskUserForInt("the first day of the month (1 - 7)?");
                    while (day > 7)
                    {
                        day = AskUserForInt("the first day of the month (1 - 7)?") - 1;
                    }
                    int month = AskUserForInt("the month? (January = 1):");
                    DaysAndMonth(month);
                    CalendarData(day - 1, month);
                    MakeTheCalendar();
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

        private static void DaysAndMonth(int x)
        {
            Console.Write("\n\n");
            //gives you the month and year at the top of the calendar
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x)); // Translates the number of the month to the month name without a switch
            Console.WriteLine("Sun\tMon\tTue\tWed\tThr\tFri\tSat"); // Lists the days
        }
        private static void CalendarData(int x, int y)
        {
            int days = DateTime.DaysInMonth(2003, y), currentDay = 1; // Gets the day and days of the month
            var dayOfWeek = x-1;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && y > j) calendar[i, j] = 0;
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek;
                        currentDay++;
                    }
                }
            }
        }
        private static void MakeTheCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {

                        if (calendar[i, j] < 10) Console.Write("  " + calendar[i, j] + "\t"); // 1 - 9 days (spacing)
                        else Console.Write(" " + calendar[i, j] + "\t"); // 10+ days (spacing)
                    }
                    else Console.Write("\t"); //Spacing of numbers (first week)
                }
                Console.WriteLine(""); // Spacing to get to week by week enters
            }
        }
    }
}
