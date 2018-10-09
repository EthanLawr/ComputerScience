using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanH_BasicGame
{
    class DylanH_BasicGame
    {

        //Paint Program!
        public static class PlayerPosition
        {
            //These values can be changed anywhere without the need to return
            public static int playerX = 1;
            public static int playerY = 1;
            public static string currentColorVal = "9";
            public static string backgroundBoard = "";

            //Change these values to modify the canvas size
            public static int canvasSizeX = 32;
            public static int canvasSizeY = 16;
        }
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            GenerateBackBoard();
            InputMovement();

        }

        public static void InputMovement()
        {
            
            Console.SetWindowSize(120, 63);
            string input = "0";
            Console.Write("W-Up, A-Left, S-Down, D-Right"
        + "\t|\t X ={0} Y={1}", PlayerPosition.playerX
        , PlayerPosition.playerY);
            Console.Write("\n\n\n\n\n    0");
            ConsoleColor selected = ConsoleColor.Black;

            //Registers the input of the user
            do
            {

                ConsoleKeyInfo rawInput = Console.ReadKey(true);
                input = rawInput.Key.ToString();
                switch (input)
                {
                    #region movement
                    case "W":
                    case "w":
                        if (PlayerPosition.playerY != 1)
                        {
                            PlayerPosition.playerY--;
                        }
                        break;

                    case "A":
                    case "a":
                        if (PlayerPosition.playerX != 1)
                        {
                            PlayerPosition.playerX--;
                        }
                        break;

                    case "S":
                    case "s":
                        if (PlayerPosition.playerY != PlayerPosition.canvasSizeY)
                        {
                            PlayerPosition.playerY++;
                        }

                        break;

                    case "D":
                    case "d":
                        if (PlayerPosition.playerX != PlayerPosition.canvasSizeX)
                        {
                            PlayerPosition.playerX++;
                        }

                        break;
                    #endregion


                    //Quits the program
                    case "Q":
                    case "q":
                        Environment.Exit(0);
                        break;
                    #region ColorSelection
                    case "D1":
                        selected = ConsoleColor.Red;
                        PlayerPosition.currentColorVal = "1";
                        break;
                    case "D2":
                        selected = ConsoleColor.Blue;
                        PlayerPosition.currentColorVal = "2";
                        break;
                    case "D3":
                        selected = ConsoleColor.Yellow;
                        PlayerPosition.currentColorVal = "3";
                        break;
                    case "D4":
                        selected = ConsoleColor.Green;
                        PlayerPosition.currentColorVal = "4";
                        break;
                    case "D5":
                        selected = ConsoleColor.Magenta;
                        PlayerPosition.currentColorVal = "5";
                        break;
                    case "D6":
                        selected = ConsoleColor.Cyan;
                        PlayerPosition.currentColorVal = "6";
                        break;
                    case "D7":
                        PlayerPosition.currentColorVal = "7";
                        selected = ConsoleColor.DarkMagenta;
                        break;
                    case "D8":
                        PlayerPosition.currentColorVal = "8";
                        selected = ConsoleColor.DarkYellow;
                        break;
                    case "D9":
                        PlayerPosition.currentColorVal = "9";
                        selected = ConsoleColor.Black;
                        break;
                    case "D0":
                        PlayerPosition.currentColorVal = "0";
                        selected = ConsoleColor.White;
                        break;
                    #endregion
                    //Tells the program to place the selected color
                    case "E":
                    case "e":
                        PlaceColor();
                        break;
                    //Clears the canvas
                    case "C":
                    case "c":
                        GenerateBackBoard();

                        break;
                }
                RenderCanvas(selected);
            } while (input != "Q" && input != "q");
        }
        public static void RenderCanvas(ConsoleColor x)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("W-Up, A-Left, S-Down, D-Right, "
                +"E- Place Pixel, C-Clear, Q-Quit"
                + "\t|\t X ={0} Y={1}\n\n", PlayerPosition.playerX
                , PlayerPosition.playerY);
            switch (PlayerPosition.currentColorVal)
            {
                case "1":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Red\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "2":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Blue\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "3":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Yellow\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "4":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Green\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "5":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Magenta\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "6":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Cyan\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "7":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Dark Magenta\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "8":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Dark Yellow\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "9":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: Black\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "0":
                    Console.ForegroundColor = x;
                    Console.Write("\t\t Current Color: White\n\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            ReadBackBoard();

            Console.Write("\n\n\tColors:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\t[1] = Red");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t\t[2] = Blue");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t[3] = Yellow");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t[4] = Green");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n\t[5] = Magenta");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t[6] = Cyan");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\n\t[7] = Dark Magenta");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t[8] = Dark Yellow");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\t[9] = Black");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\t[0] = White");
        }
        //Work on placing colored tiles
        public static void PlaceColor()
        {
            //Places the number that corresponds to the selected color 
            //on the backboard, also doubles as a clear method
            int locationOfSelector = 0;
            for (int i = 0; i < PlayerPosition.playerY; i++)
            {
                locationOfSelector = locationOfSelector + 
                    (PlayerPosition.canvasSizeX);
            }
            for (int i = 0; i < PlayerPosition.playerX; i++)
            {
                locationOfSelector++;
            }
            locationOfSelector = locationOfSelector - 
                (PlayerPosition.canvasSizeX + 1);
            PlayerPosition.backgroundBoard =
                PlayerPosition.backgroundBoard.Remove(locationOfSelector, 1);
            PlayerPosition.backgroundBoard =
                PlayerPosition.backgroundBoard.Insert(locationOfSelector,
                PlayerPosition.currentColorVal);
            Console.Clear();
            DisplayBackBoard();
        }
        public static void GenerateBackBoard()
        {
            //Creates a canvas with the given 
            string backBoard = "";
            for (int i = 0; i < (PlayerPosition.canvasSizeY * 
                PlayerPosition.canvasSizeX); i++)
            {

                backBoard = backBoard + "0";



            }
            PlayerPosition.backgroundBoard = backBoard;
        }
        public static void DisplayBackBoard()
        {
            //Shows the blackboard, testing purposes
            string displayBackBoard = PlayerPosition.backgroundBoard;
            int posOfSpacer;
            for (int i = 0; i < PlayerPosition.canvasSizeY; i++)
            {
                posOfSpacer = i * (PlayerPosition.canvasSizeY + 1);
                displayBackBoard = displayBackBoard.Insert(posOfSpacer, "\n");
            }
            Console.WriteLine(displayBackBoard);
        }
        public static void ReadBackBoard()
        {
            //Replaces corresponding numbers in the backboard with blank spaces
            //of the color they represent
            int cursorPos = 0;
            for (int i = 0; i < PlayerPosition.playerY; i++)
            {
                cursorPos = cursorPos + (PlayerPosition.canvasSizeX);
            }
            for (int i = 0; i < PlayerPosition.playerX; i++)
            {
                cursorPos++;
            }
            cursorPos = cursorPos - (PlayerPosition.canvasSizeX + 1);

            //Places the colors by copying the backboard and then reading it,
            //removing each read character from the string
            string interpretBackBoard = PlayerPosition.backgroundBoard;
            int count = 0;
            for (int i = 0; i < PlayerPosition.canvasSizeY; i++)
            {
                for (int j = 0; j < PlayerPosition.canvasSizeX; j++)
                {
                    if (count != cursorPos)
                    {


                        if (interpretBackBoard.StartsWith("1") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);

                        }

                        else if (interpretBackBoard.StartsWith("2") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("3") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("4") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("5") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("6") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("7") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("8") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("9") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("0") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }
                    }
                    else
                    {
                        if (interpretBackBoard.StartsWith("1") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);

                        }

                        else if (interpretBackBoard.StartsWith("2") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("3") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("4") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("5") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("6") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("7") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("8") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("9") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }

                        else if (interpretBackBoard.StartsWith("0") == true
                        && string.IsNullOrEmpty(interpretBackBoard) != true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("0");
                            interpretBackBoard = interpretBackBoard.Remove(0, 1);
                        }
                    }
                    count++;
                    

                }
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("\n\t");
            }
            Console.BackgroundColor = ConsoleColor.Gray;

        }
    }
}
