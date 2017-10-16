using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ApplicationThingy
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

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
            Thread.Sleep(500);
            numofquestionsleft = numofquestions;
            // This is the loop which handles the actual question/answer core of the game.
            // Answering a question correctly increases your score.
            while (numofquestionsleft > 0)
            {

                Console.Write("What is " + num01 + " times " + num02 + "? ");
                answer = num01 * num02;
                playeranswer = Convert.ToInt32(Console.ReadLine());
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                if (answer == playeranswer)
                {
                    Console.WriteLine(playeranswer + " is correct!");
                    numofcorrect++;
                }
                else
                {
                    Console.WriteLine(playeranswer + " is incorrect! Try again.");
                }

                ContinueThing();
                Console.Clear();
                numofquestionsleft--;
                num01 = randomgen.Next(11);
                num02 = randomgen.Next(11);
            }
            // Letting the user know how many answers they got right. 
            Header();
            Console.WriteLine("You got " + numofcorrect + " of " + numofquestions + " correct!");
            ContinueThing();
        }
        public static void Header()
        {
            #region Header
            Console.ForegroundColor = ConsoleColor.Cyan; //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create 3 lines in the console!";
            //Shows the purpose of the current project
            string endheader = "\n********************************************************************************";
            //Ends the header
            Console.WriteLine(name); //Writes my name
            Thread.Sleep(50); //Sustains my name
            Console.Clear(); //Clears my name
            Thread.Sleep(70); //"Loading" time
            Console.WriteLine(name + date);
            //Writes my name and the date w/ the time
            Thread.Sleep(70); //Sustains my name and the date w/ the time
            Console.Clear(); //Clears my name and the date w/ the time
            Thread.Sleep(90); //"Loading" time
            Console.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Console.Clear(); //Clears my name, the date w/ the time, and the period
            Thread.Sleep(110); //"Loading" Time
            Console.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            Thread.Sleep(130);
            Console.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Console.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(150); //"Loading" Time
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
            #endregion Header
        }
        public static void ContinueThing()
        {
            #region Footer
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            Console.ReadKey();
            Thread.Sleep(500); //Sustains it
            #endregion Footer
        }
    }
}
