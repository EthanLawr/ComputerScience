using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program1_SchoolInfo
{
    class SchoolInformation
    {
        private static string schoolName, studentAmount, schoolColoring;
        private static ConsoleColor schoolColors;
        private static int colorInt = 0;
        public string Name
        {
            get
            {
                return schoolName;
            }
            set
            {
                schoolName = value;
            }
        }
        public string StudentCount
        {
            get
            {
                return studentAmount + " students";
            }
            set
            {
                studentAmount =  value + "students";
            }
        }
        public string ColorNames
        {
            get
            {
                return schoolColoring.Trim(' ', 'a', 'n', 'd');
            }
            set
            {
                schoolColoring = value;
            }
        }
        public ConsoleColor SchoolColoring()
        {
            schoolColoring += $" and {Console.ForegroundColor = schoolColors + colorInt}";

            return Console.ForegroundColor = schoolColors++ + colorInt++;
        }
        public SchoolInformation(string x, string y, ConsoleColor z)
        {
            schoolName = x;
            studentAmount = y;
            schoolColors = z;
        }
    }
}
