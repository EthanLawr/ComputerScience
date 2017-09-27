/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_April_4
{
    class Day1_April_4
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);
            Console.Title = "Chapter # Program # - <name of program>";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tAuthor: Mr. Lynch  Title: <name of title>\n");
            Console.WriteLine("\t\t\tDate: ##/##/####\n");
            Console.WriteLine("\tThis program is meant to . . . \n");
            Console.WriteLine("\t^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
                +"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            //for loop inside a for loop (runs through a total of 15 times)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\n{0} x {1} = {2}", i, j, i * j);
                }
            }

            //for loop . . . counter controlled
            int k = 0;
            for (k = 0; k < 5; k++)
            {
                Console.WriteLine("\nPlease enter a name");
                string newName = Console.ReadLine();
            }

            Console.WriteLine("\n\n\n\nNow we're outside the loop!");
            Console.WriteLine("We just looped through {0} times", k);

            //do while loop . . . counter controlled
            int n = 0;
            do
            {
                Console.WriteLine("\nPlease enter a test score");
                double testScore = Convert.ToDouble(Console.ReadLine());
                n = n + 1;
            } while (n < 7);

            //while loop with a sentinel control
            Console.Write("\nPlease enter a name . . . ('quit' to exit loop)\t\t");
            string name = Console.ReadLine();
            int d = 1;
            while (name != "quit")
            {
                Console.WriteLine("\nPlease enter another name . . . ('quit' to stop)");
                name = Console.ReadLine();
                d++;
            }

            //while loop that is counter controlled
            int m = 0;
            while (m <= 5)
            {
                Console.Write("\nPlease enter a name\t\t");
                string newName = Console.ReadLine();
                m = m + 1; //same thing as m++
            }

            //Code to end the program
            Console.WriteLine("\nPress ENTER to end program");
            Console.Read();

        }
    }
}
