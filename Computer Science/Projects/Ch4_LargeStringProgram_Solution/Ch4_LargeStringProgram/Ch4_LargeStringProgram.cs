using System;

namespace Ch4_LargeStringProgram
{
    class Ch4_LargeStringProgram : Colors
    {
        static void Main(string[] args)
        {
            TaskShortener.ConsoleChangeSize(); //Changes the console size... duh
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    TaskShortener.Header();

                    #region String Questions
                    //Asks you to enter whatever strings you want
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
                    #endregion

                    //Many refs so that theres only really one method, no outs needed!
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
            #region Variables
            char[] charsToTrim = { '*', ' ' }; //Chars that are filtered out
            string trimOnceFormatting = (v.Trim(charsToTrim)), //Good ol trimming!
                trimTwiceFormatting = w.Remove(y.IndexOf('*'), y.LastIndexOf('*')), //Removal
                trimThriceFormatting = x + ',', //Comma!
                trimFourceFormatting = y.Replace('*', ' '), //Replacement
                trimFiceFormatting = z.ToLower(); //Lowercase!
            #endregion

            #region Display
            Console.WriteLine(trimOnceFormatting);
            Console.WriteLine(trimTwiceFormatting);
            Console.WriteLine(trimThriceFormatting);
            Console.WriteLine(trimFourceFormatting);
            Console.WriteLine(trimFiceFormatting);
            #endregion
        }
    }
}
