using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per78_Chapter3_Practice
{
    class Day2_Per78_Chapter3_Practice
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

            const string LAST_NAME = "Lynch";
            int ageOfMom = 56;
            string firstName = "Knucklehead";
            char finalGrade;
            finalGrade = 'A';
            double gPA = 3.00;

            const decimal PA_SALES_TAX = 0.06m;
            const float PI = 3.1415926F;

            //Formal way to use variables
            Console.WriteLine("Your first name is " 
                + firstName + " and last name is " + LAST_NAME);

            //Preferred Method especially with numbers
            Console.WriteLine("Your full name is {0} {1}",firstName,LAST_NAME);
            Console.WriteLine("The value of Pi is {0:C4}",PI);//format specifier

            //Modulus practice
            int r = 41;
            int q = 25;
            int s = r % q;
            Console.WriteLine("The remainder of {0}/{1} is {2}",r,q,s);

            //5 = int t;  Variable on left, value on right
            int t = 5;

            //Increment operators ++ or -- 
            Console.WriteLine("original value for r is {0}",++r); //add 1 before use
            Console.WriteLine("value r now is {0}",r++);//uses then adds 1
            Console.WriteLine("value r now is {0}",++r);
            //subtract or add by more than one
            q = q - 3;
            Console.WriteLine("q is {0}",q);

            //Casting
            int a = 12/4;
            int b = 3;
            //double c = (double)a / b;
            Console.WriteLine("The computer things 5/3 = {0}",(double)a/b);

            //Boolean variables
            bool c = a == b;
            Console.WriteLine("Boolean variable c = {0}",c);//True or False

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
