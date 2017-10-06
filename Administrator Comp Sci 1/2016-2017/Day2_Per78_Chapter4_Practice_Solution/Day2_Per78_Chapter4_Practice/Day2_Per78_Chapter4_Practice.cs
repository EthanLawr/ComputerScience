using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter4_Practice
{
    class Day2_Per78_Chapter4_Practice
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

        public static void HitAnyKeyToContinue()
        {
            Console.Write("\n\nPlease hit any key to continue . . . \t\t");
            Console.ReadKey();
        }

        static void Main(string[] args)//private is assumed
        {
            HitAnyKeyToContinue();
            HitAnyKeyToContinue();
            HitAnyKeyToContinue();

            //Integer inputs
            int integerA = AskUserForInt("A");
            int integerB = AskUserForInt("B");
            int integerC = AskUserForInt("C");

            //Let's do a method where we send 2 things into it

            RootsOfTheQuadraticEquation(integerA, integerB, integerC);
            Console.WriteLine("");

            #region Old Stuff
            //Void method
            Day2_Per78_Chapter4_Practice.Header();
            Header();

            //declare a bunch of strings
            string momName, dadName, favSubject, dogBreed;

            momName = AskUserForString("your mom's name");
            dadName = AskUserForString("your dad's name");
            favSubject = AskUserForString("your favorite subject");

            Console.WriteLine("Your mom is {0} and your"
                + " dad is {1}",momName,dadName);

            //double returning values
            double weightInTenths = AskUserForDouble("your weight");
            double heightInTenths = AskUserForDouble("your height");

            
            Multiply(weightInTenths, heightInTenths);
            //need to call the method from the Main(); 

            EndProgram();
#endregion
        }
        public static void RootsOfTheQuadraticEquation(int a, int b, int c)
        {
            //void method that needs 3 outside variables sent to it!
            double root1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double root2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            Console.WriteLine("if A = {0}",a);
            Console.WriteLine("if B = {0}", b);
            Console.WriteLine("if C = {0}", c);
            Console.WriteLine("then roots are {0} and {1}",root1,root2);
            //no return statement needed because void
        }

        public static int AskUserForInt(string x)//string x is just a placeholder
        {                                       //for the string in the Main{}
            Console.WriteLine("\n\nEnter the {0} integer",x);
            string inputString = Console.ReadLine();//always stores string
            int inputInt = Convert.ToInt32(inputString);//changes string to int
            return inputInt;//need a return statement to send back
            //to Main method
        }

        public static void Multiply(double mainWeight, double mainHeight)
        {
            double product = mainWeight * mainHeight;
            Console.WriteLine("your weight * height is = {0}",product);
        }

        public static double AskUserForDouble(string mainString)
        {
            Console.WriteLine("Please enter . . . {0}",mainString);
            string inputString = Console.ReadLine();
            double inputDouble = Convert.ToDouble(inputString);
            return inputDouble;

        }

        public static string AskUserForString(string mainString)
        {//return a value string
            Console.WriteLine("Please enter . . . {0}",mainString);
            string inputString = Console.ReadLine();//stores a string
            return inputString;//returns the string back to Main();
        }

        public static void EndProgram()
        {
            //#region This is where we end the program
            //No need for regions inside methods

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
            //#endregion
        }
    }
}
