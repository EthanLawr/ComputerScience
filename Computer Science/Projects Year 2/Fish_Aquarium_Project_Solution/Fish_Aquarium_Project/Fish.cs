using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fish_Aquarium_Project
{
    class Fish : PictureBox
    {
        //Global Fish Variables
        private int x, y;//help with locating the fish
        private Size fishSize;
        //private Label fishLabel;
        private PictureBox fishPic;//you'll do this instead of a label
        private Random randy = new Random();
        private Point location, velocity, acceleration;
        private int hunger;
        private float deltaTime = 0.0f;
        private float angle = 0;
        private float speed;
        private float radius = 30.0f; // radius of the circle (used for circular tweens)
        //?? food
        //?? weight
        private int speed_left = 4, speed_top = 4, orig_Speed_Left = 4, orig_Speed_Top = 4;
        private double a = 0;
        private int direction = 0;
        public Fish(int x, int y)//constructor with 2 parameters
        {
          

            hunger = randy.Next(1, 101);//set hunger to a random
                                        //number between 1 and 100
            int direction = randy.Next(-1, 2);
            int direction2 = randy.Next(-1, 2);
            if (direction == 0) direction = 1;
            if (direction2 == 0) direction = 1;
            int s = randy.Next(1, 100);
            fishPic = new PictureBox();
            Size = new Size(100 + s, 100 + s);
            speed_left = s / 10 * direction;
            speed_top = s / 10 * direction;
            if (speed_left == 0) speed_left = 1;
            if (speed_top == 0) speed_top = 1;
            orig_Speed_Left = speed_left;
            orig_Speed_Top = speed_left;
            speed = s / 10 * direction;
            if (speed == 0) speed = 1;
            Location = new Point(10 + randy.Next(-10, 500), 10 + randy.Next(-10, 600));
            this.x = Location.X;
            this.y = Location.Y;
            Image = Properties.Resources.image0;
            BackColor = Color.Transparent;
            location = new Point(randy.Next(10, Screen.PrimaryScreen.Bounds.Size.Height-100), randy.Next(10, Screen.PrimaryScreen.Bounds.Size.Width));
            SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public PictureBox GetFishPic()//Accessor Method 
        {
            return fishPic;
        }

        public void Swim(Timer timer1)
        {
            hunger++;
            //if (hunger > 85)
            //{
            //Changes the color of the fish if the get too hungry
            //}
            /*if (true)//always "turned on" right now
            {
                x += 2;//moves the fish to the right 2
                y += 2;//moves the fish down 2
            }*/
            //Left += speed_left;     //move the fish
            //Top += speed_top;
            Rectangle s = Rectangle(fishPic);
            if (s.Contains(location))
            {
                location = new Point(randy.Next(10, Screen.PrimaryScreen.Bounds.Size.Width), randy.Next(10, Screen.PrimaryScreen.Bounds.Size.Height - 20));
                if (location.X > Location.X)
                {
                    Image = Properties.Resources.image0;
                    Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                if (location.X < Location.X) Image = Properties.Resources.image0;
                angle = 0;
                deltaTime = 1;
                radius = Math.powMath.Abs(location.X - x) + location.Y - (x + y));
            }
            if (s.Left <= location.X && s.Left + s.Width >= location.X)  speed_left = 0;
            else if (Left < location.X) speed_left = orig_Speed_Left;
            else if (Right > location.X) speed_left = -orig_Speed_Left;
            if (s.Top <= location.Y && s.Top + s.Height >= location.Y) speed_top = 0;
            else if (Top < location.Y) speed_top = orig_Speed_Top;
            else if (Bottom > location.Y) speed_top = -orig_Speed_Top;
            deltaTime += 1;
            CircularTween();
        }

        public void CircularTween()
        {
            angle += speed * deltaTime;
            Left = (int)(Math.Cos(angle) * radius + Left);
            Top = (int)(Math.Sin(angle) * radius + Top);
        }
        /*private string CorrectExifOrientation()
        {
            
            var rotateFlip = RotateFlipType.RotateNoneFlipNone;
            return Encoding.UTF8.GetString(Image.PropertyItems[1].Value);
            /*switch (orientation)
            {
                case 1: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
                case 2: rotateFlip = RotateFlipType.RotateNoneFlipX; break;
                case 3: rotateFlip = RotateFlipType.Rotate180FlipNone; break;
                case 4: rotateFlip = RotateFlipType.Rotate180FlipX; break;
                case 5: rotateFlip = RotateFlipType.Rotate90FlipX; break;
                case 6: rotateFlip = RotateFlipType.Rotate90FlipNone; break;
                case 7: rotateFlip = RotateFlipType.Rotate270FlipX; break;
                case 8: rotateFlip = RotateFlipType.Rotate270FlipNone; break;
                default: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
            }
            //return rotateFlip;
        }*/
        private Rectangle Rectangle(PictureBox pictureBox)
        {
            return new Rectangle(
                Location.X-orig_Speed_Left,
                Location.Y-orig_Speed_Top,
                Width+orig_Speed_Left,
                Height+orig_Speed_Top
            );
        }
        //Location = new Point(x, y);
        //To see where I instantiate the fish
        //fishLabel.Text = "Position: (" + x + "," + y + ")" + "\nHunger: " + hunger;
        //eventually, maybe display random location variable

        //We'll need to figure out how to move our labels
        //Top = y;
        //Left = x;
        protected override void OnPaintBackground(PaintEventArgs e)
        // Paint background with underlying graphics from other controls
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;

            if (Parent != null)
            {
                // Take each control in turn
                int index = Parent.Controls.GetChildIndex(this);
                for (int i = Parent.Controls.Count - 1; i > index; i--)
                {
                    Control c = Parent.Controls[i];

                    // Check it's visible and overlaps this control
                    if (c.Bounds.IntersectsWith(Bounds) && c.Visible)
                    {
                        // Load appearance of underlying control and redraw it on this background
                        Bitmap bmp = new Bitmap(c.Width, c.Height, g);
                        c.DrawToBitmap(bmp, c.ClientRectangle);
                        g.TranslateTransform(c.Left - Left, c.Top - Top);
                        g.DrawImageUnscaled(bmp, Point.Empty);
                        g.TranslateTransform(Left - c.Left, Top - c.Top);
                        bmp.Dispose();
                    }
                }
            }
        }
    }
}
