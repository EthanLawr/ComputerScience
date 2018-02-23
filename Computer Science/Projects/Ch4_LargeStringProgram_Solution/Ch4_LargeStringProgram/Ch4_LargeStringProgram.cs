using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_LargeStringProgram
{
    class Ch4_LargeStringProgram : Colors
    {
        static void Main(string[] args)
        {
            TaskShortener.ConsoleChangeSize();
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    TaskShortener.Header();

                    //Asks the amount of change you have
                    string trimMeOnce = TaskShortener.AskUserForString("String number "
                            + "1"),
                        trimMeTwice = TaskShortener.AskUserForString("String number "
                            + "2"),
                        trimMeThrice = TaskShortener.AskUserForString("String number "
                            + "3"),
                        trimMeFource = TaskShortener.AskUserForString("String number "
                            + "4"),
                        trimMeFice = TaskShortener.AskUserForString("String number "
                            + "5");
                    CharReplication(trimMeOnce, ref trimMeTwice, ref trimMeThrice, 
                        ref trimMeFource, ref trimMeFice);


                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }

        internal static void CharReplication(string v, ref string w, ref string x,
            ref string y, ref string z)
        {
            char[] charsToTrim = { '*', ' ' };
            string trimOnceFormatting = (v.Trim(charsToTrim)),
                trimTwiceFormatting = w.Remove(y.IndexOf('*'), y.LastIndexOf('*')),
                trimThriceFormatting = x + ',',
                trimFourceFormatting = y.Replace('*', ' '),
                trimFiceFormatting = z.ToLower();
            Console.WriteLine(trimOnceFormatting);
            Console.WriteLine(trimTwiceFormatting);
            Console.WriteLine(trimThriceFormatting);
            Console.WriteLine(trimFourceFormatting);
            Console.WriteLine(trimFiceFormatting);
        }
    }
}
