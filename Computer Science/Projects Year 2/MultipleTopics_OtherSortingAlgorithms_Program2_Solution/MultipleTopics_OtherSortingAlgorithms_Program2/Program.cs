using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTopics_OtherSortingAlgorithms_Program2
{
    class Program
    {
        public static string[] commonWords = { "the", "of", "and", "a", "to", "in", "is", "you", "that", "it", "he", "was", "for", "on", "are", "as", "with",
            "his", "they", "I", "at", "be", "this", "have", "from", "or", "one", "had", "by", "word", "but", "not", "what",
            "all", "were", "we", "when", "your", "can", "said", "there", "use", "an", "each", "which", "she", "do", "how",
            "their", "if" };
        static void Main(string[] args)
        {


            Random randomgen = new Random();
            // Makes random values
            int[] newArray = new int[100];
            for (int i = 0; i < newArray.Length; i++) newArray[i] = randomgen.Next(-50, 50);
            BubbleIntSorterHelper(newArray);
            printIntArray(newArray);

            BubbleStringSorterHelper(commonWords);
            printStringArray(commonWords);


            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        internal static void printIntArray(int[] x)
        {
            // Foreach instead of a for loop for better efficiency
            foreach (int y in x) Console.Write($"{y} ");
            Console.WriteLine("\n");
        }

        internal static void printStringArray(string[] x)
        {
            // Foreach instead of a for loop for better efficiency
            foreach (string y in x) Console.Write($"{y} ");
            Console.WriteLine("\n");
        }

        internal static void BubbleIntSorter(ref int x, ref int y)
        {
            // Compares the values and sorts from least to greatest
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }

        internal static void BubbleIntSorterHelper(int[] array)
        {
            // Used to keep code above clean.
            // This uses an array and reassigns each value using the bubble sorting method. It can work with an array of any usable size
            for (int z = 0; z != array.Length; z++) for (int i = 0; i < array.Length - 1; i++) BubbleIntSorter(ref array[i], ref array[i + 1]);
        }

        public static void BubbleStringSorter(ref string x, ref string y)
        {
            // Compares the values and sorts from A to Z
            if (string.Compare(x, y) > 0)
            {
                string temp = x;
                x = y;
                y = temp;
            }
        }

        internal static void BubbleStringSorterHelper(string[] array)
        {
            // Used to keep code above clean.
            // This uses an array and reassigns each value using the bubble sorting method. It can work with an array of any usable size
            for (int z = 0; z != array.Length; z++) for (int i = 0; i < array.Length - 1; i++) BubbleStringSorter(ref array[i], ref array[i + 1]);
        }


    }
}
