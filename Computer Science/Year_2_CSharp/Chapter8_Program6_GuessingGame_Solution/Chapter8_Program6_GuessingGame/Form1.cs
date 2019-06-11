using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program6_GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Random r = new Random();
        public static int target = r.Next(0, 101);
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Guess between 0 and 100!\nA blue button means you are too high!\nA green button means you are too low!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > 100) MessageBox.Show("That is too high", "On no", MessageBoxButtons.OK);
            else if (int.Parse(textBox1.Text) < 0) MessageBox.Show("That is too low", "On no", MessageBoxButtons.OK);
            else if(int.Parse(textBox1.Text) == target)
            {
                // Win Condition
                MessageBox.Show("You Won!", "Good Job", MessageBoxButtons.OK);
                Close();
            } else if (int.Parse(textBox1.Text) > target)
            {
                // Color change 1
                button1.BackColor = Color.LightBlue;
                
            } else
            {
                // Color change 2
                button1.BackColor = Color.LawnGreen;
            }
        }
    }
}
