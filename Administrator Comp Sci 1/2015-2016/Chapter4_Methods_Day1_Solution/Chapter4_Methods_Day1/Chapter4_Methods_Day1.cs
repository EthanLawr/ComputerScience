using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Methods_Day1
{
    class Chapter4_Methods_Day1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This is my header");
            Console.WriteLine("\n\n******************************");
            Console.WriteLine("\n\n\nThis is a method");
            HitAnyKeyToContinue();
            string firstName = AskUserForInput("your first name");
            HitAnyKeyToContinue();
            string lastName = AskUserForInput("your last name");
            HitAnyKeyToContinue();
            //Console.WriteLine("\n\n\nYour full name is {0} {1}",firstName,lastName);
            Chapter4_Methods_Day1.HitAnyKeyToContinue();

            int roomLength = AskUserForInputInt("length of room");
            int widthOfRoom = AskUserForInputInt("width of room");
            Console.WriteLine("The area of your room is {0} ft^2",roomLength*widthOfRoom);

            //This is very LAZY
            Console.WriteLine("Please enter you elementary school name");
            string elementarySchool = Console.ReadLine();
            Console.WriteLine("Your elementary school is {0}",elementarySchool);

            DisplayResults(firstName, lastName, roomLength, widthOfRoom, elementarySchool);

            Console.Read();
        }
        public static void DisplayResults(string x, string y, int z, int a, string b)
        {
            Console.WriteLine("\n\nWe're in the method");
            Console.WriteLine("Your full name is {0} {1}",x,y);
            Console.WriteLine("The Area of your room is {0} sq ft.",z*a);
            Console.WriteLine("You went to {0} elementary school",b);
        }


        //This returns an int
        public static int AskUserForInputInt(string x)
        {
            Console.WriteLine("\nPlease enter your . . . {0}", x);
            string theirInput = Console.ReadLine();
            int theirInt = Convert.ToInt32(theirInput);
            return theirInt;
        }
        //This does not need to return any values (void)
        public static void HitAnyKeyToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nPlease hit Any key to continue . . . ");
            Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("This is my header");
            //Console.WriteLine("\n\n******************************");
            //Console.ForegroundColor = ConsoleColor.White;
        }
        //Returns a string
        public static string AskUserForInput(string x)
        {
            Console.Write("\n\nPlease enter ... {0}:\t\t",x);
            string theirInput = Console.ReadLine();
            return theirInput;

        }
    }
}
