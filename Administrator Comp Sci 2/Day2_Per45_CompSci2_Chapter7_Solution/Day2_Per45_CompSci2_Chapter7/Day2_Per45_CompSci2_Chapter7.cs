using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per45_CompSci2_Chapter7
{
    class Day2_Per45_CompSci2_Chapter7
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

            //Arrays
            double[] GradePointAverage = { 4.3, 2.6, 4.8, 1.6 };
            Console.WriteLine("The 2nd element is {0}",GradePointAverage[1]);
            foreach (double gPA in GradePointAverage)
            {
                Console.WriteLine("element {0}",gPA);
            }
            Console.WriteLine("\n\n");
            Array.Sort(GradePointAverage);
            //Sorted in order
            foreach (double gPA in GradePointAverage)
            {
                Console.WriteLine("element {0}", gPA);
            }

            //List
            List<string> LastName = new List<string> {"Byle", "Lynch", "Joseph", "Nolter", "Vinokur" };
            Console.WriteLine("The 3rd name is {0}", LastName[2]);
            //Add names
            LastName.Add("Donnelly");

            foreach (string name in LastName)
            {
                //names in order
                Console.WriteLine("{0}",name);
            }

            //Sort in alphabetical order
            LastName.Sort();
            Console.WriteLine("\n\n");
            foreach (string name in LastName)
            {
                //names in order
                Console.WriteLine("{0}", name);
            }


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
