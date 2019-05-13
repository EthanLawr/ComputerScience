using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fish_Aquarium_Project
{

    class Food : PictureBox
    {
        private int speed, direction;
        private PictureBox FoodPic;//you'll do this instead of a label
        private Random randy = new Random();

        public Food(int x, int y)
        {

            Location = new Point(x + randy.Next(0, 1000), y + randy.Next(0, 300));

            FoodPic = new PictureBox();
            int s = randy.Next(1, 20);
            Size = new Size(20 + s, 20 + s);

            speed = s / 5;
            if (speed < 1) speed = 1;
            direction = randy.Next(1, 3);
            if (direction == 2) direction = -1;
            Image = Properties.Resources.shroom;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
        }

        public int[] GetLocation()
        {
            return new int[] { Location.X, Location.Y };
        }

        public int FoodWorth()
        {
            return Size.Height * 5;
        }

        public bool Fall(Timer timmy, ref Food[] FoodArray, ref int FoodArrayLength)
        {
            Location = new Point(Location.X+direction, Location.Y+speed);
            if (Location.X > 1280 || Location.Y > 1000 || Location.X < 0-Size.Width)
            {
                return false;
            }
            return true;
                
        }
    }
}
