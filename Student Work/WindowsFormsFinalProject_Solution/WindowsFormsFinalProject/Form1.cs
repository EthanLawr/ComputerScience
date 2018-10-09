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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer synth = new SpeechSynthesizer(); 
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void START_Click(object sender, EventArgs e)
        {
 synth.SetOutputToDefaultAudioDevice(); 
            synth.Speak("Knuckle Head!");

            First_Page open = new First_Page();
            open.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
