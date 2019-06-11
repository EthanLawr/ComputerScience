using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTopics_Program3_RollTheDie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Make sure numbers dont go over the limit of the label's max size and is a correct number for arrays
                if (int.Parse(textBox1.Text) > 157 || int.Parse(textBox1.Text) < 1) int.Parse("Error");
                int number = int.Parse(textBox1.Text);
                int[] myArray = new int[number];
                Fill(myArray, number);
                label2.Text = string.Join(" ", myArray);
            } catch (Exception f)
            {
                // Error catching
                MessageBox.Show("Please enter a valid number", "Alert!", MessageBoxButtons.OK);
                label2.Text = "Input string was not in the right format. Please use an integer under 158 and above 0!";
                textBox1.Text = "0";
            }
        }
        public void Fill(int[] originalArray, int with)
        {
            // Makes an array full of the numbers needed
            for (int i = 0; i < with; i++) originalArray[i] = i+1;
        }
        public Random randomGen = new Random();
        public int Roll(int[] originalArray)
        {
            return originalArray[randomGen.Next(originalArray.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Uses one number from the array and converts the array to an integer array
                string[] newArray = label2.Text.Split(' ');
                int[] intArray = new int[newArray.Length];
                for (int i = 0; i < newArray.Length; i++) intArray[i] = int.Parse(newArray[i]);
                label3.Text = Roll(intArray).ToString();
            } catch (Exception f)
            {
                // Error catching
                textBox1.Text = "0";
                MessageBox.Show("Please enter a valid number", "Alert!", MessageBoxButtons.OK);
                label2.Text = "Input string was not in the right format. Please use an integer under 158 and above 0!";
            }

        }
    }
}
