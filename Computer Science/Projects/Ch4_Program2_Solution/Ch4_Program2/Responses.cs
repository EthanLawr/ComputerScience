using Clog = System.Console;
using SW = System.Threading.Thread;

namespace Ch4_Program2.ChapterFour
{
    public class Responses  : Colors
    {
        public static void AnswerIsNo()
        {
            MagentaFont();                                       //Magenta coloring
            Clog.WriteLine("\n\nThats just too bad! Have a nice day!");
            HeaderFooter.Footer(); 
        }

        public static void AnswerIsInvalid()
        {
            CyanFont();
            Clog.WriteLine("\n\nThats an invalid answer! Restart the Program"
                + " and answer correctly to continue!");
            HeaderFooter.Footer();
        }

        public static void QuestionTwo()
        {
            MagentaFont();                                       //Magenta coloring
            Clog.Write("What is your favorite saying?\n");    //Question
            YellowFont();                                        //Yellow coloring
        }

        public static void EndSurvey()
        {
            MagentaFont();                                       //Magenta coloring
            Clog.Write("Thank you for taking this survey!");
            HeaderFooter.Footer();
        }

        public static void EndSurveyGivenAnswer()
        {
            HeaderFooter.SecondHeader();                                      //Header Reset
            MagentaFont();                                       //Magenta coloring
            Clog.WriteLine("You entered your favorite saying as:\n");
            YellowFont();                                        //Yellow coloring
        }

        public static void Loading()
        {
            CyanFont(); //Cyan Coloring
            Clog.Write("\n\nLoading Results");
            SW.Sleep(500);
            Clog.Write(".");
            SW.Sleep(500);
            Clog.Write(".");
            SW.Sleep(500);
            Clog.Write(".");
            SW.Sleep(500);
            Clog.Clear();
        }
    }
}
