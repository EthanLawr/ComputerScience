using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_RefAndOutPractice
{
    class Day1_Per3_RefAndOutPractice
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

            //Working with ref and out
            string nickName = "Dude";//need "ref" because initialized
            string gatoradeFlavor;//need "out" because just declared, not initialized
            Console.WriteLine("initially nickname is {0}",nickName);

            double gPA = AskForDouble("GPA",ref nickName, out gatoradeFlavor);
            Console.WriteLine("you typed GPA = {0}",gPA);
            Console.WriteLine("After using 'ref' your nickname is {0}",nickName);
            Console.WriteLine("After using 'out' your favorite flavor = {0}",gatoradeFlavor);


            EndProgram();
        }
        public static double AskForDouble(string z, ref string nName, out string gFlav)
        {
            Console.WriteLine("Please enter your {0}",z);
            nName = "Knucklehead";
            string input = Console.ReadLine();
            double inputDouble = Convert.ToDouble(input);
            Console.WriteLine("Enter favorite gatorade flavor");
            gFlav = Console.ReadLine();
            //gFlav = "cherry";
            return inputDouble;

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
