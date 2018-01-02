using System;
using System.Threading;

namespace Ch4_Program2.ChapterFour
{
    public class Ch4_Program2 : Colors
    {
        static void Main(string[] args)
        {
            Responses.Header();
            MagentaFont();                                           //Magenta coloring
            Console.WriteLine("Would you like to take this survey? (yes/no)\n");
            YellowFont();                                            //Yellow coloring
            string yesOrNo = Convert.ToString(Console.ReadLine());
            string yesOrNoFormatting = yesOrNo.ToLower();

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
                Responses.QuestionTwo();                                      //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Loading();                                                     //Loading Process
                Responses.EndSurveyGivenAnswer();                              //Header and responses
                Console.Write("{0}\n\n", favoriteSaying);
                Responses.EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Yes Shortened
            else if (yesOrNoFormatting == "y") //Answer is yes
            {
                Responses.QuestionTwo();                                       //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Loading();                                                     //Loading Process
                Responses.EndSurveyGivenAnswer();                              //Header and responses
                Console.Write("{0}\n\n", favoriteSaying);
                Responses.EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Invalid Answer
            else
            {
                Responses.AnswerIsInvalid();                                  //Invalid Answer Sequence
            }
            #endregion

        }

        public static void Loading()
        {
            CyanFont(); //Cyan Coloring
            Console.Write("\n\nLoading Results");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
