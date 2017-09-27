using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Day2_Methods
{
    class Chapter4_Day2_Methods
    {
        static void Main(string[] args)
        {
            #region Old Stuff
            Console.WriteLine("This is how we return strings\n\n\n");

            //This is the LAZY way
            Console.WriteLine("Please enter the name of your Elementary School");
            string elementarySchool = Console.ReadLine();
            Console.WriteLine("Your elementary school is {0}",elementarySchool);

            string firstName = AskUserForInput("first name");
            Chapter4_Day2_Methods.HitAnyKeyToContinue();
            string lastName = AskUserForInput("last name");
            HitAnyKeyToContinue();
            Console.WriteLine("\n\n\nYour full name is {0} {1}",firstName,lastName);
            HitAnyKeyToContinue();
            //Console.WriteLine("this is what they entered in the method",theirInput);

            double gpa = AskUserForInputDouble("your GPA");
            #endregion

            DisplayFullName(firstName, lastName, elementarySchool, gpa);

            //Wait for use to acknowledge results
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPlease hit ENTER to end program . . .");
            Console.Read();
        }
        //Display Void method
        public static void DisplayFullName(string x, string y, string z, double a)
        {
            Console.WriteLine("We're inside the method now");
            Console.WriteLine("Your full name is {0} {1}",x,y);
            Console.WriteLine("You went to {0} elementary school",z);
            Console.WriteLine("Your GPA is {0}", a);
        }

        //This is a void method
        public static void HitAnyKeyToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlease hit any key to continue . . . ");
            //string dogName = AskUserForInput("your dog's name");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
        //This is our first method that returns a value
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("\nPlease enter your . . . {0}", x);
            string theirInput = Console.ReadLine();
            return theirInput;
        }
        public static double AskUserForInputDouble(string x)
        {
            Console.WriteLine("\nPlease enter your . . . {0}", x);
            string theirInput = Console.ReadLine();
            double theirDouble = Convert.ToDouble(theirInput);
            return theirDouble;
            
        }

    }
}
