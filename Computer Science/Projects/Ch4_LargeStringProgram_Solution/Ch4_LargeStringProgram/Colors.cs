using System;
using Colorful;
using Console = System.Console;
using CConsole = Colorful.Console;
using System.Drawing;
namespace Ch4_LargeStringProgram
{
    internal class Colors
    {
        internal static void CyanFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.LightSkyBlue;
        }

        internal static void RedFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.Tomato;
        }

        internal static void PinkFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.HotPink;
        }

        internal static void YellowFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.Wheat;
        }

        internal static void GreenFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.SpringGreen;
        }
        internal static void GradientWriteSunset(string x)
        {
            CConsole.WriteWithGradient(x, Color.Yellow, Color.Fuchsia, 15);
            Console.ResetColor();
        }
    }
}