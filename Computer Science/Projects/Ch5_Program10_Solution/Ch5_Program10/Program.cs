using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program10
{
    class Program : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(TetrisSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {


                    Header();

                    #region Important Code
                    string set1 = AskUserForString("Enter 1 letter or number"), 
                        set2 = AskUserForString("Enter 1 letter or number"), 
                        set3 = AskUserForString("Enter 1 letter or number"), 
                        set4 = AskUserForString("Enter 1 letter or number"), 
                        set5 = AskUserForString("Enter 1 letter or number"), 
                        set6 = AskUserForString("Enter 1 letter or number"), 
                        set7 = AskUserForString("Enter 1 letter or number"),
                        set8 = AskUserForString("Enter 1 letter or number"),
                        set9 = AskUserForString("Enter 1 letter or number");
                    //
                    //result = result.Insert(3, " - ").Insert(9, " - ");
                    //Console.WriteLine(result); 
                    Loading();
                    string number1 = SwitchMethod(set1), number2 = SwitchMethod(set2), 
                        number3 = SwitchMethod(set3),number4 = SwitchMethod(set4), 
                        number5 = SwitchMethod(set5), number6 = SwitchMethod(set6),
                        number7 = SwitchMethod(set7), number8 = SwitchMethod(set8), 
                        number9 = SwitchMethod(set9);
                    string phoneNumber = number1 + number2 + number3 + number4 + 
                        number5 + number6 + number7 + number8 + number9;
                    string result = new string(phoneNumber.Where(ch => char.IsDigit(ch)).ToArray());
                    result = result.Insert(1, "(").Insert(4, ")").Insert(9, " - ");
                    Console.WriteLine(result);
                    #endregion

                    Footer();
                    break;
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    ErrorCatch();
                }
                #endregion
            }
        }
        public static string SwitchMethod(string x)
        {
            string letter = x.ToLower();
            string y = "*";
            switch (letter)
            {
                case "0":
                    y = letter.Replace(letter, "0");
                    break;
                case "1":
                    y = letter.Replace(letter, "1"); ;
                    break;
                case "a":
                case "b":
                case "c":
                case "2":
                    y = letter.Replace(letter, "2"); ;
                    break;

                case "d":
                case "e":
                case "f":
                case "3":
                    y = letter.Replace(letter, "3");
                    break;

                case "g":
                case "h":
                case "i":
                case "4":
                    y = letter.Replace(letter, "4");
                    break;

                case "j":
                case "k":
                case "l":
                case "5":
                    y = letter.Replace(letter, "5");
                    break;

                case "m":
                case "n":
                case "o":
                case "6":
                    y = letter.Replace(letter, "6");
                    break;

                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                    y = letter.Replace(letter, "7");
                    break;


                case "t":
                case "u":
                case "v":
                case "8":
                    y = letter.Replace(letter, "8");
                    break;

                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                    y = letter.Replace(letter, "9");
                    break;
                default:
                    Console.WriteLine("knucklehead, not a letter");
                    Console.WriteLine("an '*' will show up");
                    break;
                    //used cases, next will use to.lower
                    //Lynch helped

            }
            return y;


        }

    }
}