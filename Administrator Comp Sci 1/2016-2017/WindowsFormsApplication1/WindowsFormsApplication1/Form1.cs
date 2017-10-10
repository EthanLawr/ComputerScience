using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string String = "string";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DisplayLabel.Text = "Text";
            DisplayLabel.Visible = false;
            MessageBox.Show(String);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayLabel.Visible = false;  
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DisplayLabel.Text);
            //MyTextBox.Text = "Saved";
            DisplayLabel.Text = MyTextBox.Text;
            DisplayLabel.Visible = true;
        }
    }
}
