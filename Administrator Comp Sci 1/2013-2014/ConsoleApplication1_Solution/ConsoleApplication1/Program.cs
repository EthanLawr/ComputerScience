using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskUserForInputString("your name");
            string password = AskUserForInputString("your password");
            double gpa = AskUserForInputDouble("your GPA");
            DisplayResultsMethod(name, password, gpa);
            Console.Read();
        }
        public static void DisplayResultsMethod(string x,string y,double z)
        {
            Console.WriteLine("\n*************************");
            Console.WriteLine("\nYour name is {0}",x);
            Console.WriteLine("\n*************************");
            Console.WriteLine("\nYour password is {0}", y);
            Console.WriteLine("\n*************************");
            Console.WriteLine("\nYour GPA is {0}", z);
            Console.WriteLine("\n*************************");
        }
        public static string AskUserForInputString(string junk)
        {
            Console.Write("\nPlease enter . . . {0}    ",junk);
            string knucklehead = Console.ReadLine();
            return knucklehead;
        }
        public static double AskUserForInputDouble(string junk)
        {
            Console.WriteLine("\nPlease enter . . . {0}    ", junk);
            string knucklehead = Console.ReadLine();
            double pineapple = Convert.ToDouble(knucklehead);
            return pineapple;
        }
    }
}
