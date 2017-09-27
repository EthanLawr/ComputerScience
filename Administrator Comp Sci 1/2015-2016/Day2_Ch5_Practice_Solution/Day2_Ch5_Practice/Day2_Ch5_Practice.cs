using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Ch5_Practice
{
    class Day2_Ch5_Practice
    {
        static void Main(string[] args)
        {
            string gradYear = AskUserForInput("Your graduation year");
            string name = SwitchGradYear(gradYear);

            Console.WriteLine("If your grad year is {0} then you are a {1}",gradYear,name);
            Console.Read();
        }
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("Please enter {0}",x);
            string input = Console.ReadLine();
            return input;
        }
        public static string SwitchGradYear(string x)
        {
            string y = "not in high school";
            switch(x)
            {
                case "2016":
                    y = "Senior";
                    break;
                case "2017":
                    y = "Junior";
                    break;
                case "2018":
                    y = "Sophomore";
                    break;
                case "2019":
                    y = "Freshmen";
                    break;
                default:
                    Console.WriteLine("You are a knucklehead");
                    Console.WriteLine("You didn't enter a correct year");
                    string z = AskUserForInput("a current high school grad year");
                    string a = SwitchGradYear(z);
                    Console.WriteLine("if you graduate in {0} then you are a {1}",z,a);
                    break;
            }
            return y;
        }
    }
}
