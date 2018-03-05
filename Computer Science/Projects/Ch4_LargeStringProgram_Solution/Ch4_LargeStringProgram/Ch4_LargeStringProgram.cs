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
                    
                    string trimMeOnce = " I pledge allegiance to the Flag ",
                        trimMeTwice = "of the *weather is nice*United States of America",
                        trimMeThrice = "and to the Republic for which it stands",
                        trimMeFource = "one *Na*tion under* God, indiv*isible,",
                        trimMeFice = "WITH LIBERTY AND JUSTICE FOR ALL.";
                    #endregion

                    CharTrimmer(trimMeOnce);
                    CharRemoval(trimMeTwice);
                    CharOperations(trimMeThrice);
                    CharReplacement(trimMeFource);
                    CharLowerCasing(trimMeFice);

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
            char[] charsToTrim = { '*', ' ' }; //Chars that are filtered out
            string trimOnceFormatting = x.Trim(charsToTrim); //Good ol trimming!
            RedFont(); //Fonts!
            Console.WriteLine(trimOnceFormatting);
        }

        internal static void CharRemoval(string x)
        {
            string trimTwiceFormatting = x.Remove(x.IndexOf('*'), x.LastIndexOf('*') - 6); //Removal
            RedFont(); //Fonts!
            Console.WriteLine(trimTwiceFormatting);
        }

        internal static void CharOperations(string x)
        {
            string trimThriceFormatting = x + ','; //Comma!
            RedFont(); //Fonts!
            Console.WriteLine(trimThriceFormatting);
        }

        internal static void CharReplacement(string x)
        {
            string trimFourceFormatting = x.Replace('*', ' '); //Replacement
            RedFont(); //Fonts!
            Console.WriteLine(trimFourceFormatting);
        }

        internal static void CharLowerCasing(string x)
        {
            string trimFiceFormatting = x.ToLower(); //Lowercase!*/
            RedFont(); //Fonts!
            Console.WriteLine(trimFiceFormatting);
        }
    }
}
