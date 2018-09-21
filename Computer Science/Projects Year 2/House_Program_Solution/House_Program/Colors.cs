using Console = System.Console;
using CConsole = Colorful.Console;
using System.Drawing;

// Install-Package Colorful.Console  -ProjectName House_Program
namespace House_Program
{
    class Colors
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
            Console.ResetColor(); CConsole.BackgroundColor = Color.CadetBlue; CConsole.ForegroundColor = Color.SpringGreen;
        }
        internal static void WhiteFont()
        {
            Console.ResetColor(); CConsole.BackgroundColor = Color.White; CConsole.ForegroundColor = Color.SandyBrown;
        }
        internal static void redDoor()
        {
            Console.ResetColor(); CConsole.BackgroundColor = Color.IndianRed; CConsole.ForegroundColor = Color.SandyBrown;
        }
        internal static void ErrorFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.Crimson;
        }
        internal static void BrownFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.SandyBrown;
        }
        internal static void skyFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.WhiteSmoke; CConsole.BackgroundColor = Color.CadetBlue;
        }
        internal static void skyHouseFont()
        {
            Console.ResetColor(); CConsole.ForegroundColor = Color.SandyBrown; CConsole.BackgroundColor = Color.CadetBlue;
        }

    }
}