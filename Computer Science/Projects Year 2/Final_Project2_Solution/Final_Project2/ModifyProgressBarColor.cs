using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final_Project2
{
    public static class ModifyProgressBarColor
    {
        // Imports the data needed to be able to change the progress bars color
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            // Sets the value of the bar's color (red yellow green if i recall correctly are all valid options)
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
