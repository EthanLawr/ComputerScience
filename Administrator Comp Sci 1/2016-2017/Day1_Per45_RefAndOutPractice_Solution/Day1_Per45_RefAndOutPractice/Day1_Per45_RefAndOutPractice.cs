using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_RefAndOutPractice
{
    class Day1_Per45_RefAndOutPractice
    {
        public static void Header()
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
        }
        static void Main(string[] args)
        {
            Header();

            //ref and out parameters
            double gPA = 3.6;//use 'ref' because initialized
            double battingAverage;//use 'out' because just declared
            Console.WriteLine("Intially GPA = {0}",gPA);

            string firstName = AskForString("first name", ref gPA, out battingAverage);
            Console.WriteLine("You typed: {0}",firstName);
            Console.WriteLine("After using 'ref' your GPA = {0}",gPA);
            Console.WriteLine("After using 'out' batting average = {0}",battingAverage);

            EndProgram();
        }
        public static string AskForString(string z, ref double x, out double y)
        {
            Console.WriteLine("Please enter your {0}",z);
            string input = Console.ReadLine();
            x = 4.23;//x overrides the value for 'gPA' in the Main() using 'ref' parameter
            Console.WriteLine("What's the batting average?");
            y = Convert.ToDouble(Console.ReadLine());
            //y assigned a value to 'battingAverage' back in Main() using 'out' paremeter
            return input;// a method only returns ONE variable
        }
        public static void EndProgram()
        {
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
