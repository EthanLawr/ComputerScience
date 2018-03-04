using System;

namespace Ch4_LargeStringProgram
{
    internal class Colors
    {
        internal static void CyanFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan;
        }

        internal static void RedFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red;
        }

        internal static void MagentaFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Magenta;
        }

        internal static void YellowFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Yellow;
        }

        internal static void LimeFont()
        {
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
