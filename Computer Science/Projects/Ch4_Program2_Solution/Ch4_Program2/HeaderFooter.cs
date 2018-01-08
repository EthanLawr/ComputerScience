using Clog = System.Console;
using SW = System.Threading.Thread;
using DT = System.DateTime;
namespace Ch4_Program2.ChapterFour
{
    class HeaderFooter : Colors
    {
        
        public static void Header()
        {
            CyanFont(); //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DT.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create a program that uses methods "
                + "variables";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************\n\n";
            //Ends the header
            Clog.WriteLine(name); //Writes my name
            SW.Sleep(50); //Sustains my name
            Clog.Clear(); //Clears my name
            SW.Sleep(70); //"Loading" time
            Clog.WriteLine(name + date);
            //Writes my name and the date w/ the time
            SW.Sleep(70); //Sustains my name and the date w/ the time
            Clog.Clear(); //Clears my name and the date w/ the time
            SW.Sleep(90); //"Loading" time
            Clog.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            SW.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Clog.Clear(); //Clears my name, the date w/ the time, and the period
            SW.Sleep(110); //"Loading" Time
            Clog.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            SW.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Clog.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            SW.Sleep(130);
            Clog.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            SW.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Clog.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            SW.Sleep(150); //"Loading" Time
            Clog.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            SW.Sleep(150); //"Loading" Time
            Clog.ResetColor(); //Resets the color for non header lines
        }
        public static void Footer()
        {
            CyanFont(); //Color Set to Cyan
            Clog.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Clog.ResetColor(); //Color Reset of the text
            Clog.ReadLine();
        }
        public static void SecondHeader()
        {
            CyanFont(); //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DT.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create a program that uses methods "
                + "variables";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************\n\n";
            //Ends the header
            Clog.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            SW.Sleep(150); //"Loading" Time
            Clog.ResetColor(); //Resets the color for non header lines
        }
    }
}
