using System;
using System.Windows.Forms;

namespace Chapter7_Program6_ProductArrays
{
    class Chapter7_Program6_ProductArrays : TaskShortener
    {
        static void Main(string[] args)
        {
            //Header();

            int[] arrayOne = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayTwo = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayThree = new int[10];
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayThree[i] = arrayOne[i] * arrayTwo[i];
            }
            MessageBox.Show($"{string.Join(",", arrayOne)}\n{string.Join(",", arrayTwo)}\n{string.Join(",", arrayThree)}\n", 
                "Array Products", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            //Footer();
        }
    }
}
