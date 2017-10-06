using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBetweenForms
{
    public partial class Form1 : Form
    {
        public string firstName; //This needs to be declared
        //inside the class outside the events
        //need to declare it as public
        public string lastName; // Last Name
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text; //takes whatever was typed in        
            //the textbox from form 1 and saves it as the string "firstname"
            lastName = textBox2.Text; //This takes the second textbox
            //in Form1 and saves it as the last name
            Form Form2 = new Form2(); //this instantiates Form2
            Form2.Show(); //This will show Form2
            this.Hide(); //This hides Form1
            Form2.Text = firstName + " " + lastName; //Really important
            //This stores the variable firstName from Form1 and joins it
            //with the lastName from From1 but saves it 
            //as the name "Text" in Form2
        }
    }
}
