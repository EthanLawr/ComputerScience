using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_Chapter3Practice
{
    class Day1_Per3_Chapter3Practice
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
            //Types of variables
            int age;//This is just declaring the variable age as and integer
            int yearOfGraduation = 2018;//declared and initialized with a value
            //floating point types
            double gradePointAverage = 3.25;
            float costOfTShirt = 19.95f;//F or f at the end of the value
            decimal mortgageInterestRate = 0.0375M;//M or m at end
            //This would be a rate that changes month to month
            //decimal is used for money calculations
            const decimal PA_SALES_TAX = 0.06m;//constants are ALL CAPS
            string firstName = "Dan";//strings get " " 
            string lastName;//just declared, will be assigned a value later
            lastName = "Lynch";
            char finalGrade = 'A';//characters (chars) get ' '
            bool rainingOutside = true;
            #endregion

            //How do we use them in Console.WriteLine()
            Console.WriteLine("Your first name is " + firstName);
            //old school way to do it using the + operator
            Console.WriteLine("Your GPA is {0}", gradePointAverage);
            //This is the way we want you to do this

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);
            //old school
            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            #region Casting
            //using numbers
            int m = 8;
            int n = 3;
            double divisionCareful = m / n; //2.0
            //need a CAST
            divisionCareful = (double)m / n;//place (double) in front of int
            //to make it a double
            Console.WriteLine("{0} divided by {1} is {2}",m,n,divisionCareful);
            //This will haunt your dreams . . . CASTING
            #endregion

            //increment (add 1 or subtract 1)
            int i, j, k; //This declares three ints at once
            i = 5;
            j = 3;
            k = 8;
            Console.WriteLine("\n\n{0} is the value for i", ++i); //++ before
            //an integer value adds 1 BEFORE it is printed or used
            Console.WriteLine("{0} is the value for j", j++);// ++ after an 
            //integer value will add 1 AFTER it is printed or used so that the
            //next time it's used the value will change
            Console.WriteLine("{0} is the NEW value for j",j);
            Console.WriteLine("{0} is the value for k", --k);//same logic as ++
            Console.WriteLine("{0} is the NEW value for i", ++i);
            j = j + 6;
            //When we learn loops this is a BIG deal!
            double sum = 0.0;
            double score = 75.0;
            sum = sum + score;//will continue to add a new score to the sum
            //total until the loop is exited
            Console.WriteLine("{0} is the NEW value for j", j);

            //A little boolean variable work
            int a = 5;
            int b = 6;
            bool c = a == b;
            Console.WriteLine("\n\n{0} = {1} is {2}",a,b,c);

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
