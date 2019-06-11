using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTopics_Program1_Uppercase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Changes the actual text
            label1.Text = Uppercase(textBox1.Text);
            label4.Text = Lowercase(textBox1.Text);
        }

        public static string Uppercase(string x)
        {
            string y = "";
            x.ToCharArray();
            foreach(char s in x)
            {
                // Checks if already uppercase
                if (Convert.ToInt32(s) - 32 >= 65 && Convert.ToInt32(s) - 32 <= 90)
                    y += Convert.ToChar((Convert.ToInt32(s) - 32));
                else y += s;
            }
            return y;
        }

        public static string Lowercase(string x)
        {
            string y = "";
            x.ToCharArray();
            foreach (char s in x)
            {
                // Checks if already lowercase
                if (Convert.ToInt32(s) + 32 >= 97 && Convert.ToInt32(s) + 32 <= 122)
                    y += Convert.ToChar((Convert.ToInt32(s) + 32));
                else y += s;
            }
            return y;
        }
    }
}
