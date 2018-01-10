using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Chapter4Practice
{
    class Day1_Per45_Chapter4Practice
    {
        //Put methods here
        public static void Header()
        {//"void" is a glorified Display method
            //Does not use any input from the outside.
            Console.SetWindowSize(80, 60);
            Console.WriteLine("Author: Mr Lynch\t\tTitle: Chapter 4 Practice");
            Console.WriteLine("\nDate: 12/21/17");
            Console.WriteLine("\nPurpose: To introduce basic methods");
            Console.WriteLine("\n********************************************************\n");
        }

        static void Main(string[] args)//This is my Main();
        {
            //Everything starts and ends in the Main();
            //GOAL: To have as little lines of code in Main();

            //Call the method
            Day1_Per45_Chapter4Practice.Header();
            Header(); //Called the Header(); twice

            CommonTasks.HeaderB("1/8/18");//Using a second class

            HitAnyKeyToContinue("Knucklehead");//Called the first time
            HitAnyKeyToContinue("goofball");
            HitAnyKeyToContinue("goober");//Invoked this method three times

            //Console.WriteLine(input);

            int testScore1 = AskUserForInt("your first exam score");
            int testScore2 = AskUserForInt("your 2nd score");
            //Called twice

            TestAverageMethod(testScore1, testScore2);//send as many
            //arguments as you want into a method

            #region Stuff before BReak
            //How do we get user input?
            string dogName = AskUserForString("dog's name");
            string firstName = AskUserForString("first name");
            string homeTown = AskUserForString("home town");
            //Called the AskUserForString method three different times

            Console.WriteLine("Your first name is {0}, you have a dog named"
                + " {1}\n and you live in {2}, PA",firstName, dogName, homeTown);

            //Area of house
            double lengthOfHouse = AskUserForDouble("length of room");
            double widthOfHouse = AskUserForDouble("width in the room");

            double area = lengthOfHouse * widthOfHouse;

            Console.WriteLine("If your length is {0} ft and you width is {1} ft"
                + "\nthen your area is {2:N2} square feet",lengthOfHouse, widthOfHouse, area);
            #endregion

            Footer();
        }

        public static void TestAverageMethod(int a, int b)//sends two ints
        {
            double average = ((double)a + b) / 2;//cast int to a double
            Console.WriteLine("If the scores are {0} and {1}, then"
                + " the average is {2}",a,b,average);//a and b are local
            //to this specific TestAverageMethod
        }

        public static int AskUserForInt(string x)
        {
            Console.WriteLine("Please enter . . . {0}",x);
            string input = Console.ReadLine();//"input" is only
            //local to THIS specific method
            int inputInt = Convert.ToInt32(input);
            return inputInt;

        }

        public static void HitAnyKeyToContinue(string x)
        {
            Console.WriteLine("\n\nPlease hit ANY key to continue . . .");
            Console.WriteLine("you are a {0}",x);//placeholder from Main();
            Console.ReadKey();
        }

        public static double AskUserForDouble(string x)
        {
            Console.WriteLine("Please enter the . . . {0}",x);
            string userInput = Console.ReadLine();//ReadLine(); only
            //accepts a string
            double userDouble = Convert.ToDouble(userInput);
            //Need to convert the string to a double in order to return
            //a double value back to the Main();
            return userDouble;
        }

        public static string AskUserForString(string x)
        {
            //"string x" is just a placeholder for whatever string is 
            //overloaded in the Main();
            Console.WriteLine("\nPlease enter your . . . {0}",x);
            string userInput = Console.ReadLine();
            //ReadLine(); only accepts a string from the user
            return userInput;

        }

        //Put methods here
        public static void Footer()
        {
            Console.WriteLine("\n\n\nPlease hit ANY key to end program . .  .");
            Console.ReadKey();
        }
    }
}
