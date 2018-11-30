using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace Chapter7_Program1_CountingNumbers
{
    class Chapter7_Program1_CountingNumbers : TaskShortener
    {
        public static string filePath = @"H:\Comp 2\projects\Chapter7_Program1_CountingNumbers_Solution\Chapter7_Program1_CountingNumbers\TextFile1.txt";
        static void Main(string[] args)
        {
            Header();
            using (StreamReader superReads = File.OpenText(filePath))
            {
                string textString;
                int Low = 0, High = 0, Equal = 0;
                while ((textString = superReads.ReadLine()) != null)
                {
                    string[] textSplit = textString.Split(',');
                    for (int i = 0; i < textSplit.Length; i++)
                    {
                        if (int.Parse(textSplit[i]) > 500) High++;
                        else if (int.Parse(textSplit[i]) < 500) Low++;
                        else if (int.Parse(textSplit[i]) == 500) Equal++;
                        else { Console.Write("Excuse me what happened"); break; }
                        
                        Console.Write($"{textSplit[i]}\t");
                    }
                }
                Console.WriteLine($"\n{High} numbers are higher than 500\n{Low} numbers are lower than 500\n{Equal} numbers are equal to 500");
            }
            Footer();
        }
    }
}
