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
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    TaskShortener.Header();

                    //Asks the amount of change you have
                    string trimMeBruh = TaskShortener.AskUserForString("the total change "
                        + "you have");

                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }
        char[] charsToTrim = { '*', ' ' };
            string yesOrNoFormatting = (yesOrNo.Trim(charsToTrim)).ToLower();
        }
    }
}
