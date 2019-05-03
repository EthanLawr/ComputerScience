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
        Food[] food = new Food[0];
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
            for (int f = 0; f < fishes.Length; f++) {
                int[] hunger = fishes[f].GetHunger();
                fishes[f].Swim(timer1);
                if (hunger[0] > hunger[1])
                {
                    fishes[f].Dispose();
                    RemoveAt(ref fishes, f);
                    i--;
                }
            }
        }
        public static void RemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++) arr[a] = arr[a + 1];
            // moving elements downwards, to fill the gap at [index]
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref fishes, fishes.Length + 1);
            fishes[i] = new Fish(10,10);
            Controls.Add(fishes[i]);  //each picturebox created must be added to the form
            i++;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
