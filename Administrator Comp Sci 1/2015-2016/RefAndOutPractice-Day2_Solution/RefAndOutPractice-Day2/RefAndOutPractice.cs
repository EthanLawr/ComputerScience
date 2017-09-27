using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutPractice_Day2
{
    class RefAndOutPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");

            //Variables
            int grandparentsAge = 76;
            string mrLynchsFavoriteNickname;
            Console.WriteLine("Main: grandmom's age is {0}",grandparentsAge);
            
            //Call the method
            double gpa = AskForDouble("your gpa",ref grandparentsAge, out mrLynchsFavoriteNickname);
            Console.WriteLine("In the Main method your gpa is {0}",gpa);

            //Pass by reference (ref)
            Console.WriteLine("\n\nAfter run through the Double Method");
            Console.WriteLine("Grandmom's age now is {0}",grandparentsAge);
            Console.WriteLine("My favorite nickname now is {0}",mrLynchsFavoriteNickname);

            //Pass by reference (out)
            //Create a new method
            Nickname(out mrLynchsFavoriteNickname);
            Console.WriteLine("After runing the display method:");
            Console.WriteLine("\n\nMain: my favorite nickname is {0}",mrLynchsFavoriteNickname);

            Console.Read();
        }
        //Write a basic method to demonstrate out
        public static void Nickname(out string x)
        {
            Console.WriteLine("\nThis is just a diplay method");
            x = "goofball";
        }

        //Write a method that returns something
        public static double AskForDouble(string x, ref int y, out string z)
        {
            Console.WriteLine("\nPlease enter {0}",x);
            string input = Console.ReadLine();
            y = 54;
            z = "knucklehead";
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }

    }
}
