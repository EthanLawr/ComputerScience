using Clog = System.Console;
using Colour = System.ConsoleColor;

namespace Ch4_Program2.ChapterFour
{
    public class Colors
    {
        public static void CyanFont()
        {
            Clog.ResetColor();
            Clog.ForegroundColor = Colour.Cyan;
        }

        public static void MagentaFont()
        {
            Clog.ResetColor();
            Clog.ForegroundColor = Colour.Magenta;
        }

        public static void YellowFont()
        {
            Clog.ResetColor();
            Clog.ForegroundColor = Colour.Yellow;
        }
    }
}
