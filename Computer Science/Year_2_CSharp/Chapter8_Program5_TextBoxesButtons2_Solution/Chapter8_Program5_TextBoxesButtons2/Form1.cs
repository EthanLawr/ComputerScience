using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program5_TextBoxesButtons2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Keeps the box visible inside the monitor
            if(int.Parse(textBox1.Text) > 1000 || int.Parse(textBox1.Text) < 0 || int.Parse(textBox2.Text) > 1000 || int.Parse(textBox2.Text) < 0)
            {
                // Do nothing
            } else
            // Changes location
            Location = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}
