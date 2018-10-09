using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace WindowsFormsFinalProject
{
    public partial class First_Page : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public First_Page()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void First_Page_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            double c = 0;
            string Answer1 = "Hersheys";
            string userq1 = boxQ1.Text;
            if (userq1 == Answer1)
            {
                c++;
            }

            string Answer2 = "Quail Man";
            string userq2 = boxQ2.Text;
            if (userq2 == Answer2)
            {
                c++;
            }

            string Answer3 = "Country";
            string userq3 = boxQ3.Text;
            if (userq3 == Answer3)
            {
                c++;
            }
            string Answer4 = "YooHoo";
            string userq4 = boxQ4.Text;
            if (userq4 == Answer4)
            {
                c++;
            }
            string Answer5 = "Nora";
            string userq5 = boxQ5.Text;
            if (userq5 == Answer5)
            {
                c++;
            }
            string Answer6 = "Daniel";
            string userq6 = boxQ6.Text;
            if (userq6 == Answer6)
            {
                c++;
            }
            string Answer7 = "6'6";
            string userq7 = boxQ7.Text;
            if (userq7 == Answer7)
            {
                c++;
            }
            string Answer8 = "Blue";
            string userq8 = boxQ8.Text;
            if (userq8 == Answer8)
            {
              

                c++;
            }
            string Answer9 = "John";
            string userq9 = boxQ9.Text;
            if (userq9 == Answer9)
            {
                c++;
            }
            string Answer10 = "Hoosiers";
            string userq10 = boxQ10.Text;
            if (userq10 == Answer10)
            {
                c++;
            }
            string Answer11 = "Catholic";
            string userq11 = boxQ11.Text;
            if (userq11 == Answer11)
            {
                c++;
            }
            string Answer12 = "Irish";
            string userq12 = boxQ12.Text;
            if (userq12 == Answer12)
            {
                c++;
            }
            string Answer13 = ("June");
           
            string userq13 = boxQ13.Text;
            if (userq13 == Answer13)
            {
                c++;
            }
            string Answer14 = "Tottenham Hotspurs";
            string userq14 = boxQ14.Text;
            if (userq14 == Answer14)
            {
                c++;
            }
            string Answer15 = "Nissan Altima";
            string userq15 = boxQ15.Text;
            if (userq15 == Answer15)
            {
                c++;
            }
            double score = c / 15;
            double percent = score * 100;
            
            MessageBox.Show(string.Format("You are {0:F2}% Like Lynch", percent));
             synth.SetOutputToDefaultAudioDevice(); 
            synth.Speak("Knuckle Head!");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void boxQ10_TextChanged(object sender, EventArgs e)
        {


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void boxQ14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void boxQ13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void boxQ11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void boxQ9_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ8_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ7_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ6_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ5_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ4_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ3_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ2_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxQ15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
