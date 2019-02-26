using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chapter8_Program8_Slotz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;


        }
        private static Random myRandom = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            // Checks if there are tokens left
            if (timer1.Enabled == true)
            {
                // Do nothing
            }
            else if (int.Parse(label5.Text) - 1 < 0) MessageBox.Show("You have no more tokens!");
            else
            {
                // Removes a token
                label5.Text = (int.Parse(label5.Text) - 1).ToString();
                // Starts slots 
                label7.ForeColor = Color.Black;
                label7.BringToFront();
                timer3.Enabled = true;
                timer1.Enabled = true;
                
            }
                

        }
        private static int m = 0, l = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
                m += 10;
                l += 10;
                if (m <= 100)
                {
                    // "Animation" and end value
                    label1.Text = myRandom.Next(1, 4).ToString();
                    label2.Text = myRandom.Next(1, 4).ToString();
                    label3.Text = myRandom.Next(1, 4).ToString();
                }
                else if (m <= 120) m = 0;

                while (l >= 350)
                {
                    timer1.Stop();
                    if (int.Parse(label1.Text) == int.Parse(label2.Text) && int.Parse(label2.Text) == int.Parse(label3.Text) && 
                        int.Parse(label1.Text) == int.Parse(label3.Text))
                    {
                        // Starts +8 counter
                        label6.BringToFront();
                        timer2.Start();
                        label4.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                        label5.Text = (int.Parse(label5.Text) + 8).ToString();                        
                        MessageBox.Show("You Won!", "Good job! You won 8 tokens!", MessageBoxButtons.OK);
                    }
                    m = 0;
                    l = 0;
                    timer1.Enabled = false;
                    break;
                }
            
            


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 10;
            label6.ForeColor = Color.FromArgb(label6.ForeColor.R + fadingSpeed, label6.ForeColor.G + fadingSpeed, label6.ForeColor.B + fadingSpeed);
            if (label6.ForeColor.R >= BackColor.R)
            {
                timer2.Stop();
                label6.ForeColor = BackColor;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 10;
            label7.ForeColor = Color.FromArgb(label7.ForeColor.R + fadingSpeed, label7.ForeColor.G + fadingSpeed, label7.ForeColor.B + fadingSpeed);
            if (label7.ForeColor.R >= BackColor.R)
            {
                timer3.Enabled = false;
                label7.ForeColor = BackColor;
            }
        }


    }
}
