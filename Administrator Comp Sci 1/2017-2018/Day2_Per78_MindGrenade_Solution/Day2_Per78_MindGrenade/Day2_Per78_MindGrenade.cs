using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_MindGrenade
{
    class Day2_Per78_MindGrenade
    {
        //PUt a method here

        static void Main(string[] args)//Main(); = "main method"
        {
            //Everything starts and ends here
            //Goal: To have as little code in Main() as possible

            CommonTasks.HeaderB("1/9/18", "To blow minds");

            HitAnyKeyToContinue("knucklehead");//Calls the method once
            HitAnyKeyToContinue("a;lkjdshfa;likjh");
            HitAnyKeyToContinue("Goober");//invokes this method three times

            int testScore1 = AskUserForInt("your first test score");
            int testScore2 = AskUserForInt("your 2nd test");
            //This calls or invokes the AskUserForInt method two different
            //times

            TestAverage(testScore1, testScore2);//This sends two pieces
            //of information from the Main(); into the TestAverage method


            #region Stuff before break
            Header(); //this is a call to a method
            Day2_Per78_MindGrenade.Header();//Not necessary

            //Grenade pin pulled
            //Get user input
            string homeTown = AskUserForString("your home town");
            string firstName = AskUserForString("your first name");
            string lastName = AskUserForString("your last name");
            //Calling the AskUserForString method three times

            Console.WriteLine("You're name is {0} {1} \nand you live in" 
                + " {2}, PA",firstName, lastName, homeTown);

            //What about numbers?
            int age = AskUserForInt("your age");

            Console.WriteLine("You are {0} years old", age/2);
            #endregion

            Footer();//Call the method Footer to display what was in there
        }

        public static void TestAverage(int a, int b)
        {
            double averageOfTests = ((double)a + b) / 2;//Casting!!!!
            Console.WriteLine("If your scores are {0} and {1} then"
                + " your average is {2}", a, b, averageOfTests);
            //note: "averageOfTests" is a local variable to THIS method
            //only!
        }

        public static void HitAnyKeyToContinue(string x)
        {
            Console.WriteLine("\n\nPlease hit ANY key to continue . . . ");
            Console.WriteLine(x);//x is a placeholder from the Main();
            Console.ReadKey();
        }

        public static int AskUserForInt(string x)
        {
            Console.WriteLine("Please enter . . . {0}",x);
            string input = Console.ReadLine();//ReadLine() only accepts strings
            int inputInt = Convert.ToInt32(input);//Need to Convert when
            //using numbers
            return inputInt;

        }

        public static string AskUserForString(string x)
        {
            Console.WriteLine("Please enter . . . {0}",x);//x serves as a 
            //placehoder for whatever you want to insert from the Main();
            string input = Console.ReadLine();
            //Any variable defined inside a Method only exists in that method
            return input;
        }

        public static void Header()
        {
            //Display Method . . . display cw's
            Console.WriteLine("Author: Mr Lynch\t\tTitle: Mind Grenade");
            Console.WriteLine("\nDate: 12/22/17");
            Console.WriteLine("\nPurpose: to introduce some basic methods");
            Console.WriteLine("\n***************************************************\n");
        }
        //Put a method here
        public static void Footer()
        {
            Console.WriteLine("\n\nPlease enter ANY key to end program . . . ");
            Console.ReadKey();
        }
    }
}
