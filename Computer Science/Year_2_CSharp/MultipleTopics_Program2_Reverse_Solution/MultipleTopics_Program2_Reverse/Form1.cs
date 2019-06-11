using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTopics_Program2_Reverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Reverse text
            label1.Text = Reverse(textBox1.Text);

            // Checks for palindromes
            if (label1.Text == Reverse(label1.Text)) label2.Visible = true;
            else label2.Visible = false;
        }

        public static string Reverse(string s)
        {
            // Using char arrays to switch out letter placements
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
