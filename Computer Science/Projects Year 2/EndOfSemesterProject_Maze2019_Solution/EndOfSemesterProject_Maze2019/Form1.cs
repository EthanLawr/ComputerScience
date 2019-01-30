using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndOfSemesterProject_Maze2019
{
    public partial class Form1 : Form
    {
        private static readonly Random getrandom = new Random();
        private static int something = 0, something2 = 0, something3 = 0, something4;
        private static string checkPointTimer = "0";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            End.BringToFront();
            panel54.SendToBack();
            radioButton3.BringToFront();
            panel9.BringToFront();
            panel11.SendToBack();
            panel10.BringToFront();
            panel13.SendToBack();
            panel8.SendToBack();
            panel44.SendToBack();
            panel53.SendToBack();
            panel49.SendToBack();
            panel52.BringToFront();
            timer1.Tick += new EventHandler(TimerEventProcessor);
            timer1.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs myEventArgs)
        {
            timer1.Interval = 10;
            label1.Text = (double.Parse(label1.Text) + 0.01).ToString();

            if (panel8.Left < 100 && getrandom.Next(100) % 2 == 1) panel8.Left += 1;
            if (panel8.Left >= 100) panel8.Left = 0;

            if (panel11.Left < 100 && getrandom.Next(50) % 2 == 1) panel11.Left += 1;
            if (panel11.Left >= 100) panel11.Left = 0;

            if (panel10.Top < 210 && getrandom.Next(50) % 2 == 1) panel10.Top -= 1;
            if (panel10.Top <= 70) panel10.Top = 209;

            if (panel13.Left < 100 && something == 0) panel13.Left += 1;
            if (panel13.Left >= 100) something = 1;
            if (panel13.Left > 10 && getrandom.Next(50) % 2 == 1 && something == 1) panel13.Left -= 1;
            if (panel13.Left <= 10) something = 0;

            if (panel44.Left < 540 && something2 > 600) panel44.Left += 3;
            if (panel44.Left >= 540) something2 = 0;
            if (panel44.Left > 150 && getrandom.Next(50) % 2 == 1 && something2 == 0) panel44.Left -= 1;
            if (panel44.Left <= 150) something2++;

            if (panel49.Left < 1100 && something3 == 0) panel49.Left += 7;
            if (panel49.Left >= 1100) something3 = 1;
            if (panel49.Left > 100 && something3 == 1) panel49.Left -= 5;
            if (panel49.Left <= 100) something3 = 0;

            if (radioButton4.Checked)
            {
                if (getrandom.Next(100) % 3 == 1)
                {
                    Point mouse = PointToClient(MousePosition);
                    if (mouse.X > panel52.Location.X) panel52.Location = new Point(panel52.Location.X + 1, panel52.Location.Y);
                    if (mouse.X < panel52.Location.X) panel52.Location = new Point(panel52.Location.X - 1, panel52.Location.Y);
                    if (mouse.Y > panel52.Location.Y) panel52.Location = new Point(panel52.Location.X, panel52.Location.Y + 1);
                    if (mouse.Y < panel52.Location.Y) panel52.Location = new Point(panel52.Location.X, panel52.Location.Y - 1);

                    if (getrandom.Next(100) % 2 == 1) panel52.Size = new Size(panel52.Width -= getrandom.Next(4), panel52.Height -= getrandom.Next(4));
                    else panel52.Size = new Size(panel52.Width += getrandom.Next(4), panel52.Height += getrandom.Next(4));

                    if (panel52.Width < 5) panel52.Size = new Size(20, panel52.Height);
                    if (panel52.Height < 5) panel52.Size = new Size(panel52.Width, 20);
                    if (panel52.Width > 50) panel52.Size = new Size(20, panel52.Height);
                    if (panel52.Height > 50) panel52.Size = new Size(panel52.Width, 20);

                }
            }

            if (something4 > 160) panel54.Visible = false;
            if (something4 < 190) something4++;
            if (something4 == 190) something4 = 0; 
            if (something4 <= 20) panel54.Visible = true;
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            Cursor.Position = new Point(50, 50);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            panel10.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel44.Visible = false;
            panel49.Visible = false;
            panel52.Location = new Point(0,0);
            label1.Text = "0";
            timer1.Start();
        }

        private void panel44_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            checkPointTimer = ((double.Parse(label1.Text)) / 2).ToString();
            Cursor.Position = new Point(50, 50);
            radioButton4.Checked = true;
            panel10.Visible = true;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
            panel52.Location = new Point(-20, -20);
            label1.Text = checkPointTimer;
            timer1.Start();
        }

        private void End_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show($"Good job! You finished in {label1.Text} seconds!", "You won!", MessageBoxButtons.OK);
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = true;
            
            radioButton2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel9.Visible = true;
            radioButton1.Visible = false;
            radioButton3.Visible = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Visible = true;
            radioButton2.Visible = false;
            panel11.Visible = true;
            panel12.Visible = true;
            panel10.Visible = true;
            panel13.Visible = true;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            Cursor.Position = new Point(50, 50);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            panel10.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel44.Visible = false;
            panel49.Visible = false;
            panel52.Location = new Point(0, 0);
            label1.Text = "0";
            timer1.Start();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel6.Visible = false;
            radioButton3.Visible = false;
            panel44.Visible = true;
            panel49.Visible = true;
            panel52.Visible = true;
            panel52.Location = new Point(0, 0);
        }
    }
}
