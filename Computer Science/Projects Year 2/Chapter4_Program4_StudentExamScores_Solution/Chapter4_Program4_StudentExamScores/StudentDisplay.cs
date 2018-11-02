using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program4_StudentExamScores
{
    class StudentDisplay
    {
        public StudentDisplay()
        {
            StudentInput student = new StudentInput();
            Console.WriteLine($"Student ID: {student.StudentId}\nThe average score is {(student.TestOne+student.TestTwo+student.TestThree)/3.00}");

        }
    }
}
