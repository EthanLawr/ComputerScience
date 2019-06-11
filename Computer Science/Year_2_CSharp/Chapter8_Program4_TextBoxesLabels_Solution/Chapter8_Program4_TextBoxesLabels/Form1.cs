using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program4_TextBoxesLabels
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") { }// do nothing
            else
                // Button click to add a name
                // += used too allow for multiple names
                label4.Text += textBox3.Text + " " + textBox1.Text + " " + textBox2.Text + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Text Reset
            label4.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }
    }
}
