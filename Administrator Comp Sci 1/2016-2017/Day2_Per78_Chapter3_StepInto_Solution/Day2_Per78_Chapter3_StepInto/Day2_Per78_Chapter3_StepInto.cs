using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter3_StepInto
{
    class Day2_Per78_Chapter3_StepInto
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            int radius = 6;
            double volumeSphere;

            volumeSphere = ((double)4 / 3) * Math.PI * radius * radius * radius;
            //Need to cast 4/3 so computer doesn't think it = 1

            Console.WriteLine("If the radius is {0} inches, then the"
                + " volume is {1:N3} cubic inches.",radius,volumeSphere);
            //{1:N3} Formats the value of the variable "volumeSphere" 
            //to three decimal places

            //If numbers are off, try Step Into function

            #region This is where we end the program
            //End any program
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\nPlease hit the ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ENTER ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" key to end program . . . ");
            Console.Read();
            #endregion
        }
    }
}
