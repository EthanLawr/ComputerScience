using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da1_Per3_AmericanFlag
{
    class Da1_Per3_AmericanFlag
    {
        static void Main(string[] args)
        {
            #region Header
            //Header
            Console.SetWindowSize(80, 60);//makes the black
            //console window larger
            Console.Title = "American Flag";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: AmericanFlag Program\n");
            // \n advances to a new line
            //code snippet cw-tab-tab
            Console.Write("Date: 10/2/18");
            Console.WriteLine("\t\tAuthor: Mr. Lynch\n");
            // \t tab over twice in this case
            Console.WriteLine("Purpose: is to creat an American"
                + " Flag and practice with color\n");
            Console.WriteLine("************************************"
                + "************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Console.WriteLine("\a\a\a\a\a");// \a give a beep sound
            Console.Beep(); // This is the same as \a
            Console.Beep(5000, 1000);

            //Actual Code
            //First Stripe (blue with stars and red stripe)
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            //2nd Stripe (blue with stars and white stripe)
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" * * * * * * * * * ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t");

            //Fifth Stripe (blue with stars and red stripe)
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("* * * * * * * * * *");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t");

            //First all White stripe
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");
            
            //First all Red stripe
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t");
      
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t");

            #region Footer
            //End of program (Footer)
            Console.WriteLine("\n\n\n\nPlease hit ENTER to "
                + "end program");
            Console.Read();
            #endregion


        }
    }
}
