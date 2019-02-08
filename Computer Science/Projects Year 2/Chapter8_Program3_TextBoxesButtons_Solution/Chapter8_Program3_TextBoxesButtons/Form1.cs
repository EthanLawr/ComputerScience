﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program3_TextBoxesButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Parsing used for addition
            label3.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parsing used for multiplication

            label3.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
            label3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Keeps label invisible so as to not confuse the user
            label3.Visible = false;
        }
    }
}
