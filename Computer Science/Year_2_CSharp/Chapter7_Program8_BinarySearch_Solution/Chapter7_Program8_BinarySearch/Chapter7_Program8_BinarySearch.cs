using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program8_BinarySearch
{
    class Chapter7_Program8_BinarySearch:TaskShortener
    {
        static void Main(string[] args)
        {
            Header();
            List<string> someList = new List<string>{ "Something", "Something Else", "Rarted", "Hello", "Alphabet", "Idiot", "Knucklehead",
            "Dinosaurs", "Lynch", "Dan", "Zoo", "Jedi", "Super", "Amazing", "Sick"};
            for (int i = 0; i < someList.Count; i++)
            {
                someList.BinarySearch(someList[i]);
            }
            someList.Sort();
            Console.WriteLine(string.Join(",", someList));
            Footer();
        }
    }
}
