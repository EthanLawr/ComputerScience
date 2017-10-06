using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per3_Chapter3_Practice
{
    class Day1_Per3_Chapter3_Practice
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

            //chapter 3 Practice stuff

            string firstName = "Dan";
            string lastName = "Knucklehead";
            int ageOfStudent = 18;

            double gradePointAverage;
            gradePointAverage = 3.75;
            
            const float PA_SALES_TAX = 0.06f;
            const decimal PI = 3.1415926M;
            int age = 3;
            int modulo = age % 2;

            //This is the formal way
            Console.WriteLine("Your first name is " 
                + firstName + " and last name is " + lastName);
            
            //Prefered especially with numbers
            Console.WriteLine("The value for Pi is {0:C4}",PI);//Format Specifier
            Console.WriteLine("First name is {0} and last name is {1}"
                ,firstName,lastName);

            Console.WriteLine(":alkjsdhlkjadshflkjsadhf lksajfdhalkjdshfalk"
                + "sjdfhlKJSADhflkjdsfhlkjadshf");
            //Use the + operator for long lines

            //Modulus Practice
            Console.WriteLine("Moludo {0}: this is the remainder of 10/3",10%3);

            //increment operator of ++ or --
            int n = 7;
            Console.WriteLine("our original n = {0}",++n);//add 1 before into cw
            Console.WriteLine("new n = {0}",n++);//add 1 after n is used in cw
            Console.WriteLine("now n = {0}",n);
            n = n - 5;//we are subtracting 5
            Console.WriteLine("more than one increment now n = {0}",n);
            Console.WriteLine("subtracting one now n = {0}",--n);//subt before cw

            //Casting
            int a = 5;
            int b = 3;
            Console.WriteLine("The computer thinks {0}/{1} is {2:N3}",a,b,a/b);
            //The computer thinks an int/int is still and int

            //Boolean Variables
            int d = 5;
            int e = 11/2;//uncasted computer thinks e = 5
            bool f = d == e;//When you use f the word "True" will appear
            Console.WriteLine("Does d {0} = e {1}? {2}",d,e,f);
                

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
