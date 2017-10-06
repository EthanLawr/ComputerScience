using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_RefAndOutPractice
{
    class Day2_Per78_RefAndOutPractice
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

            //Old stuff
            string country;//just declared as a string (use out parameter)
            double gPA = 3.6;//declared as double and initialized (use ref parameter)
            Console.WriteLine("original gpa is {0}",gPA);
            
            // using 'ref' and 'out' parameters
            string worstStudent = AskUserForString("worst student", out country, ref gPA);
            //allows us to return or change three different variables in same method!!!
            //'worstStudent' and 'country' and 'gPA' will all be changed or given values
            //from the AskUserForString() method!

            Display(worstStudent, country, gPA);

            EndProgram();
        }
        public static void Display(string z, string x, double y)
        {
            Console.WriteLine("Original worst student = {0}",z);
            Console.WriteLine("favorite country = {0}",x);
            Console.WriteLine("your GPA is {0}",y);
        }

        public static string AskUserForString(string a, out string b, ref double c)
        {
            Console.WriteLine("Please enter your {0} name",a);
            string input = Console.ReadLine();
            b = "USA";//'b' is just a placeholder for 'country' in Main()
            //and uses 'out' parameter
            Console.WriteLine("Hack in the GPA you want");
            c = Convert.ToDouble(Console.ReadLine());//converts string to double in one step
            //'c' is a placeholder for 'gPA' and uses 'ref' parameter because 
            //'gPA' was already initialized in Main()
            return input;//returns the first input back to Main()
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
