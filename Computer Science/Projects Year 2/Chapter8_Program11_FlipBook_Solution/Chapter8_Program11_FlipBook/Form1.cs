using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program11_FlipBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m += 30;
            if (m > 2100)
            {
                // Resets the timer to loop the newly made "gif"
                pictureBox1.Image = Properties.Resources.pixil_frame_0;
                m = 0;
            }
            // Animates the pngs
            else if (m > 2000) pictureBox1.Image = Properties.Resources.pixil_frame_20;
            else if (m > 1900) pictureBox1.Image = Properties.Resources.pixil_frame_19;
            else if (m > 1800) pictureBox1.Image = Properties.Resources.pixil_frame_18;
            else if (m > 1700) pictureBox1.Image = Properties.Resources.pixil_frame_17;
            else if (m > 1600) pictureBox1.Image = Properties.Resources.pixil_frame_16;
            else if (m > 1500) pictureBox1.Image = Properties.Resources.pixil_frame_15;
            else if (m > 1400) pictureBox1.Image = Properties.Resources.pixil_frame_14;
            else if (m > 1300) pictureBox1.Image = Properties.Resources.pixil_frame_13;
            else if (m > 1200) pictureBox1.Image = Properties.Resources.pixil_frame_12;
            else if (m > 1100) pictureBox1.Image = Properties.Resources.pixil_frame_11;
            else if (m > 1000) pictureBox1.Image = Properties.Resources.pixil_frame_10;
            else if (m > 900) pictureBox1.Image = Properties.Resources.pixil_frame_9;
            else if (m > 800) pictureBox1.Image = Properties.Resources.pixil_frame_8;
            else if (m > 700) pictureBox1.Image = Properties.Resources.pixil_frame_7;
            else if (m > 600) pictureBox1.Image = Properties.Resources.pixil_frame_6;
            else if (m > 500) pictureBox1.Image = Properties.Resources.pixil_frame_5;
            else if (m > 400) pictureBox1.Image = Properties.Resources.pixil_frame_4;
            else if (m > 300) pictureBox1.Image = Properties.Resources.pixil_frame_3;
            else if (m > 200) pictureBox1.Image = Properties.Resources.pixil_frame_2;
            else if (m > 100) pictureBox1.Image = Properties.Resources.pixil_frame_1;


        }
        private static int m = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the animation is going already
            if (timer1.Enabled == true) MessageBox.Show("The animation has already started!");
            else timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the animation is already going
            if (timer1.Enabled == false) MessageBox.Show("Please start the animation first!");
            else timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Checks if the program is reset
            if (timer1.Enabled == false && pictureBox1.Image == Properties.Resources.pixil_frame_0) MessageBox.Show("This is already reset!");
            else
            {
                // Resets the program
                timer1.Stop();
                pictureBox1.Image = Properties.Resources.pixil_frame_0;
                m = 0;
            }
        }
    }
}
