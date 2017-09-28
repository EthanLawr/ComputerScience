using System;

namespace ForthConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomgen = new Random();

            //int timer = 30; I considered a timer function but that ended up being way over my head.
            int num01 = randomgen.Next(11);
            int num02 = randomgen.Next(11);
            int playeranswer;
            int answer;
            int numofquestions;
            int numofquestionsleft;
            int numofcorrect = 0;


            Console.Write("How many questions would you like to answer? ");
            numofquestions = Convert.ToInt32(Console.ReadLine());
            numofquestionsleft = numofquestions;

            // This is the loop which handles the actual question/answer core of the game.
            // Answering a question correctly increases your score.
            while (numofquestionsleft > 0){

                Console.Write("What is " + num01 + " times " + num02 + "? ");
                answer = num01 * num02;
                playeranswer = Convert.ToInt32(Console.ReadLine());
                if (answer == playeranswer)
                {
                    Console.WriteLine(playeranswer + " is correct!");
                    numofcorrect++;
                }
                else {
                    Console.WriteLine(playeranswer + " is incorrect! Try again.");
                }
                Console.ReadKey();
                numofquestionsleft--;
                num01 = randomgen.Next(11);
                num02 = randomgen.Next(11);
            }
            // Letting the user know how many answers they got right. 
            Console.WriteLine("You got " + numofcorrect + " of " + numofquestions + " correct!");
            Console.ReadKey();

        }
    }
}
