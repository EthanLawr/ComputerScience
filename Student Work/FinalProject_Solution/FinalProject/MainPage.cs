using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class MainPage : Form
    {
        private string m_user;
        private Form m_form;

        public MainPage(string UserName, Form theStartPage)
        {
            InitializeComponent();
            m_user = UserName; // set the user name for the main page from the start page
            m_form = theStartPage;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Refesh the page for first time in case there is already text in the file
            MainPage_Refresh();
        }

        private void MainPage_Refresh()
        {
            ChatroomClass mainpageChat = new ChatroomClass();//initialize class
            List<string> newLines = ChatroomClass.Reader();//define array using class

            DisplayBox.Clear(); // remove any old text since reading from file

            DisplayBox.Lines = newLines.ToArray(); //display array from file
        }

        private void Send_Click(object sender, EventArgs e)
        {
            ChatroomClass mainpageChat = new ChatroomClass();//initialize class
            List <string> newLines = ChatroomClass.Reader();//define array using class

            DisplayBox.Text =  String.Join(Environment.NewLine, newLines);//display array 
            DisplayBox.Lines = newLines.ToArray();
            //TextWriter txt = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\Donnelly Final Project\\ChatroomLog.txt");//write to text file
            StreamWriter txtFile = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\Donnelly Final Project\\ChatroomLog.txt", append: true);//write to text file with APPEND!!!
            // string docuText = "\n" + newLines + MessageSender.Text;//compile sent text to one string
            txtFile.WriteLine(m_user + ": " + MessageSender.Text);
            // txtFile.Write(docuText);//write the text to the file
            txtFile.Close();//close text file

            MainPage_Refresh(); // refresh the page each time SEND is clicked
            MessageSender.Clear();
        }

        private void MessageSender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Click(this, new EventArgs());
            }
        }

        private void Smile_Click(object sender, EventArgs e)
        {
            // send a smiley to the text box and handle the event
            MessageSender.Text = ":)";
            Send_Click(sender, e);

        }

        private void Frown_Click(object sender, EventArgs e)
        {
            // send a sad smiley to the text box and handle the event
            MessageSender.Text = ":(";
            Send_Click(sender, e);
        }

        private void Heart_Click(object sender, EventArgs e)
        {
            // send a heart to the text box and handle the event
            MessageSender.Text = "<3";
            Send_Click(sender, e);
        }

        private void BrokenHeart_Click(object sender, EventArgs e)
        {
            // send a broken heart to the text box and handle the event
            MessageSender.Text = "</3";
            Send_Click(sender, e);
        }

        private void Poop_Click(object sender, EventArgs e)
        {
            // send a poop to the text box and handle the event
            MessageSender.Text = "~8~";
            Send_Click(sender, e);
        }

        private void Laugh_Click(object sender, EventArgs e)
        {
            // send an LOL to the text box and handle the event
            MessageSender.Text = "XD";
            Send_Click(sender, e);
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // close this form
            m_form.Close(); // close the start page
        }
    }
}
