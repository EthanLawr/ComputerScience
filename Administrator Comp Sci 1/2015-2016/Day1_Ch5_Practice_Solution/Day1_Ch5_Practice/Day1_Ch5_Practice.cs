using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Ch5_Practice
{
    class Day1_Ch5_Practice
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter your graduation year");
            int gradYear = Convert.ToInt32(Console.ReadLine());
            string classYear = SwitchGradYear(gradYear);
            Console.WriteLine("You are a {0}",classYear);
            
            Console.Read();
        }
        public static string SwitchGradYear(int x)
        {
            string y = "empty";
            switch(x)
            {
                case 2016:
                    y = "Senior";
                    break;
                case 2017:
                    y = "Junior";
                    break;
                case 2018:
                    y = "Sophomore";
                    break;
                case 2019:
                    y = "Freshman";
                    break;
                default:
                    Console.WriteLine("Incorrect HS year");
                    Console.WriteLine("Please enter a correct HS year");
                    int z = Convert.ToInt32(Console.ReadLine());
                    y = SwitchGradYear(z);
                    break;
            }
            return y;
        }
    }
}
