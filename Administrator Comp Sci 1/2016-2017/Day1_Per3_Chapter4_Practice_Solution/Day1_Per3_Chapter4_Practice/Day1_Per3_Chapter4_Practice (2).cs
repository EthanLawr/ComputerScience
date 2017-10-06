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
            Console.WriteLine("\nTitle: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
           
        }
        
        //Main Method Here!!!!
        static void Main(string[] args)  //inplied 'private'
        {
            AnyKeyToContinue();
            AnyKeyToContinue();
            AnyKeyToContinue();

            int integerA = AskUserForInt("A");
            int integerB = AskUserForInt("B");
            int integerC = AskUserForInt("C");

            QuadFormula(integerA, integerB, integerC);

            #region previous stuff
            Day1_Per3_Chapter4_Practice.Header();  //redundant
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
            #endregion
        }
        public static void QuadFormula(int a, int b, int c)
        {
            //find roots
            double root1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double root2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            //display results
            Console.WriteLine("if A = {0}",a);//a only exits in THIS method
            Console.WriteLine("if B = {0}",b);//b  "             "
            Console.WriteLine("if C = {0}",c);//c     "              "
            Console.WriteLine("Then roots are {0} and {1}",root1,root2);
            //no return statment needed because this is a void method
        }

        //method that is not void and returns an int
        public static int AskUserForInt(string x)
        {
            Console.Write("\n\nPlease enter the {0} value\t\t", x);
            string inputString = Console.ReadLine();//always a string
            int inputInt = Convert.ToInt32(inputString);//change to int
            return inputInt;
        }

        //New AnyKey Method (void)
        public static void AnyKeyToContinue()
        {
            Console.Write("\n\nPlease hit ANY key to continue. . .\t\t");
            Console.ReadKey();
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

        public static string AskUserForString(string x)
        {
            Console.WriteLine("Please enter . . . {0}", x);
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
