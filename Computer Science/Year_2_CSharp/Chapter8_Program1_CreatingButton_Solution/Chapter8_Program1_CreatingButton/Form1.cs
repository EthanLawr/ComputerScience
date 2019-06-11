using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program1_CreatingButton
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
            // Oh cool a message box 
            MessageBox.Show(textBox1.Text, "Here's your favorite saying :b:o:i:!", MessageBoxButtons.OK);
            // Oh cool the form closes
            Close();
            // Knucklehead level 100
        }
    }
}
