using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_2_19_2015_Chapter5_Practice
{
    class Day1_2_19_2015_Chapter5_Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            
            switch (age)
            {
                case 18:
                    Console.WriteLine("Senior?");
                    break;
                case 17:
                    Console.WriteLine("Junior?");
                    break;
                case 16:
                case 15:
                case 14:
                    Console.WriteLine("Underclassmen?");
                    break;
                default:
                    Console.WriteLine("Not in Hs");
                    break;
                    
            }

            //if (age == 18 || age == 17)
            //{
            //    Console.WriteLine("You're probably a senior");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("You shouldn't be in HS");
            //}
            //else if (age<17 && age>=16)
            //{
            //    Console.WriteLine("youre a junior?");
            //}
            //else
            //{
            //    Console.WriteLine("Your an underclassmen or in MS or ES");
            //}

            Console.Read();
        }
    }
}
