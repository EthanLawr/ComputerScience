using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_Chapter4_Practice
{
    class Day1_Per3_Chapter4_Practice
    {
        public static void Header()
        {
            
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
           
        }
        
        //Main Method Here!!!!
        static void Main(string[] args)
        {
            Header();
            Header();
            Header();

            //All Strings
            string dogsName = AskUserForString("your dog's name");
            string elemSchool = AskUserForString("your elementary school's name");
            string firstName = AskUserForString("your first name");
            string className = AskUserForString("what class you are");
            string favSport = AskUserForString("your favorite sport");

            Console.WriteLine("\n\n\nYour name is {0} and your's dog's"
                + " name is {1}",firstName,dogsName);

            //Doubles
            double gradePointAverage = AskUserForDouble("your GPA");
            double lengthOfRoom = AskUserForDouble("the lenght in feet");
            double widthOfRoom = AskUserForDouble("the width in feet");

            //void method to do calculations
            AreaOfRoom(lengthOfRoom, widthOfRoom);

            EndProgram();
        }
        public static void AreaOfRoom(double methodLength, double methodWidth)
        {
            double methodArea = methodLength * methodWidth;
            Console.WriteLine("The area of your room in square feet is {0}", methodArea);
            //void method so doesn't need a "return" statement
        }

        public static double AskUserForDouble(string fromMainMethod)
        {
            Console.WriteLine("Please enter . . . {0}",fromMainMethod);
            string userInput = Console.ReadLine();//store a string
            double userDouble = Convert.ToDouble(userInput);//Changes to double
            return userDouble;//returns a double back to Main Method
            
        }

        public static string AskUserForString(string fromMainMethod)
        {
            Console.WriteLine("Please enter . . . {0}", fromMainMethod);
            string userInput = Console.ReadLine();//ReadLine Always stores a string!
            return userInput; //This returns a string back to Main Method
        }

        public static void EndProgram()
        {
            
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
            
        }
    }
}
