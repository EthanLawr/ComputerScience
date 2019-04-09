using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fish_Aquarium_Project
{
    public partial class Form1 : Form
    {
        public Random r = new Random();
        int i = 0;
        //Timer t;
        Fish[] fishes = new Fish[0];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            TopMost = true;  //makes fish show over other programs

            Size = Screen.PrimaryScreen.Bounds.Size + (new Size(20, 20));
            Location = new Point(0, 0);
            FormBorderStyle = FormBorderStyle.None; //also necessary so no borders will be shown
            BackColor = Color.Black;
            TransparencyKey = Color.Black; //mandatory, it makes black color transparent (won't be shown)


            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 40;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Fish s in fishes)
            {
                s.Swim();
            }
            /* if (i >= 40)  //if we go over 40 fish 
             {
                 timer1.Stop();  // Stops making new fish
                 return;
             }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref fishes, fishes.Length + 1);
            fishes[i] = new Fish(10,10);
            Controls.Add(fishes[i]);  //each picturebox created must be added to the form
            i++;

        }
        private void CallToChildThread()
        {

              //each picturebox created must be added to the form
        }
    }
}
