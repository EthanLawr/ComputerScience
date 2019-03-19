using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultipleTopics_SortingUsingref_Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"H:\Comp 2\projects\MultipleTopics_SortingUsingref_Program1_Solution\MultipleTopics_SortingUsingref_Program1\data.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line;
                    while ((line = sr.ReadLine()) != null) label1.Text += line + '\n';
                }
            }
            catch (IOException f)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(f.Message);
            }

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"H:\Comp 2\projects\MultipleTopics_SortingUsingref_Program1_Solution\MultipleTopics_SortingUsingref_Program1\wordData.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line;
                    int lineCount = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineCount++;
                        if (lineCount == 1) label2.Text += line + "\n";
                        else if (lineCount == 2) label3.Text += line + "\n";
                        else if (lineCount == 3)
                        {
                            label4.Text += line + "\n";
                            lineCount = 0;
                        }


                    }
                }
            }
            catch (IOException f)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(f.Message);
            }
        }

        public static void BubbleSorter(ref int x, ref int y)
        {
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }

        public static void BubbleSorterString(ref string x, ref string y)
        {
            if (string.Compare(x, y) > 0)
            {
                string temp = x;
                x = y;
                y = temp;
            }
        }
        public static void BubbleSorterHelper(int[] array)
        {
            // Used to keep code above clean.
            // This uses an array and reassigns each value using the bubble sorting method. It can work with an array of any usable size
            for (int z = 0; z != array.Length; z++) for (int i = 0; i < array.Length - 1; i++) BubbleSorter(ref array[i], ref array[i + 1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"H:\Comp 2\projects\MultipleTopics_SortingUsingref_Program1_Solution\MultipleTopics_SortingUsingref_Program1\data.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] newArray = line.Split(' ');
                        int[] intArray = new int[3];
                        for (int i = 0; i < intArray.Length; i++) intArray[i] = int.Parse(newArray[i]);
                        BubbleSorterHelper(intArray);
                        foreach (int x in intArray) label1.Text += x + " ";
                        label1.Text += '\n';
                    }
                }
            }
            catch (IOException f)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(f.Message);
            }

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"H:\Comp 2\projects\MultipleTopics_SortingUsingref_Program1_Solution\MultipleTopics_SortingUsingref_Program1\wordData.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line;
                    int lineCount = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] newArray = line.Split(' ');
                        BubbleSorterString(ref newArray[0], ref newArray[1]);
                        BubbleSorterString(ref newArray[1], ref newArray[2]);
                        lineCount++;
                        if (lineCount == 1)
                        {
                            foreach (string x in newArray) label2.Text += x + " ";
                            label2.Text += "\n";
                        }
                        if (lineCount == 2)
                        {
                            foreach (string x in newArray) label3.Text += x + " ";
                            label3.Text += "\n";
                        }
                        if (lineCount == 3)
                        {
                            foreach (string x in newArray) label4.Text += x + " ";
                            label4.Text += "\n";
                            lineCount = 0;
                        }


                    }
                }
            }
            catch (IOException f)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(f.Message);
            }
        }
    }
}
