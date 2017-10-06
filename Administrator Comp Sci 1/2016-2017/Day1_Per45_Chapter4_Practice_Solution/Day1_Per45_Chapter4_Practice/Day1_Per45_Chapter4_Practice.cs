using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Chapter4_Practice
{
    class Day1_Per45_Chapter4_Practice
    {
        public static void Header()
        {
            //void method because it doesn't return anything
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

        }
        static void Main(string[] args)
        {
            Day1_Per45_Chapter4_Practice.Header();//Call the header method
            Header();

            //method that returns a string
            string favColor = Day1_Per45_Chapter4_Practice.AskUserForString("your favorite color");
            string dogsName, elemSchool, fBallTeam;

            dogsName = AskUserForString("your dog's name");
            elemSchool = AskUserForString("your elementary school");
            fBallTeam = AskUserForString("favorite football team");

            //Putting some together
            Console.WriteLine("Your dog is named {0} and your favorite"
                + " football team is {1}", dogsName, fBallTeam);

            //return a value int
            int ageOfStudent, favNumber, houseNumber;
            favNumber = AskUserForInt("your favorit number");
            houseNumber = AskUserForInt("your house number");

            Multiply(favNumber, houseNumber);


            EndProgram();
        }
        public static void Multiply(int mainFavNum, int mainHouseNum)
        {
            Console.WriteLine("Your favorite number is {0}", mainFavNum);
            Console.WriteLine("Your house number is {0}",mainHouseNum);
            Console.WriteLine("The product of these two is {0}",mainFavNum*mainHouseNum);
        }

        public static int AskUserForInt(string fromMain)
        {
            Console.WriteLine("Please enter . . . {0}",fromMain);
            string userInput = Console.ReadLine();//Only stores a string
            int userInt = Convert.ToInt32(userInput);
            return userInt; //This returns an int back to Main Method
        }

        public static string AskUserForString(string fromMain)
        {
            Console.WriteLine("Please enter . . . {0}",fromMain);
            string userInput = Console.ReadLine();
            return userInput;

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
