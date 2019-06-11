using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program4_StudentExamScores
{
    class StudentInput : TaskShortener
    {
        private static string studentId;
        private static double testScoreOne, testScoreTwo, testScoreThree;
        public string StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }
        public double TestOne
        {
            get
            {
                return testScoreOne;
            }
            set
            {
                testScoreOne =  value;
            }
        }
        public double TestTwo
        {
            get
            {
                return testScoreTwo;
            }
            set
            {
                testScoreTwo = value;
            }
        }
        public double TestThree
        {
            get
            {
                return testScoreThree;
            }
            set
            {
                testScoreThree = value;
            }
        }

        public StudentInput()
        {
            studentId = AskUserForString("your student id.");
            testScoreOne = AskUserForDouble("a test score");
            testScoreTwo = AskUserForDouble("a second test score");
            testScoreThree = AskUserForDouble("a third test score");
        }
    }
}
