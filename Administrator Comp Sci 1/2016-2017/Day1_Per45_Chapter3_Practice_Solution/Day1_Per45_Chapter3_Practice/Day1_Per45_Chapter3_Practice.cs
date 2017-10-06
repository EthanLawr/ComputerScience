using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_Chapter3_Practice
{
    class Day1_Per45_Chapter3_Practice
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            //Chapter 3 Practice

            //declaring and initializing variables
            string lastName = "Jones";
            int ageOfCar = 3;
            char firstLetterOfLastName = 'L';
            float priceOfApplesPerPound;
            priceOfApplesPerPound = 0.79F;

            //initializing constants
            const double PA_SALES_TAX = 0.06;
            const decimal PI = 3.1415926m;

            //Let's use these guys
            //Formal way
            Console.WriteLine("Your last name is " + lastName 
                + " and your car is " + ageOfCar + " years old");

            //Prefered way especially with numbers
            Console.WriteLine("Your last name is {0} and your"
                + " car is {1:N5} years old",lastName,ageOfCar);
            Console.WriteLine("The value of Pi is {0:C3}",PI);//format specifier

            //Modulus Practice
            int change = 40;
            const int QUARTER_VALUE = 25;
            int remainderAfterQuarters = change % QUARTER_VALUE;
            Console.WriteLine("remainder of {0} % {1} is {2}"
                + "", change, QUARTER_VALUE,remainderAfterQuarters);

            //5 = int d; Doesn't work
            int d = 3;

            //increment practice
            Console.WriteLine("original d value = {0}",d++);
            Console.WriteLine("d is now {0}",++d);
            d = d + 2;
            Console.WriteLine("d is now {0}",d);

            //Casting
            Console.WriteLine("The computer things int 5 / int 3 is {0:N3}",(double)5/3);

            //Boolean variables
            d = 6 / 2;
            int e = 3;
            bool b = d > e;
            Console.WriteLine("The boolean variable b will say {0}",b);

            #region This is where we end the program
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
            #endregion
        }
    }
}
