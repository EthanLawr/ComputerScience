using System;
using System.Collections.Generic;
namespace Chapter7_Program7_SortingNames
{
    class Chapter7_SortingNames
    {
        static void Main()
        {

            // Create list
            var myList = new List<string>();
            String someString = AskUserForString("a name. To stop asking for names type \"0\"");
            myList.Add(someString);
            while (someString != "0")
            {
                someString = AskUserForString("a name. To stop asking for names type \"0\"");
                if (someString != "0") myList.Add(someString);
            }

            // Convert to array
            var names = myList.ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                var x = names[i];
                var j = i;
                while (j > 0 && names[j - 1].CompareTo(x) > 0)
                {
                    names[j] = names[j - 1];
                    j = j - 1;
                }
                names[j] = x;
            }
            foreach (string name in names) Console.WriteLine(name);
            Console.ReadKey();
        }
        internal static string AskUserForString(string x)
        {
            Console.Write("Please enter {0}\t\t", x);
            string input = Console.ReadLine(); //Reads the inputs
            Console.WriteLine(); //Spacing
            return input;
        }
    }

}
