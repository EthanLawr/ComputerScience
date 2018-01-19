using System;

namespace Ch4_Program2.ChapterFour
{

    public class Ch4_Program2  : Colors
    {
        static void Main(string[] args)
        {
            HeaderFooter.Header();
            MagentaFont();                                           //Magenta coloring
            Console.WriteLine("Would you like to take this survey? (yes/no)\n");
            YellowFont();                                            //Yellow coloring
            string yesOrNo = Convert.ToString(Console.ReadLine());
            char[] charsToTrim = { '*', ' '};
            string yesOrNoFormatting = (yesOrNo.Trim(charsToTrim)).ToLower();


            #region No
            if (yesOrNoFormatting == "no")  //Answer is no
            {
                Responses.AnswerIsNo();
            }
            #endregion

            #region No Shortened
            else if (yesOrNoFormatting == "n")  //Answer is no
            {
                Responses.AnswerIsNo();
            }
            #endregion

            #region Yes
            else if (yesOrNoFormatting == "yes") //Answer is yes
            {
                Responses.QuestionTwo();                  //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Responses.Loading();                                  //Loading Process
                Responses.EndSurveyGivenAnswer();
                YellowFont();                                            //Header and responses
                Console.WriteLine("\n*******************************************" 
                    + "*************************************{0}\n***************"
                    + "*********************************************************"
                    + "********", favoriteSaying);
                Responses.EndSurvey();                                //Ending survey message
            }
            #endregion

            #region Yes Shortened
            else if (yesOrNoFormatting == "y") //Answer is yes
            {
                Responses.QuestionTwo();                  //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Responses.Loading();                                  //Loading Process
                Responses.EndSurveyGivenAnswer();
                YellowFont();                                            //Header and responses
                Console.WriteLine("\n*******************************************"
                    + "*************************************{0}\n***************"
                    + "*********************************************************"
                    + "********", favoriteSaying);
                Responses.EndSurvey();                                //Ending survey message
            }
            #endregion

            #region Invalid Answer
            else
            {
                Responses.AnswerIsInvalid();                  //Invalid Answer Sequence
            }
            #endregion

        }
        public static string SecondQuestion(string x)
        {
            MagentaFont();
            Console.WriteLine("\nPlease enter your {0}\n\n", x);
            string userInput = Console.ReadLine();
            return userInput;

        }
    }
}
