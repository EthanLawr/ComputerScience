using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter3Practice
{
    class Day2_Per78_Chapter3Practice
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

            #region Variables
            //This is the main part of the coding
            //Types of Variables
            int age;//this just declares the variable age as an integer
            age = 34; //this assigns/initializes the variable age to the value 34
            int favoriteNumber = 7;//this declares and initializes all at once

            //floating point types
            double gradePointAverage = 3.5;//has a decimal
            double changeInPocket, interestRate;
            double score1, score2, score3;
            score1 = 78.0; // adding a .0 at the end makes it a double
            decimal mortgageRate = 0.0375M; //m or M at the end of all decimal types
            //only use decimal type for money calculations
            float height = 77.75f;//f or F at end of a float type variable

            const double PA_SALES_TAX = 0.06;//constants need the 'const' identifier
            //constant names always use ALL CAPS
            const string MR_LYNCHS_LAST_NAME = "Lynch";
            const int INCHES_IN_FOOT = 12;

            string firstName;//declared
            string lastName = "Lynch Knucklehead";//strings use ""

            char finalGrade = 'A';//note characters use ''

            bool rainingOutside = false;//boolean variable is only true or false
            #endregion

            //How do we use these now?
            //This is the best way
            Console.WriteLine("Your last name is {0}",lastName);
            firstName = "Dan";
            Console.WriteLine("Your full name is {0} {1}",firstName,MR_LYNCHS_LAST_NAME);
            //Old School Way
            Console.WriteLine("Your full name is " + firstName + " " + MR_LYNCHS_LAST_NAME);
            //talk about the department of redundance department

            Console.WriteLine("Your GPA is {0}", gradePointAverage);//good
            Console.WriteLine("Your GPA is " + gradePointAverage);//not as good

            //Tricky McTrickerson
            int m = 8;
            int n = 3;
            double divideTricky = m / (double)n;//cast from an int to a double
            //If no cast the computer stores this value as 2.0
            //because the computer thinks an int/int is an int!
            Console.WriteLine("\n\n{0} divided by {1} is equal to {2}"
                ,m,n,divideTricky);

            //Formatting numerical values
            Console.WriteLine("\n\n{0:N4} divided by {1:p3} is equal to {2:c}"
                , m, n, divideTricky);
            //{0:N4} gives m to 4 decimal places
            //{1:P3} gives n as a percent to three places
            //{2:C} gives divideTricky as money $ . . . default to two decimals

            //Increment
            int a = 4, b = -6, c = 15;//easier to do all on one line
            Console.WriteLine("a = {0}\tb = {1}\tc = {2}",a,b,c);
            Console.WriteLine("a = {0}\tb = {1}\tc = {2}", a++, --b, c);
            // ++ after a value you use it first then it adds one AFTER used
            Console.WriteLine("a = {0}\tb = {1}\tc = {2}", a, b, c);
            //-- before a value subtracts one BEFORE its used in the console
            a++;// ++ adds one 
            c = c + 5;
            Console.WriteLine("a = {0}\tb = {1}\tc = {2}", a, b, c);
            //A big deal for looping
            double score = 0.0;
            double sumOfScores = 0.0;//send to a loop
            score = 75.0;//inside a loop
            sumOfScores = sumOfScores + score;

            //a little bit of bool
            bool aEqualsb = a == b;
            Console.WriteLine("\n\n{0} = {1} is {2}",a,b,aEqualsb);
            bool aGreaterThanb = a >= b;
            Console.WriteLine("\n\n{0} >= {1} is {2}", a, b, aGreaterThanb);

            //Formatting
            double t = 12232134.9287;
            Console.WriteLine("{0:F1} is different than {0:n1}",t);


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
