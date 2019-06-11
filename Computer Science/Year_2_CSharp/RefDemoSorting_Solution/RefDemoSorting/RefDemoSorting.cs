using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Array Questions??
 * 
 * ref keyword demo
 * 
 * setup notes for sorting
 * 
 * next class: Bubble, Selection, Insertion, Merge, Heap . . . Others
*/

namespace RefDemoSorting
{
    class RefDemoSorting
    {
        static void Main(string[] args)
        {
            // Basic Swap
            int x1 = 14, x2 = 8;

            Console.WriteLine($"x1 = {x1}\nx2 = {x2}\n");

            Swap(ref x1, ref x2);
            Console.WriteLine($"x1 = {x1}\nx2 = {x2}\n");

            // Array Basic Swap
            int[] intArray = { 0, 4, 5, 6, 2, 8, 1 };
            printArray(intArray);

            for (int i = 0; i < intArray.Length-1; i++) Swap(ref intArray[i], ref intArray[i + 1]);
            printArray(intArray);

            // Array Sorted Swap
            Console.WriteLine();
            // Bubble Sort
            // 2 Arrays used to make sure all values go in the right order
            BubbleSorterHelper(intArray);
            printArray(intArray);

            // Special Testing of Bubble Sort. Shows a random generation of 100 numbers sorted least to greatest.
            Console.WriteLine();
            Random randomgen = new Random();
            int[] newArray = new int[100];
            for (int i = 0; i < newArray.Length; i++) newArray[i] = randomgen.Next(-50, 50);
            BubbleSorterHelper(newArray);
            printArray(newArray);



            Console.ReadKey();
        }

        internal static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        internal static void printArray(int[] x)
        {
            foreach (int y in x) Console.Write($"{y} ");
            Console.WriteLine();
        }

        internal static void BubbleSorter(ref int x, ref int y)
        {
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }

        internal static void BubbleSorterHelper(int[] array)
        {
            // Used to keep code above clean.
            // This uses an array and reassigns each value using the bubble sorting method. It can work with an array of any usable size
            for (int z = 0; z != array.Length; z++) for (int i = 0; i < array.Length - 1; i++) BubbleSorter(ref array[i], ref array[i + 1]);
        }
    }
}
