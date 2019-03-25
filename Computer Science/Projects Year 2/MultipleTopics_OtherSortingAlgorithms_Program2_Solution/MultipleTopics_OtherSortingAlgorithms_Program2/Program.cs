using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTopics_OtherSortingAlgorithms_Program2
{
    class Program
    {

        static void Main(string[] args)
            // Make quicksort and insertion
        {
            #region Common Words
            string[] commonWords = { "the", "of", "and", "a", "to", "in", "is", "you", "that", "it", "he", "was", "for", "on", "are", "as", "with",
            "his", "they", "I", "at", "be", "this", "have", "from", "or", "one", "had", "by", "word", "but", "not", "what",
            "all", "were", "we", "when", "your", "can", "said", "there", "use", "an", "each", "which", "she", "do", "how",
            "their", "if" }, commonWords2 = commonWords, commonWords3 = commonWords;
            #endregion

            #region Random Number Array Generator
            Random randomgen = new Random();
            // Makes random values
            int[] newArray = new int[100];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = randomgen.Next(-50, 50);
            }
            int[] newArray2 = newArray, newArray3 = newArray;
            #endregion

            // Display of unsorted arrays
            Console.WriteLine("Arrays Unsorted\n");
            printIntArray(newArray);
            printStringArray(commonWords);

            // Bubble Sorting
            Console.WriteLine("Bubble Sorted\n");
            BubbleIntSorterHelper(newArray);
            printIntArray(newArray);

            BubbleStringSorterHelper(commonWords);
            printStringArray(commonWords);

            // Quick Sorting
            Console.WriteLine("Quick Sorted\n");
            Quick_SortInt(ref newArray2, 0, newArray2.Length - 1);
            printIntArray(newArray2);

            Quick_SortString(ref commonWords2, 0, commonWords2.Length - 1);
            printStringArray(commonWords2);

            // Insertion Sorting
            Console.WriteLine("Insertion Sorted\n");
            InsertionSortInt(ref newArray);
            printIntArray(newArray);

            InsertionSortString(ref commonWords);
            printStringArray(commonWords);


            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        #region Print Array
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
        #endregion

        #region Bubble Sort
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
        #endregion

        #region Quick Sort
        private static void Quick_SortInt(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1) Quick_SortInt(ref arr, left, pivot - 1);
                if (pivot + 1 < right) Quick_SortInt(ref arr, pivot + 1, right);
            }

        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else return right;
            }
        }

        private static void Quick_SortString(ref string[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1) Quick_SortString(ref arr, left, pivot - 1);
                if (pivot + 1 < right) Quick_SortString(ref arr, pivot + 1, right);
            }

        }
        private static int Partition(string[] arr, int left, int right)
        {
            string pivot = arr[(left + right) / 2];
            while (true)
            {
                while (string.Compare(arr[left], pivot) < 0) left++;
                while (string.Compare(arr[right], pivot) > 0) right--;
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    string temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else return right;
            }
        }
        #endregion

        #region Insertion Sort
        private static void InsertionSortInt(ref int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        private static void InsertionSortString(ref string[] arr)
        {
            int j;
            string temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && string.Compare(arr[j], temp) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        #endregion 
    }
}
