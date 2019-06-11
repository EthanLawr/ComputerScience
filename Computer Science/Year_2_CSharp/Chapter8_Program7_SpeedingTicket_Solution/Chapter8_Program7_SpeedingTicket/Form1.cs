using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program7_SpeedingTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "Speed Limit Was:\nTicked Speed Was:\nMPH Over Speed Limit:";
            label5.Text = "";
            label7.Text = "Initial Tick Cost:\nAdditional Charges:\nExtra Charges Or Discounts:\nTotal Fine";
            label6.Text = "75.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure its a legal speeding ticket!
            try
            {
                if (int.Parse(textBox2.Text) - int.Parse(textBox1.Text) <= 0) textBox1.Text = "Error";
                int.Parse(textBox1.Text);
                int.Parse(textBox2.Text);
            }
            catch (Exception f)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                MessageBox.Show("Please enter a valid set of numbers for the text boxes.", "Error", MessageBoxButtons.OK);
            }

            // Setting proper values
            string totalMPHOver = (int.Parse(textBox2.Text) - int.Parse(textBox1.Text)).ToString();
            int MphOverCounter = 0, studentSpeed = int.Parse(textBox2.Text), originalSpeed = int.Parse(textBox1.Text);
            double originalPrice = 75, changedPrice = 0, discountPrice = 0;
            label5.Text = IntParse(textBox1.Text) + "\n" + IntParse(textBox2.Text) + "\n" + totalMPHOver;

            //Miles Per House price Addition
            while (int.Parse(totalMPHOver) >= 5)
            {
                MphOverCounter++;
                totalMPHOver = (int.Parse(totalMPHOver) - 5).ToString();
            }
            while (MphOverCounter >= 1)
            {
                MphOverCounter--;
                originalPrice += 87.50;
                changedPrice += 87.50;
            }
            
            // Senior Extra Price
            if (radioButton4.Checked)
            {
                if (studentSpeed >= originalSpeed + 20)
                {
                    originalPrice += 150;
                    changedPrice += 150;
                }
                originalPrice += 50;
                changedPrice += 50;
            }

            // Freshmen and Sophomore
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (studentSpeed <= originalSpeed + 20)
                {
                    originalPrice -= 50;
                    discountPrice -= 50;
                }
            }

            // Freshmen, Sophomore, Junior
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (studentSpeed >= originalSpeed + 20)
                {
                    originalPrice += 100;
                    changedPrice += 100;
                }
            }


            label6.Text = "$75.00\n$" + changedPrice.ToString() + "\n$" + discountPrice + "\n$" + originalPrice;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox1.Text);
                int.Parse(textBox2.Text);
            } catch (Exception f)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                MessageBox.Show("Please enter a valid number for the text boxes.", "Error", MessageBoxButtons.OK);
            }
        }

        private static string IntParse(string x)
        {
            return int.Parse(x).ToString();
        }

    }
}
