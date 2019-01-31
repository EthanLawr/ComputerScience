using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program3_Bases
{
    class Chapter7_Program3_Bases : TaskShortener
    {
        static void Main(string[] args)
        {
            Header();
            Console.WriteLine("10\t8\t16\t2\n\n");

            for (int i = 1; i <= 35; i++)
            {
                int numberBinary = i, numberOctal = i, numberHex = i;
                int remainderBinary, remainderOctal;
                string resultBinary = "", resultOctal = "", resultHex = "";



                // Octal
                while (numberOctal > 0)
                {
                    remainderOctal = numberOctal % 8;
                    numberOctal /= 8;
                    resultOctal = remainderOctal.ToString() + resultOctal;
                }
                Console.Write($"{i}\t{resultOctal}");

                // Hexadecimal
                resultHex = hexConversion(numberHex);
                Console.Write($"\t{resultHex}");

                // Binary
                while (numberBinary > 0)
                {
                    remainderBinary = numberBinary % 2;
                    numberBinary /= 2;
                    resultBinary = remainderBinary.ToString() + resultBinary;
                }
                Console.WriteLine($"\t{resultBinary}");

            }
            Footer();

        }
        public static string hexConversion(int x)
        {
            string hexString = "";
            while (x > 0)
            {
                switch (x % 16)
                {
                    case 0:
                        hexString += "0";
                        break;
                    case 1:
                        hexString += "1";
                        break;
                    case 2:
                        hexString += "2";
                        break;
                    case 3:
                        hexString += "3";
                        break;
                    case 4:
                        hexString += "4";
                        break;
                    case 5:
                        hexString += "5";
                        break;
                    case 6:
                        hexString += "6";
                        break;
                    case 7:
                        hexString += "7";
                        break;
                    case 8:
                        hexString += "8";
                        break;
                    case 9:
                        hexString += "9";
                        break;
                    case 10:
                        hexString += "a";
                        break;
                    case 11:
                        hexString += "b";
                        break;
                    case 12:
                        hexString += "c";
                        break;
                    case 13:
                        hexString += "d";
                        break;
                    case 14:
                        hexString += "e";
                        break;
                    case 15:
                        hexString += "f";
                        break;
                }
                x /= 16;

            }
            return Reverse(hexString);

        }
        public static string Reverse(string s)
        {
            // Reversing hex strings to be right
            char[] magicArray = s.ToCharArray();
            Array.Reverse(magicArray);
            return new string(magicArray);
        }
    }
}
