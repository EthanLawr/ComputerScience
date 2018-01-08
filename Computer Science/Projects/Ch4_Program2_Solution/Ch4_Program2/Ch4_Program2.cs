using Rsp = Ch4_Program2.ChapterFour.Responses;
using Fmt = Ch4_Program2.ChapterFour.HeaderFooter;
using Clog = System.Console;
using Cvrt = System.Convert;

namespace Ch4_Program2.ChapterFour
{

    public class Ch4_Program2  : Colors
    {
        static void Main(string[] args)
        {
            Fmt.Header();
            MagentaFont();                                           //Magenta coloring
            Clog.WriteLine("Would you like to take this survey? (yes/no)\n");
            YellowFont();                                            //Yellow coloring
            string yesOrNo = Cvrt.ToString(Clog.ReadLine());
            string yesOrNoFormatting = yesOrNo.ToLower();

            #region No
            if (yesOrNoFormatting == "no")  //Answer is no
            {
                Rsp.AnswerIsNo();
            }
            #endregion

            #region No Shortened
            else if (yesOrNoFormatting == "n")  //Answer is no
            {
                Rsp.AnswerIsNo();
            }
            #endregion

            #region Yes
            else if (yesOrNoFormatting == "yes") //Answer is yes
            {
                Rsp.QuestionTwo();                                      //Second Question of the survey
                string favoriteSaying = Cvrt.ToString(Clog.ReadLine());
                Rsp.Loading();                                                     //Loading Process
                Rsp.EndSurveyGivenAnswer();                              //Header and responses
                Clog.Write("{0}\n\n", favoriteSaying);
                Rsp.EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Yes Shortened
            else if (yesOrNoFormatting == "y") //Answer is yes
            {
                Rsp.QuestionTwo();                                       //Second Question of the survey
                string favoriteSaying = Cvrt.ToString(Clog.ReadLine());
                Rsp.Loading();                                                     //Loading Process
                Rsp.EndSurveyGivenAnswer();                              //Header and responses
                Clog.Write("{0}\n\n", favoriteSaying);
                Rsp.EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Invalid Answer
            else
            {
                Rsp.AnswerIsInvalid();                                  //Invalid Answer Sequence
            }
            #endregion

        }


    }
}
