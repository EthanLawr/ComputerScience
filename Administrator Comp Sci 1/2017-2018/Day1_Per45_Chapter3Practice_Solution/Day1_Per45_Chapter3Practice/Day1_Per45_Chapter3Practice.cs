using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Chapter3Practice
{
    class Day1_Per45_Chapter3Practice
    {
        static void Main(string[] args)
        {
            #region Header
            //Create a header
            Console.WriteLine("Author: Mr. Lynch \t\t\tTitle: Ch # Program #");
            // \t tabs over\
            Console.WriteLine(""); //This is an empty string
            Console.WriteLine("Date: ##/##/##");
            Console.WriteLine("\nPurpose: This program is meant "
                + "to show students \nsome of the basics in "
                + "programming of the chapter");// \n creates a new line
            Console.WriteLine("****************************************"
                + "********************\n\n\n");
            #endregion

            #region Variable types
            //Main Code
            //Types of variables
            int numOfComputers;//This is declaring the variable numOfComputers
            //as an integer
            numOfComputers = 27;//assigns the value 27 to the variable
            int ageOfStudent = 17;//This is declaring and initializing/assigning

            //floating point types . . . anything with a decimal value
            double gradePointAverage = 3.25;//use a double most often
            decimal valueOfPants = 29.95m;//m or M needed for decimals at end
            //decimals are mainly used for money calculations
            float mortgageRate = 0.0375F;//F or f needed for a float
            //CONSTANTS
            const decimal PA_SALES_TAX = 0.06M;//constants are always ALL CAPS
            //use the const keyword in front of the variable type
            const string HOLIDAY_AT_END_OF_OCTOBER = "Halloween";
            char finalGrade = 'A'; //Note single quotes '' for chars
            string firstName;//only declared as a string
            string lastName = "Lynch";//declared and initialized
            bool rainingOutside = true;//true or false variables
            #endregion

            //How are variables used to show up in the Console window?
            //Prefered method
            Console.WriteLine("Your last name is {0}",lastName);
            firstName = "Dan"; 
            Console.WriteLine("Your full name is {0} {1}",firstName, lastName);
            //Old school way using the + operator
            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.WriteLine("Half of your GPA is {0}", gradePointAverage/2);

            //Tricky McTrickerson
            int a = 8;
            int b = 3;
            double divisionTomFoolery = a / b; //  2.0
            //A CAST is needed
            divisionTomFoolery = (double)a / b; //  8.0/3
            //Computer thinks an int divided by and int is still and int
            Console.WriteLine("\n\n{0:C2} divided by {1:n2} is equal to {2:N4}",a,b,divisionTomFoolery);
            // {2:N4} this will round to 4 decimal places
            //{0:C2} is the currency format specifier $ and rounds to 2 decimals
            //Going to HAUNT your dreams . . . CASTING!!!!

            //increment operator (mainly used for loops)
            int m = 3, n = 6, s = 15;//if you have multiple variables you can
            //declare and initialize all in one line
            Console.WriteLine("\n\nThe value for m is {0}, and the value for n is "
                + "{1}, and the value for s is {2}", m,n,s);
            m++;// ++ operator after the value will adds one to the value 
            //AFTER it is used in the 
            //console window once
            --n;// -- before a value will subtract one to the value BEFORE it 
            //is used in the console window.
            s = s + 3; // This will add three to the the orignal s value
            Console.WriteLine("\n\nThe NEW value for m is {0}, and the NEW value"
                + " for n is {1}, and the NEW value for s is {2}", ++m, --n, s--);
            Console.WriteLine("{0} is the value for s NOW",s);
            //When we loop
            double sumOfTests = 0;
            double score = 75.0;//run through a loop
            sumOfTests = sumOfTests + score;

            //a very small amount of boolean variables
            bool checkEquals = m == b;
            Console.WriteLine("\n{0} equals {1} is {2}",m,b,checkEquals);

            double r = 123465.845655;
            Console.WriteLine("{0:F3} and then {0:N}",r);//Format Specifiers
            //help with rounding and formating of numerical values
            //Note if no value after the letter specifier, rounds to 2 places
            //i.e. {0:N} gives 123,465.85

            #region Footer
            //This is how we will end our program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please hit ENTER key to end program...");
            Console.Read();
            #endregion
        }
    }
}
