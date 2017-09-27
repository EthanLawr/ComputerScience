//Program header
//This program is meant to practice with C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OurFirstProgramDay2
{
    class OurFirstProgramDay2
    {
        static void Main(string[] args)
        {
            #region Conosle Header\
            Console.Title = "First Program";
            Console.SetWindowSize(80, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: First Program\t\tAuthor: Mr. Lynch");
            Console.WriteLine("\nDate: 9/28/2015");
            Console.WriteLine("\nThis program is mean to . . .");
            Console.WriteLine("\n****************************************"
                + "***************************************\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Console.WriteLine("This is my weight {0}",);
            Console.WriteLine("Dan\n");
            Console.WriteLine("Lynch");
            Console.WriteLine("Math\n\n\n");

            int number1 = 7;
        
            if (number1 >= 3 && number1 == 7)
            {
                Console.WriteLine("Our original Value is {0:C2}",number1--);
                Console.WriteLine("Our new value is {0:F5}",--number1);
            }
            

            decimal myDecimal = 3.45679899864553765437654376543M;
            Console.Write("\n\n\n\nHello World . . . \a\a");
            Console.Write("Hey\n\n\n\n\n"); // \n create a "new line"
                                            // \n is one example of an escape sequence
            Console.WriteLine(@"
______                     ______  
___ / _____  _________________ / _
__ / __ / / / _  __ \  ___ / _  __ \
_ / ___ / _ / / _ / / / / __ _ / / /
/ _____ /\__, / / _ / / _ /\___ / / _ / / _ /
      / ____ / ");

            #region End Program
            //Wait for user to acknowledge results
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\nPlease hit ENTER to end program . . .");
            Console.Read(); //You must hit ENTER to close the program
            #endregion
            
            
        }
    }
}
