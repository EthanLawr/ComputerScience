using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program2_StudentInfo
{
    class StudentInformation
    {
        public StudentInformation()
        {
            SchoolInformation info = new SchoolInformation("Ethan", "Lawrence", 4, "Student", "Software Engineering");
            Console.WriteLine($"Student Name: {info.FirstName} {info.LastName}");
            Console.WriteLine($"Student GPA: {info.StudentGPA}");
        }
    }
}
