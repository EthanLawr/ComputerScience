using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program10_Thermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets max temp values
            vScrollBar1.Maximum = 1000;
            vScrollBar1.Minimum = -459;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = vScrollBar1.Value.ToString();
            label4.Text = ((vScrollBar1.Value - 32) * 5 / 9).ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Boiling
            vScrollBar1.Value = 212;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            // Checks for changed scroll values
            label3.Text = vScrollBar1.Value.ToString();
            label4.Text = ((vScrollBar1.Value - 32) * 5 / 9).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Freezing
            vScrollBar1.Value = 32;
        }
    }
}
