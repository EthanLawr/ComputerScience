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
        private Point end, acceleration;
        private bool followingFood = false;
        private int hunger, hungerMax;
        private double radius = 0, angle = 0;
        private Food followedFood;
        //?? food
        //?? weight
        private int speed_left = 4, speed_top = 4, orig_Speed_Left = 4, orig_Speed_Top = 4;
        public Fish(int x, int y)//constructor with 2 parameters
        {
            
            Location = new Point(x + randy.Next(-10, 500), y + randy.Next(-10, 600));
            this.x = Location.X;
            this.y = Location.Y;
            end = new Point(randy.Next(10, 1280), randy.Next(10, 1080));
            int direction, direction2;
            if (end.X > x) direction = 1;
            else direction = -1;
            if (end.Y > y) direction2 = 1;
            else direction2 = -1;
            if (direction == 0) direction = 1;
            if (direction2 == 0) direction2 = 1;
            int s = randy.Next(1, 100);
            fishPic = new PictureBox();
            Size = new Size(100 + s, 100 + s);
            hunger = randy.Next(1, 101);//set hunger to a random number between 1 and 100
            hungerMax = Size.Height * 10;
            speed_left = s / 10 * direction;
            speed_top = s / 10 * direction;
            if (speed_left == 0) speed_left = 1;
            if (speed_top == 0) speed_top = 1;
            orig_Speed_Left = speed_left;
            orig_Speed_Top = speed_top;

            Image = Properties.Resources.image0;
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.StretchImage;
            radius = Math.Sqrt(Math.Pow(Math.Abs(end.X - Left), 2) + Math.Pow(Math.Abs(end.Y - Top), 2));
        }
        public int[] GetHunger()
        {
            return new int[] { hunger, hungerMax };
        }
        public PictureBox GetFishPic()//Accessor Method 
        {
            return fishPic;
        }

        public void Swim(Timer timer1, ref Food[] FoodArray, ref int FoodArrayLength)
        {
            hunger++;
            if (FoodArray.Length > 0 && !FoodArray.Contains(followedFood))
            {
                Point[] foodDistanceArray = new Point[FoodArray.Length];
                int[] foodDistanceArray2 = new int[FoodArray.Length];
                int minValue = 1000;
                Point ClosestFood = new Point(0,0);
                Func<Point, Point, int> getLength = (p1, p2) => (int)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)); // C^2 = A^2 + B^2

                for (int f = 0; f < FoodArray.Length; f++)
                {
                    foodDistanceArray[f] = new Point(FoodArray[f].GetLocation()[0], FoodArray[f].GetLocation()[1]);
                    foodDistanceArray2[f] = getLength(foodDistanceArray[f], Location);
                }
                for (int f = 0; f < foodDistanceArray2.Length; f++)
                {
                    if (minValue > foodDistanceArray2[f])
                    {
                        minValue = foodDistanceArray2[f];
                        end = foodDistanceArray[f];
                        followingFood = true;
                        followedFood = FoodArray[f];
                        
                    }
                }
                if (Left < ClosestFood.X) speed_left = orig_Speed_Left;
                else if (Right > ClosestFood.X) speed_left = -orig_Speed_Left;
                if (Top < ClosestFood.Y) speed_top = orig_Speed_Top;
                else if (Bottom > ClosestFood.Y) speed_top = -orig_Speed_Top;
                Left += speed_left;     //move the fish
                Top += speed_top;
            } else
            {
                Rectangle s = Rectangle(fishPic);
                if (s.Contains(end))
                {

                    if (followingFood == true && !followedFood.Disposing && s.Contains(followedFood.GetLocation()[0], followedFood.GetLocation()[1]))
                    {
                        hunger = 0;
                        followedFood.Dispose();
                        RemoveAt(ref FoodArray, Array.IndexOf(FoodArray, followedFood));
                        FoodArrayLength--;
                        followingFood = false;
                    }
                    end = new Point(randy.Next(10, 1280), randy.Next(10, 1024));
                    if (end.X > Location.X)
                    {
                        Image = Properties.Resources.image0;
                        Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    if (end.X < Location.X) Image = Properties.Resources.image0;
                    angle = 0;
                    radius = Math.Sqrt(Math.Pow(Math.Abs(end.X - Left), 2) + Math.Pow(Math.Abs(end.Y - Top), 2));
                }
                //Math.Pow(Math.Pow(Math.Abs(location.X - Left), 2) + Math.Pow(Math.Abs(location.Y - Top), 2), 0.1);
                //Console.WriteLine("X: " + Math.Abs(location.X - Left).ToString() + " Y: " + Math.Abs(location.Y - Top).ToString());
                Console.WriteLine(Math.Sqrt(Math.Pow(Math.Abs(end.X - Left), 2) + Math.Pow(Math.Abs(end.Y - Top), 2)).ToString());
                //if (Left <= end.X && Left + Width >= end.X)  speed_left = 0;
                if (Left < end.X) speed_left = orig_Speed_Left;
                else if (Right > end.X) speed_left = -orig_Speed_Left;
                //if (Top <= end.Y && Top + Height >= end.Y) speed_top = 0;
                if (Top < end.Y) speed_top = orig_Speed_Top;
                else if (Bottom > end.Y) speed_top = -orig_Speed_Top; //*/
                                                                      //CircularTween();
                Left += speed_left;     //move the fish
                Top += speed_top;
            }
            

           
            
        }
        /*public void CircularTween()
        {
            //angle += Math.Sqrt(Math.Pow(Math.Abs(end.X - Left), 2) + Math.Pow(Math.Abs(end.Y - Top), 2))/360.0;
            //Left = x -end.X ;
            //Left = (int)(Math.Abs(Left - end.X) + Math.Cos(hunger) * randy.Next(1, 101));
            //Top = (int)(Math.Abs(Top - end.Y) + Math.Sin(hunger) * randy.Next(1, 101));
            //Top = (int)(Math.Cos(angle / 180.0 * Math.PI) + Top);
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

        public static void RemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++) arr[a] = arr[a + 1];
            // moving elements downwards, to fill the gap at [index]
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);

        }
    }
}
