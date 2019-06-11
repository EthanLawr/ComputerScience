using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program8_BinarySearch
{
    class Colors
    {
        public static void CyanFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void ErrorFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void PinkFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void YellowFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void GreenFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
