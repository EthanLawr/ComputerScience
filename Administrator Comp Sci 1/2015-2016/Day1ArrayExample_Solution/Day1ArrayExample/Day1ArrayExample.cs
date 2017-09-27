using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1ArrayExample
{
    class Day1ArrayExample
    {
        static void Main(string[] args)
        {
            //Arrays - You know how many values to put in
            int[] intArray = { 5, 7, 2, 3, 8, 9, 7, 5, 4, 3, 2, 1, 14, 34 };
            int amtOfInts = intArray.Length;//Use .Length for arrays

           
            Console.WriteLine("There are {0} integers in this array",amtOfInts);

            Console.WriteLine("The unsorted array is ");
            Console.WriteLine(string.Join(",",intArray));//Joins with a comma

            //Sort this array
            Array.Sort(intArray);

            Console.WriteLine("The sorted array is ");
            Console.WriteLine(string.Join(",", intArray));

            Console.WriteLine("\n\n\n\n");
            //Collections (Lists) - undetermined length

            List<string> firstNames = new List<string>();

            string name = AskUserForInput("a first name");

            while (name != "-99")
            {
                firstNames.Add(name);
                name = AskUserForInput("another first name or -99 to exit");
            }

            //use .Count for lists
            int amtOfListNames = firstNames.Count;
            Console.WriteLine("You entered {0} names", amtOfListNames);

            //Alphabetically list names
            firstNames.Sort();

            //List in alphebetical order
            Console.WriteLine("The names are");
            Console.WriteLine(string.Join("\t",firstNames));
            Console.Read();
        }
        public static string AskUserForInput(string x)
        {
            Console.WriteLine("Please enter {0}", x);
            string input = Console.ReadLine();
            return input;
        }
    }
}
