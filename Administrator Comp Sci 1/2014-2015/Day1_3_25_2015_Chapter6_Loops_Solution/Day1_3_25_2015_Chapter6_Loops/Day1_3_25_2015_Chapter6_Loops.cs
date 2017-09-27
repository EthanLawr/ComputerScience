using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_3_25_2015_Chapter6_Loops
{
    class Day1_3_25_2015_Chapter6_Loops
    {
        static void Main(string[] args)
        {
            //Counter Controlled
            //int n = 4;
            //while (n<10)
            //{
            //    Console.WriteLine("Hello World!");
            //    n = n + 2;
            //}

            //Sentinel Controlled
            //Console.WriteLine("Enter a test score (-999 to quit)");
            //string inputString = Console.ReadLine();
            //double inputDouble = Convert.ToDouble(inputString);
            //while (inputDouble != -999)
            //{
            //    Console.WriteLine("Enter a new test score");
            //    inputDouble = Convert.ToDouble(Console.ReadLine());
            //}


            //Flag Controlled (State)
            bool moreData = true;
            while (moreData)
            {
                Console.WriteLine("Would you like to enter a name? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Please enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("The name you entered is {0}",name);
                }
                else
                {
                    moreData = false;
                }
            }


            Console.WriteLine("Outside the loop now");
            Console.Read();
        }
    }
}
