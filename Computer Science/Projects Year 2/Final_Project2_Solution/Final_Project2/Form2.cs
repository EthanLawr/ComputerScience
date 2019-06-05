using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Encryption.AutoEncrypt();
            textBox2.Text = Encryption.LastEncryption;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Encryption.DecryptTest(textBox1.Text)) MessageBox.Show("Please enter a valid save file");
                else
                {
                    // ??
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Encryption.LastEncryption;
        }
    }
}
