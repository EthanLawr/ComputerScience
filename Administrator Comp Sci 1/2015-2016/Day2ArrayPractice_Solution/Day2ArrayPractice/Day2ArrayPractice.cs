using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ArrayPractice
{
    class Day2ArrayPractice
    {
        static void Main(string[] args)
        {
            //Arrays are used when you know how many elements
            int[] intArray = { 3, 5, 6, 7, 4, 53, 3, 2, 2, 43, 5, 76, 8, 65, 4, 43251, 2 };

            //Display the array unsorted
            Console.WriteLine("The unsorted array is");
            Console.WriteLine(string.Join(",", intArray));

            //Arrays lengths .Length method
            int amountOfInts = intArray.Length;
            Console.WriteLine("There are {0} integers in this array",amountOfInts);

            //sort numerically
            Array.Sort(intArray);

            Console.WriteLine("The sorted array is");
            Console.WriteLine(string.Join(",", intArray));

            //Lists or Collections (number of elements is unknown)
            List<string> dumbRelationshipNames = new List<string>();

            string name = AskUserForInput("silly relationship name");

            while (name != "-99")
            {
                dumbRelationshipNames.Add(name);
                name = AskUserForInput("another dumb name or -99 to exit");
            }

            //List length use .Count
            int amtOfNames = dumbRelationshipNames.Count;
            Console.WriteLine("You entered {0} names",amtOfNames);

            Console.WriteLine("The unsorted list is");
            Console.WriteLine(string.Join("\t", dumbRelationshipNames));

            //Sort List alphabetically
            dumbRelationshipNames.Sort();
            Console.WriteLine("The sorted list is");
            Console.WriteLine(string.Join("\n", dumbRelationshipNames));


            Console.Read();


        }
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("Please enter {0}",x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
