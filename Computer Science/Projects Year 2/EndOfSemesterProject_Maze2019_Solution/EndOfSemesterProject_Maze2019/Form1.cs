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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            End.BringToFront();
            radioButton3.BringToFront();
            panel9.BringToFront();
            panel11.SendToBack();
            panel10.BringToFront();
            panel13.SendToBack();
            panel8.SendToBack();
            timer1.Tick += new EventHandler(TimerEventProcessor);
            timer1.Start();
        }
        private static readonly Random getrandom = new Random();
        private static int something = 0;
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
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            Cursor.Position = new Point(50, 50);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            panel10.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            label1.Text = "0";
            timer1.Start();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            
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
            panel6.Visible = false;
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
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            panel10.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            label1.Text = "0";
            timer1.Start();
        }
    }
}
