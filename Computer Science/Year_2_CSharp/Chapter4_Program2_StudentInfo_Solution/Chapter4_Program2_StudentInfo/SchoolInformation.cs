using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program2_StudentInfo
{
    class SchoolInformation
    {
        private static string studentFirstName, studentLastName, studentClassification, studentMajor;
        private static double studentGPA = 0;
        public string FirstName
        {
            get
            {
                return studentFirstName;
            }
            set
            {
                studentFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return studentLastName;
            }
            set
            {
                studentLastName =  value;
            }
        }
        public string StudentClassification
        {
            get
            {
                return studentClassification;
            }
            set
            {
                studentClassification = value;
            }
        }
        public string StudentMajor
        {
            get
            {
                return studentMajor;
            }
            set
            {
                studentMajor = value;
            }
        }
        public double StudentGPA
        {
            get
            {
                return studentGPA;
            }
            set
            {
                studentGPA = value;
            }
        }

        public SchoolInformation(string x, string y, double z, string xx, string yy)
        {
            studentFirstName = x;
            studentLastName = y;
            studentGPA = z;
            studentClassification = xx;
            studentMajor = yy;
        }
    }
}
