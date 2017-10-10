using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string mystring = "string";
        public Form1()
        {
            InitializeComponent();
        }

        private void mytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mytextbox.Text = mystring;
            DisplayLabel.Visible = true;
            DisplayLabel.Text = mytextbox.Text;
            double mydouble = Convert.ToDouble(mytextbox.Text);
            double my2nddouble = Convert.ToDouble(MyTextbox2.Text);
            DisplayLabel.Text = "" + (mydouble * my2nddouble);
        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
