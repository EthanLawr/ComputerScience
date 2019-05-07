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
        private int x, y;//help with locating the food
        private PictureBox FoodPic;//you'll do this instead of a label
        private Random randy = new Random();

        public Food(int x, int y)
        {

            Location = new Point(x + randy.Next(0, 1000), y + randy.Next(0, 300));
            this.x = Location.X;
            this.y = Location.Y;
           
            FoodPic = new PictureBox();
            Size = new Size(30, 30);
            Image = Properties.Resources.shroom;
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int[] GetLocation()
        {
            return new int[] { x, y };
        }
    }
}
