using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTopics_Program4_Distribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MakeHistogram(Label[] labels, int[] values)
        {
            // Calculate a scale so the largest
            // value fits nicely on the form.
            int available_height = labels[0].Bottom - 5;
            int max = values.Max();
            float scale = available_height / (float)max;

            for (int i = 0; i < labels.Length; i++)
            {
                int height = (int)(scale * values[i]);
                labels[i].Top = labels[i].Bottom - height;
                labels[i].Height = height;
                labels[i].Text = values[i].ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make an array to hold counts for values
            // between 2 and 12 with indexes between 0 and 10.
            int[] counts = new int[11];

            Random rand = new Random();
            for (int i = 0; i < 55000; i++)
            {
                int new_value = rand.Next(1, 7) + rand.Next(1, 7);
                int index = new_value - 2;
                counts[index]++;
            }

            Label[] labels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11 };
            MakeHistogram(labels, counts);
        }
    }
}
