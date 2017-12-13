using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch3_Program54a
{
    class MilesPerGallonAvg
    {
        static void Main(string[] args)
        {
            ConsoleSize();
            Header();
            
            #region Variables
            int vwGallons = 9;
            //Declared Gallons
            int vwMiles = 286;
            //Declared Miles
            double vwMpg = ((double)vwMiles / vwGallons);
            //Formula to find Miles per Gallon

            int firebirdGallons = 40;
            //Declared Gallons
            int firebirdMiles = 412;
            //Declared Miles
            double firebirdMpg = ((double)firebirdMiles / firebirdGallons);
            //Formula to find Miles per Gallon

            int subaruGallons = 18;
            //Declared Gallons
            int subaruMiles = 361;
            //Declared Miles
            double subaruMpg = ((double)subaruMiles / subaruGallons);
            //Formula to find Miles per Gallon

            int cutlassGallons = 11;
            //Declared Gallons
            int cutlassMiles = 161;
            //Declared Miles
            double cutlassMpg = ((double)cutlassMiles / cutlassGallons);
            //Formula to find Miles per Gallon
            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style stuff or something

            Console.WriteLine("Vehicle\t\t\tMiles\t\tGallons\t\tMiles per "
                + "Gallon (Average)\n");
            Console.WriteLine("-------\t\t\t-----\t\t-------\t\t----------"
                + "----------------\n");
            //Collumn titles

            Console.WriteLine("1970 VW Bug\t\t{0}\t\t{1}\t\t{2:N2}", vwMiles,
               vwGallons, vwMpg);
            //1970 VW Bug

            Console.WriteLine("1979 Firebird\t\t{0}\t\t{1}\t\t{2:N2}", firebirdMiles,
                firebirdGallons, firebirdMpg);
            //1979 Firebird

            Console.WriteLine("1990 Subaru\t\t{0}\t\t{1}\t\t{2:N2}", subaruMiles,
                subaruGallons, subaruMpg);
            //1990 Subaru

            Console.WriteLine("1975 Cutlass\t\t{0}\t\t{1}\t\t{2:N2}", cutlassMiles,
                cutlassGallons, cutlassMpg);
            //1975 Cutlass

            Footer();

            Console.ReadKey();
        }
        public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To calculate the average miles per "
                + "gallon in each vehicle!";
            //Shows the purpose of the current project
            string endheader = "\n***********************************"
                + "**************************************************"
                + "********************\n\n";
            //Ends the header
            Console.WriteLine(name); //Writes my name
            Thread.Sleep(50); //Sustains my name
            Console.Clear(); //Clears my name
            Thread.Sleep(70); //"Loading" time
            Console.WriteLine(name + date);
            //Writes my name and the date w/ the time
            Thread.Sleep(70); //Sustains my name and the date w/ the time
            Console.Clear(); //Clears my name and the date w/ the time
            Thread.Sleep(90); //"Loading" time
            Console.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Console.Clear(); //Clears my name, the date w/ the time, and the period
            Thread.Sleep(110); //"Loading" Time
            Console.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            Thread.Sleep(130);
            Console.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Console.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(150); //"Loading" Time
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
        }
        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
        }
        public static void ConsoleSize()
        {
            int origWidth = Console.WindowWidth, origHeight = Console.WindowHeight;
            Console.SetWindowSize(Console.WindowWidth + 25, Console.WindowHeight);
        }
    }
}