using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace Chapter7_Program2_CarSalesman
{
    class Chapter7_Program2_CarSalesman : TaskShortener
    {
        public static string filePath = @"H:\Comp 2\projects\Chapter7_Program2_CarSalesman_Solution\Chapter7_Program2_CarSalesman\TextFile1.txt";
        static void Main(string[] args)
        {
            Header();
            // Using the StreamReader class and File Class 
            using (StreamReader superReads = File.OpenText(filePath))
            {
                string textString;
                // Settings frequency values
                double lowest = 0, smaller = 0, small = 0, slightlySmaller = 0, medium = 0, slightlyHigher = 0, high = 0, higher = 0, highest = 0;
                while ((textString = superReads.ReadLine()) != null)
                {
                    // Making an array of the text file contents
                    string[] textSplit = textString.Split(' ');
                    for (int i = 0; i < textSplit.Length; i++)
                    {
                        // Formatting the text file contents
                        double salesGain = (int.Parse(textSplit[i]) * 0.09) + 200;

                        // Comparing the sales in ranges of cash
                        if (salesGain > 200 && salesGain < 299) lowest++;
                        else if (salesGain > 300 && salesGain < 399) smaller++;
                        else if (salesGain > 400 && salesGain < 499) small++;
                        else if (salesGain > 500 && salesGain < 599) slightlySmaller++;
                        else if (salesGain > 600 && salesGain < 699) medium++;
                        else if (salesGain > 700 && salesGain < 799) slightlyHigher++;
                        else if (salesGain > 800 && salesGain < 899) high++;
                        else if (salesGain > 900 && salesGain < 999) higher++;
                        else if (salesGain > 1000 && salesGain < 1099) highest++;
                    }
                }

                // Display
                Console.WriteLine($"Salary\t\tFrequency\n$200  - $299\t{lowest}\n$300  - $399\t{smaller}\n$400  - $499\t{small}\n$500  - $599\t{slightlySmaller}" +
                    $"\n$600  - $699\t{medium}\n$700  - $799\t{slightlyHigher}\n$800  - $899\t{high}\n$900  - $999\t{higher}\n$1000 - $1099\t{highest}");
            }
            Footer();
        }
    }
}
