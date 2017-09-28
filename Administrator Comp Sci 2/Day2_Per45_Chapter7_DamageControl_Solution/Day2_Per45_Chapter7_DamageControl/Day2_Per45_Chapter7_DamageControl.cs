using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Per45_Chapter7_DamageControl
{
    class Day2_Per45_Chapter7_DamageControl
    {
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("Please enter ... {0}",x);
            string inputString = Console.ReadLine();
            return inputString;
        }
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            List<string> bunchOfString = new List<string>();

            string x = AskUserForInput("a string");

            //Sentinel Controlled loop
            while (x != "-99")
            {
                bunchOfString.Add(x);
                x = AskUserForInput("another string or '-99' to exit");
            }
            
            int amountOfStrings = bunchOfString.Count;//Tells how many strings
            bunchOfString.Sort();//alphabetizes the list

            Console.WriteLine("You entered {0} strings",amountOfStrings);
            Console.WriteLine("The names you entered in sorted order . .  ");
            //**************
            Console.WriteLine(string.Join("\t",bunchOfString));
            //string.Join allows you to display an entire list without using
            //a foreach loop                                                  
            //***********

            //Array example
            int[] intArray = { 4, 6, 2, 6, 9, 2, 1, 0, 3, 2, 67, 12345, 67543 };

            Console.WriteLine("The unsorted array is. . . ");
            Console.WriteLine(string.Join(", ", intArray));
            //Don't need to use a foreach loop if use string.Join

            Array.Sort(intArray);
            Console.WriteLine("The sorted array is . . . :");
            Console.WriteLine(string.Join("    ", intArray));

            //Binary Search
            int y = AskUserForInt("an int that you would like to search for");
            int position = Array.BinarySearch(intArray, y);
            position++;//because when you search for where the position of
            //the number you entered it gives you the index which counts
            //from 0, so add one to get the correct answer
            Console.WriteLine("The position that the number you entered is"
                + " in the sorted array is {0}",position);


            #region This is where we end the program
            //End any program
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\nPlease hit the ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ENTER ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" key to end program . . . ");
            Console.Read();
            #endregion
        }
        public static int AskUserForInt(string x)
        {
            Console.WriteLine("Please enter . . . {0}",x);
            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);
            return inputInt;
        }
    }
}
