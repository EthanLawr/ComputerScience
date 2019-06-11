using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program2_SwitchingForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form 2", "Form2", MessageBoxButtons.OK);

        }

        internal void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // New form class
            Form1 f2 = new Form1();
            f2.Show();
            // Hides the old form
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Stops the applicaiton
            Close();
            Application.Exit();
        }
    }
}
