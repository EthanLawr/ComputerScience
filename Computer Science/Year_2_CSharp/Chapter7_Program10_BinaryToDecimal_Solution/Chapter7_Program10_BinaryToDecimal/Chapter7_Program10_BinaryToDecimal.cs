using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program10_BinaryToDecimal
{
    class Chapter7_Program10_BinaryToDecimal:TaskShortener
    {
        static void Main(string[] args)
        {
            Header();
            char[] array = AskUserForString("a binary number").ToCharArray();
            Array.Reverse(array);
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0) sum += 1;
                    else sum += (int)Math.Pow(2, i);
                }
            }
            Console.WriteLine(sum);
            Footer();
        }
    }
}
