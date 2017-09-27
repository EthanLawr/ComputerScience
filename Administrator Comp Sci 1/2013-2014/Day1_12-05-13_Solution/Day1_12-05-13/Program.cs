using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_12_05_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string school = AskUserForInputString("your school");
            string opponentSchool = AskUserForInputString("your opponent's school");
            int schoolScore = AskUserForInputInt("your school's score");
            int opponentScore = AskUserForInputInt("your opponent's score");
            DisplayResults(school, opponentSchool, schoolScore, opponentScore);
            Console.WriteLine("\n\nPlease hit ANY key to end program . . .");
            Console.ReadKey();
        }
        public static void DisplayResults(string x, string y, int z, int w)
        {
            Console.WriteLine("\n********************************\n");
            Console.WriteLine("The box score is\n{0} vs. {1}",x,y);
            Console.WriteLine("\n{0} - {1}",z,w);
            Console.WriteLine("\n********************************\n");
        }
        public static int AskUserForInputInt(string goofball)
        {
            Console.Write("\nPlease enter . . . {0}\t", goofball);
            string glasses = Console.ReadLine();
            int ear = Convert.ToInt32(glasses);
            return ear;
        }
        public static string AskUserForInputString(string goofball)
        {
            Console.Write("\nPlease enter . . . {0}\t",goofball);
            string glasses = Console.ReadLine();
            return glasses;
        }
    }
}
