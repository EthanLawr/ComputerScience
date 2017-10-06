using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_StepInto
{
    class Day1_Per45_StepInto
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

            //Step into for math heavy calculations
            int radius = 2;
            const double PI = 3.1415926;
            double coefficient = (double)4 / 3;//Cast

            //Volume of Sphere = (4/3)*PI*radius^3
            Console.WriteLine(Math.PI);

            //double volumeSphere = coefficient * PI * radius ^ 3;
            double volumeSphere = coefficient * PI * radius 
                * radius * radius;

            Console.WriteLine("If the radius is {0} inches, then the"
                + " volume is {1:N3} cubic inches.", radius, volumeSphere);//formatting

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
