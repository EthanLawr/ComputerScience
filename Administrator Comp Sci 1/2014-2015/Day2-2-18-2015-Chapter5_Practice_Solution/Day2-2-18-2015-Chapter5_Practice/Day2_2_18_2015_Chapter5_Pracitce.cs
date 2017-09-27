using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_2_18_2015_Chapter5_Practice
{
    class Day2_2_18_2015_Chapter5_Pracitce
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            //if (age == 18)
            //{
            //    Console.WriteLine("You're probably a senior");
            //}
            //else if (age < 14)
            //{
            //    Console.WriteLine("You shouldn't be in HS");
            //}
            //else if (age >= 19)
            //{
            //    Console.WriteLine("Super senior?");
            //}
            //else if (age >= 14 && age < 18)
            //{
            //    Console.WriteLine("You're an underclassman maybe?");
            //    if (age == 16)
            //    {
            //        Console.WriteLine("You can get your PA driver's licence");
            //    }
            //}

            switch (age)
            {
                case 18: Console.WriteLine("Senior");
                    break;
                case 17: Console.WriteLine("Junior");
                    break;
                case 16:
                case 15:
                case 14: Console.WriteLine("Underclassman");
                    break;
                default:
                    Console.WriteLine("You're not in HS");
                    break;
            }
            //Wait for user to acknoledge the results.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nPlease hit Enter to exit program. . ." );
            Console.Read();

        }
    }
}
