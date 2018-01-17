using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Exercise1
{
    class Ch4_Exercise1
    {
        static void Main(string[] args)
        {
            HeaderFooter.Header(); //Header
            Colors.MagentaFont(); //Magenta Font
            string firstName = AskUserForString("your first name\n"); //Whats your first name
            string middleName = AskUserForString("your middle name\n"); //Whats your middle name
            string lastName = AskUserForString("your last name\n"); //Whats your last name
            HeaderFooter.Loading(); //Loading
            Console.Clear(); //Console cleared!
            HeaderFooter.SecondHeader(); //Second header after the reset
            Colors.YellowFont(); //Yellow font added
            Console.WriteLine("Your name is {0} {1} {2}.", firstName, middleName, lastName); //Bep. Your answers.

            Console.WriteLine("\n\n"); // Spacing!
            HeaderFooter.Footer(); //Footer 
        }
        public static string AskUserForString(string x)
        {
            Console.WriteLine("Please enter {0}", x); /*x serves as a placehoder for whatever you want to 
            insert from the Main(); */
            string input = Console.ReadLine();
            //Any variable defined inside a Method only exists in that method
            return input;
        }
    }
}
