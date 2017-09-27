using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompSyedIsAKucklehead
{
    class CompSyedIsAKucklehead
    {
        static void Main(string[] args)
        {

#region In-Program Header
            Console.Title = "FinalProject_BrickBreaker";
            Console.WriteLine("\tAuthor: Syed Waseem");
            Console.WriteLine("\tTitle: FinalProject_BrickBreaker");
            Console.WriteLine("\tDate:05/06/2015\n");
            Console.WriteLine("\tThis program is meant to play brickbreaker.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
                +"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
#endregion 
            Console.SetWindowSize(80, 40);

            #region Brick Construction (Syed look here!)
            //A single brick conctruciton
            Console.SetCursorPosition(10, 10);
            Console.Write("-------");
            Console.SetCursorPosition(10, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(10, 12);
            Console.Write("-------");

            //Now for the rest of them! Just cut and paste!
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(18, 10);
            Console.Write("-------");
            Console.SetCursorPosition(18, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(18, 12);
            Console.Write("-------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(26, 10);
            Console.Write("-------");
            Console.SetCursorPosition(26, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(26, 12);
            Console.Write("-------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(34, 10);
            Console.Write("-------");
            Console.SetCursorPosition(34, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(34, 12);
            Console.Write("-------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(42, 10);
            Console.Write("-------");
            Console.SetCursorPosition(42, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(42, 12);
            Console.Write("-------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(50, 10);
            Console.Write("-------");
            Console.SetCursorPosition(50, 11);
            Console.Write("|     |");
            Console.SetCursorPosition(50, 12);
            Console.Write("-------");
            #endregion

            int x = 40;
            int y = 40;
            
            string a = "";

            #region Paddle
            for (int i = 0; i < 100; i--)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.LeftArrow)
                {
                    while (info.Key == ConsoleKey.LeftArrow)
                    {
                        x = x - 4;
                        if (x <= 0)
                        {
                            x = 0;
                        }
                        y = 40;
                        Console.SetCursorPosition(x, y);
                        info = Console.ReadKey();
                    }  
                }
                else
                {
                    while (info.Key == ConsoleKey.RightArrow)
                    {
                        x = x + 4;
                        if (x >= 80)
                        {
                            x = 80;
                        }
                        y = 40;
                        Console.SetCursorPosition(x, y);
                        info = Console.ReadKey();
                        
                    }    
                }
            }
            #endregion 

            
            

            if (true)
            {
                
            }

            Console.Read();
        }
        public static string Ball()
        {
            string ball = "*";
            return ball;
        }
        public static string Brick()
        {
            string brick = "|__|";
            return brick;
        }
    }
}

