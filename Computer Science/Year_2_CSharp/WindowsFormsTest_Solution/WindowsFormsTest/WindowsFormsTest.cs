using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    static class WindowsFormsTest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += $"\t{i}\t{Math.Pow(i, 2)}\n";
            }
            Console.WriteLine(result);

            var newBox = MessageBox.Show(result, "Squares from one to ten", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            while (newBox == DialogResult.Yes)
            {
                
                newBox = MessageBox.Show(result, "Squares from one to ten", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                Console.WriteLine($"Okay, here have anotha one my boio: {result}");

            }
            Console.ReadLine();


            /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); */


        }
    }
}
