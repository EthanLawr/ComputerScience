using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_3_24_2015_Chapter6_Loops
{
    class Day2_3_24_2015_Chapter6_Loops
    {
        static void Main(string[] args)
        {
            //int n = 4;
            //while (n<=10)
            //{
            //    Console.WriteLine("Hello World!");
            //    n = n + 2;
            //}

            //Sentinel
            //Console.Write("Enter a color:");
            //string color = Console.ReadLine();
            //while (color != "-99")
            //{
            //    Console.WriteLine("Your hair color is {0}",color);
            //    Console.WriteLine("Enter a new color or -99 to exit:\t");
            //    color = Console.ReadLine()
            //}

            //Flag Controlled
            bool moreData = true;
            while (moreData)
            {
                Console.WriteLine("The jibberish");
                Console.WriteLine("Do you want to continue? (y/n)");
                string theirInput = Console.ReadLine();
                if (theirInput == "y")
                {
                    Console.WriteLine("slkdfjalksdjf:LK");
                }
                
                else
	            {
                    moreData = false;
	            }
            }

            Console.Read();
        }
    }
}
