using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program9_TheDiner
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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            // Formatted like this for organization and a constant flow of steady updates to the cost
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label9.Text = "Burger";
            label12.Text = "$1.49";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label9.Text = "Hotdog";
            label12.Text = "$0.99";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
            checkBox4.Checked = false;
            label9.Text = "Chicken";
            label12.Text = "$1.85";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = true;
            label9.Text = "Soup and Salad";
            label12.Text = "$2.02";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            label10.Text = "Water";
            label13.Text = "$0.00";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox6.Checked = true;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            label10.Text = "Coke";
            label13.Text = "$1.00";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = true;
            checkBox8.Checked = false;
            label10.Text = "OJ";
            label13.Text = "$1.55";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = true;
            label10.Text = "Sprite";
            label13.Text = "$1.00";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            checkBox9.Checked = true;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            label11.Text = "Ice Cream";
            label14.Text = "$1.50";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            checkBox10.Checked = true;
            checkBox11.Checked = false;
            label11.Text = "Cake";
            label14.Text = "$2.10";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = true;
            label11.Text = "Nothing";
            label14.Text = "$0.00";
            label15.Text = "$" + (trimAndParse(label12.Text) + trimAndParse(label13.Text) + trimAndParse(label14.Text)).ToString("F");
        }

        private void label15_TextChanged(object sender, EventArgs e)
        {
            // When the subtotal is changed everything else changes too.
            label20.Text = "$" + (trimAndParse(label15.Text) * 0.06).ToString("F");
            label21.Text = "$" + (trimAndParse(label15.Text) * 0.15).ToString("F");
            label22.Text = "$" + (trimAndParse(label20.Text) + trimAndParse(label15.Text)).ToString("F");
            label24.Text = "$" + (trimAndParse(label20.Text) + trimAndParse(label21.Text) + trimAndParse(label15.Text)).ToString("F");
        }

        internal static double trimAndParse(string x)
        {
            // Helps with coding speed on the program
            return double.Parse(x.TrimStart('$'));
        }

    }
}
