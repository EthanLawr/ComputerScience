using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Threading;

namespace Chapter7_Program4_AvoidingDuplicates
{
    class Chapter7_Program4_AvoidingDuplicates : TaskShortener
    {
        public static string filePath = @"H:\Comp 2\projects\Chapter7_Program4_AvoidingDuplicates_Solution\Chapter7_Program4_AvoidingDuplicates\TextFile1.txt";
        static void Main(string[] args)
        {
            Header();
            using (StreamReader superReads = File.OpenText(filePath))
            {
                string textString;
                while ((textString = superReads.ReadLine()) != null)
                {
                    // Original array
                    string[] textSplit = textString.Split(' ');
                    Console.Write($"\nThe original set of numbers are: ");
                    for (int i = 0; i < textSplit.Length; i++) Console.Write($"{textSplit[i]}\t");
                    // New list to make into an array with all the values
                    var newList = new ArrayList();
                    for (int i = 0; i < textSplit.Length; i++)
                    {
                        // Checking if the value is already in the list
                        if (newList.Contains(textSplit[i]) == false)
                        {
                            newList.Add(textSplit[i]);
                        }
                    }
                    var newArray = newList.ToArray();


                   
                    // New array is used without the duplicated values
                    Console.Write($"\nThe different numbers from the set of integers are: ");

                    for (int i = 0; i < newArray.Length; i++)Console.Write($"{newArray[i]}\t");

                }
                Footer();
            }
        }  
    }
}
