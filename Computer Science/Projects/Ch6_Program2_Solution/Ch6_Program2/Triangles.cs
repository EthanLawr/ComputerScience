using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch6_Program2
{
    class Triangles : TaskShortener
    {
        static void Main()
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    Header();

                    #region Important Code
                    for (int a = 0; a > -1;)
                    {
                        GreenFont();
                        Console.WriteLine("\nPlease enter -1 to end this program\n");
                        int sideOne = AskUserForInt("one side of a triangle"); //Asks for a side of a triangle
                        sideOne = NegativeCheckOne(sideOne);
                        #region Cancellation 1
                        if (sideOne == -1) //Breaks the loop if you enter that number
                        {
                            ErrorFont();
                            Console.WriteLine("You cancelled the program.");
                            break;
                        }
                        
                        #endregion
                        int sideTwo = AskUserForInt("a second side of a triangle"); //Asks for a side of a triangle
                        sideTwo = NegativeCheckTwo(sideTwo);
                        #region Cancellation 2
                        if (sideTwo == -1) //Breaks the loop if you enter that number
                        {
                            ErrorFont();
                            Console.WriteLine("You cancelled the program.");
                            break;
                        }
                        while (sideTwo < -1) sideTwo = AskUserForInt("a second side of a triangle");
                        #endregion
                        int sideThree = AskUserForInt("a third side of a triangle"); //Asks for a side of a triangle
                        sideThree = NegativeCheckThree(sideThree); //Makes sure you can cancel at any point
                        #region Cancellation 3 
                        if (sideThree == -1) //Breaks the loop if you enter that number
                        {
                            ErrorFont();
                            Console.WriteLine("You cancelled the program.");
                            break;
                        }
                        while (sideThree < -1) sideThree = AskUserForInt("a third side of a triangle");
                        #endregion
                        PythagoreanTest(sideOne, sideTwo, sideThree); //Tests the triangle
                        
                    }

                    #endregion
                    i = 100;
                    Footer();
                    
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    ErrorFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.");
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
                    Console.Clear();
                }
                #endregion
            }
        }
        internal static int NegativeCheckOne(int x)
        {
            while (x < -1) x = AskUserForInt("one side of a triangle");
            return x;
        }
        internal static int NegativeCheckTwo(int x)
        {
            while (x < -1) x = AskUserForInt("a second side of a triangle");
            return x;
        }
        internal static int NegativeCheckThree(int x)
        {
            while (x < -1) x = AskUserForInt("a third side of a triangle");
            return x;
        }
        internal static void PythagoreanTest(int x, int y, int z)
        {
            double hypotenuse = x; //Default values
            double smallerSides = y + z;
            #region Equality and comparisons
            if (z == x && z == y && x == y) //Sets them as an equilateral triangle
                Console.WriteLine("They are all equal!");
            else if (x > z && x > y) //Sets x as the hypotenuse
            {
                hypotenuse = Math.Pow(x, 2);
                smallerSides = Math.Pow(y, 2) + Math.Pow(z, 2);
            }
            else if (y > z && y > x) //Sets y as the hypotenuse
            {
                hypotenuse = Math.Pow(y, 2);
                smallerSides = Math.Pow(x, 2) + Math.Pow(z, 2);
            }
            else if (z > x && z > y) //Sets z as the hypotenuse
            {
                hypotenuse = Math.Pow(z, 2);
                smallerSides = Math.Pow(y, 2) + Math.Pow(x, 2);
            }
            #endregion

            if (smallerSides < hypotenuse) //Validates the triangle
                Console.WriteLine("This is not a valid triangle!");
            else Console.WriteLine("This is a valid triangle!");

        }
    }
}
