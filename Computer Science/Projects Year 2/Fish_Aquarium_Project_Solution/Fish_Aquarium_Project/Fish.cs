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
    class Fish : PictureBox
    {
        //Global Fish Variables
        private int x, y;//help with locating the fish
        private Size fishSize;
        //private Label fishLabel;
        private Point location, velocity, acceleration;
        private PictureBox fishPic;//you'll do this instead of a label
        private Random randy = new Random();
        private int hunger;
        //?? food
        //?? weight

        public Fish(int x, int y)//constructor with 2 parameters
        {
            this.x = x;
            this.y = y;

            location = new Point(x, y);
            

            hunger = randy.Next(1, 101);//set hunger to a random
                                        //number between 1 and 100

            int s = randy.Next(1, 100);
            fishPic = new PictureBox();
            Size = new Size(100 + s, 100 + s);
            Location = new Point(10,10 + s);
            BackgroundImage = Properties.Resources.image0;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImageLayout = ImageLayout.Stretch;

        }
        public PictureBox GetFishPic()//Accessor Method 
        {
            return fishPic;
        }

        public void Swim()
        {
            hunger++;
            //if (hunger > 85)
            //{
                //Changes the color of the fish if the get too hungry
            //}
            if (true)//always "turned on" right now
            {
                x += 2;//moves the fish to the right 2
                y += 2;//moves the fish down 2
            }

            Location = new Point(x, y);
            //To see where I instantiate the fish
            //fishLabel.Text = "Position: (" + x + "," + y + ")" + "\nHunger: " + hunger;
            //eventually, maybe display random location variable

            //We'll need to figure out how to move our labels
            Top = y;
            Left = x;
        }

    }
}
