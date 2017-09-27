/* Author: Mr. Lynch    Title: <put Title here>
 * Date: ##/##/##
 * This program is meant to . . . 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_April_Fools
{
    class Day2_April_Fools
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

            //Nested for loops . . . will run through a total of 20 times
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < 4; n++)
                {
                    Console.WriteLine("\n{0} x {1} = {2}",i,n,i*n);
                }
            }

            //for loop will run through 5 times (counter controlled)
            // . . . when you know how many times you want to run throuh a loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nEnter a test score");
                double testScore = Convert.ToDouble(Console.ReadLine());
            }

            //do . . . while loop
            string name;
            do
            {
                Console.WriteLine("Please enter a name or 'quit' to exit loop");
                name = Console.ReadLine();
            } while (name != "quit");

            Console.WriteLine("\nOutside the loop now");

            //while loop that is sentinel controlled, don't know how many times
            //to run through the loop
            Console.WriteLine("\nEnter a name, or '-975' to quit");
            string newName = Console.ReadLine();
            int t = 0;
            while (name != "-975")
            {
                Console.WriteLine("\nEnter a new name, or '-975' to quit");
                newName = Console.ReadLine();
                t = t + 1;  //same thing as t++
            }
            Console.WriteLine("Now we are outside the loop");
            Console.WriteLine("You ran through the loop {0} times", t);

            //while loop that is counter controlled
            int d = 1;
            while (d < 7)
            {
                Console.Write("\nPlease enter the Name {0}:\t", d);
                string lastName = Console.ReadLine();
                d++;
            }

            //End of program
            Console.WriteLine("\nPlease hit ENTER to exit program.");
            Console.Read();

        }
    }
}
