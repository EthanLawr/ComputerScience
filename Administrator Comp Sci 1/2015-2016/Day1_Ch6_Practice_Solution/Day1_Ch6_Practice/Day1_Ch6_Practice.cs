using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Ch6_Practice
{
    class Day1_Ch6_Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name game");
            string firstName = FirstName("a name or '-99' to exit");

            //Sentinel Controlled (dummy value)
            while (firstName != "-99")
            {
                Console.WriteLine("Please enter another name");
                firstName = FirstName("a new name or '-99' to exit");

            }
            Console.WriteLine("Now outside sentinel loop");
            
            //Counter Controlled Loop
            int n = 1;
            while (n<10)
            {
                Console.WriteLine("Loop through");
                n = n + 3;
            }

            #region State Controlled While Loop
            string total = "";
            bool moreData = true;
            while (moreData)
            {
                
                Console.WriteLine("Do you want to enter another name? type 'yes'");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    string x = FirstName("another name");
                    total = total + " " + x;
                }
                else
                {
                    moreData = false;
                }

            }
            Console.WriteLine("the entire name list is {0}",total);
            #endregion

            Console.WriteLine("Please hit ENTER to end program. . .");
            Console.Read();
        }
        public static string FirstName(string x)
        {
            Console.WriteLine("Please enter {0}",x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
