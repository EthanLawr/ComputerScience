using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program10
{
    class Program10 : TaskShortener
    {
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {

                    ConsoleChangeSize();
                    Header();

                    #region Important Code
                    string set1 = AskUserForString("1 letter or number"), //Asks for numbers/letters
                        set2 = AskUserForString("1 letter or number"), 
                        set3 = AskUserForString("1 letter or number"),
                        set4 = AskUserForString("1 letter or number"),
                        set5 = AskUserForString("1 letter or number"),
                        set6 = AskUserForString("1 letter or number"),
                        set7 = AskUserForString("1 letter or number"),
                        set8 = AskUserForString("1 letter or number"),
                        set9 = AskUserForString("1 letter or number"),
                        set10 = AskUserForString("1 letter or number");
                    //
                    //result = result.Insert(3, " - ").Insert(9, " - ");
                    //Console.WriteLine(result); 
                    Loading();
                    string number1 = SwitchMethod(set1), number2 = SwitchMethod(set2), //Sends values to method
                        number3 = SwitchMethod(set3),number4 = SwitchMethod(set4), 
                        number5 = SwitchMethod(set5), number6 = SwitchMethod(set6),
                        number7 = SwitchMethod(set7), number8 = SwitchMethod(set8), 
                        number9 = SwitchMethod(set9), number10 = SwitchMethod(set10);
                    PhoneFormat(number1, number2, number3, number4, number5, number6, 
                        number7, number8, number9, number10);
                    #endregion

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
        public static string SwitchMethod(string x)
        {
            string letter = x.ToLower(); //Faster checking
            string y = "0";
            switch (letter)
            {
                case "0":
                    y = letter.Replace(letter, "0"); //Returns 0
                    break;
                case "1":
                    y = letter.Replace(letter, "1"); //Returns 1
                    break;
                case "a":
                case "b":
                case "c":
                case "2":
                    y = letter.Replace(letter, "2"); //Returns 2
                    break;
                case "d":
                case "e":
                case "f":
                case "3":
                    y = letter.Replace(letter, "3"); //Returns 3
                    break;
                case "g":
                case "h":
                case "i":
                case "4":
                    y = letter.Replace(letter, "4"); //Returns 4
                    break;
                case "j":
                case "k":
                case "l":
                case "5":
                    y = letter.Replace(letter, "5"); //Returns 5
                    break;
                case "m":
                case "n":
                case "o":
                case "6":
                    y = letter.Replace(letter, "6"); //Returns 6
                    break;
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                    y = letter.Replace(letter, "7"); //Returns 7
                    break;
                case "t":
                case "u":
                case "v":
                case "8":
                    y = letter.Replace(letter, "8"); //Returns 8
                    break;
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                    y = letter.Replace(letter, "9"); //Returns 9
                    break;
                default:
                    y = letter.Replace(letter, "0"); //If invalid number make a 0!
                    break;
            }
            return y;


        }

        public static void PhoneFormat(string a, string b, string c, string d, string e, 
            string f, string g, string h, string i, string j)
        {
            string phoneNumber = a + b + c + d + e + f + g + h + i + j;
            //Puts the numbers into one string if its a digit
            string result = new string(phoneNumber.Where(ch => char.IsDigit(ch)).ToArray());
            //Edits the newly made string
            result = result.Insert(0, "(").Insert(4, ") ").Insert(9, " - ");
            Console.WriteLine(result);
        }
    }
}