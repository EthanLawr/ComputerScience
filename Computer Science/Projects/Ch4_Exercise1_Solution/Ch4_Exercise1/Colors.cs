using System;


namespace Ch4_Exercise1
{
    class Colors
    {
        public static void CyanFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void MagentaFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void YellowFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
