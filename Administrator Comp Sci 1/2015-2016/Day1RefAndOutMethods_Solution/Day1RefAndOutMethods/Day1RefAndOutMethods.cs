using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1RefAndOutMethods
{
    class Day1RefAndOutMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main Method");

            //Variables
            int age = 16;
            string nickname;

            Console.WriteLine("\nIn Main: age = {0}",age);
            
            //Typical Return method, now passed by reference (ref), now (out)
            int teacherAge = AgeGetter("your age", ref age, out nickname);
            Console.WriteLine("\nIn the main method the teacher age is {0}",teacherAge);
            Console.WriteLine("\nIn Main after ref method: age = {0}", age);
            Console.WriteLine("\nIn Main after ref/out method: nickname = {0}",nickname);

            Console.Read();
        }
        //Method for age
        public static int AgeGetter(string x, ref int y, out string z)
        {
            y = y + 5;
            z = "knucklehead";
            Console.Write("Please enter {0}\t\t",x);
            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);
            return inputInt;
        }

    }
}
