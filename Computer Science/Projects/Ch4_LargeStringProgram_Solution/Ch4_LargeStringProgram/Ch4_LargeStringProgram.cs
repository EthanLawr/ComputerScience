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
                    
                    //Strings for later
                    #region String Questions
                    string trimMeOnce = " I pledge allegiance to the Flag ",
                        trimMeTwice = "of the *weather is nice*United States of America",
                        trimMeThrice = "and to the Republic for which it stands",
                        trimMeFource = "one *Na*tion under* God, indiv*isible,",
                        trimMeFice = "WITH LIBERTY AND JUSTICE FOR ALL.";
                    #endregion

                    //Strings after going through a method
                    #region Strings Formatted
                    CharTrimmer(trimMeOnce);
                    TaskShortener.Loading();

                    TaskShortener.SecondHeader();
                    CharRemoval(trimMeTwice);
                    TaskShortener.Loading();

                    TaskShortener.SecondHeader();
                    CharOperations(trimMeThrice);
                    TaskShortener.Loading();

                    TaskShortener.SecondHeader();
                    CharReplacement(trimMeFource);
                    TaskShortener.Loading();

                    TaskShortener.SecondHeader();
                    CharLowerCasing(trimMeFice);
                    #endregion

                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }

        internal static void CharTrimmer(string x)
        {
            #region Variables
            char[] charsToTrim = { '*', ' ' }; //Chars that are filtered out
            string trimOnceFormatting = x.Trim(charsToTrim); //Good ol trimming!
            #endregion

            #region Display
            RedFont(); //Fonts!
            Console.WriteLine(trimOnceFormatting);
            #endregion
        }

        internal static void CharRemoval(string x)
        {
            string trimTwiceFormatting = x.Remove(x.IndexOf('*'), x.LastIndexOf('*') - 6); //Removal

            #region Display
            RedFont(); //Fonts!
            Console.WriteLine(trimTwiceFormatting);
            #endregion
        }

        internal static void CharOperations(string x)
        {
            string trimThriceFormatting = x + ','; //Comma!

            #region Display
            RedFont(); //Fonts!
            Console.WriteLine(trimThriceFormatting);
            #endregion
        }

        internal static void CharReplacement(string x)
        {
            string trimFourceFormatting = x.Replace('*', ' '); //Replacement

            #region Display
            RedFont(); //Fonts!
            Console.WriteLine(trimFourceFormatting);
            #endregion
        }

        internal static void CharLowerCasing(string x)
        {
            string trimFiceFormatting = x.ToLower(); //Lowercase!*/

            #region Display
            RedFont(); //Fonts!
            Console.WriteLine(trimFiceFormatting);
            #endregion
        }
    }
}
