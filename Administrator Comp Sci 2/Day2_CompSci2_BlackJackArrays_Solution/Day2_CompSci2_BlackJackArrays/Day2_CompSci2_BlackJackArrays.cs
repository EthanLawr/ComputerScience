using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_CompSci2_BlackJackArrays
{
    class Day2_CompSci2_BlackJackArrays
    {
        static void Main(string[] args)
        {
            #region Header
            Console.SetWindowSize(80, 60);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch");
            Console.WriteLine("\nDate: <insert here>");
            Console.WriteLine("\nPurpose: <insert here>");
            Console.WriteLine("\n****************************************\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion
                int cardCounter = 0;
                String ans;

                //assigning deck all values
                String[] deck = new String[52]
                {"Ac", "Ad", "Ah", "As",
            "Kc", "Kd", "Kh", "Ks",
            "Qc", "Qd", "Qh", "Qs",
            "Jc", "Jd", "Jh", "Js",
            "10c", "10d", "10h", "10s",
            "9c", "9d", "9h", "9s",
            "8c", "8d", "8h", "8s",
            "7c", "7d", "7h", "7s",
            "6c", "6d", "6h", "6s",
            "5c", "5d", "5h", "5s",
            "4c", "4d", "4h", "4s",
            "3c", "3d", "3h", "3s",
            "2c", "2d", "2h", "2s"};

                String[] myHand = new String[20];
                String[] dealersHand = new String[20];

                for (int z = 0; z <= 19; z++) //fill the arrays with *
                {
                    myHand[z] = "*";
                    dealersHand[z] = "*";
                }

                PrintDeck(deck);

                //use this method to test to see that * are being assigned
                //printInitialDecks(myHand, dealersHand);

                int x = 0;

                /*   for(int y=0;y<=51;y++)  //used to print the initial unshuffled deck
                   {
                       Console.WriteLine(deck[y]); 
                   }*/

                do
                {
                    Random card = new Random();
                    int nextCard = card.Next(0, 51);


                    while (deck[nextCard] == "*")
                    {
                        cardCounter++;
                        nextCard = card.Next(0, 51);
                        if (cardCounter == 52)
                            break;
                    }

                    myHand[x] = deck[nextCard];
                    deck[nextCard] = "*";
                    x++;

                    ShowCards(myHand);

                    PrintDeck(deck);

                    Console.Write("\nDo you want another card (yes/no)?");
                    ans = Console.ReadLine();
                }
                while (ans != "no");


            #region This is where we end the program
            //End any program
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\nPlease hit the ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ENTER ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" key to end program . . . ");
            Console.Read();
            #endregion
            
            }

        //this method prints my cards
        public static void ShowCards(String[] myHand)
        {
            int c = 0;
            Console.WriteLine("\nHere are my cards thus far....");
            while (myHand[c] != "*")
            {
                Console.WriteLine(myHand[c]);
                c++;
            }
            Console.WriteLine();
        }

        //use this method to assure that * are being assigned to decks
        public static void printInitialDecks(String[] myHand, String[] dealersHand)
        {
            for (int z = 0; z <= 19; z++)
            {
                Console.Write(myHand[z] + "");

            }

            Console.WriteLine();

            for (int z = 0; z <= 19; z++)
            {
                Console.Write(dealersHand[z] + "");

            }

            Console.WriteLine();

        }

        public static void PrintDeck(String[] deck)
        {
            Console.WriteLine("\nHere are the cards in the deck....");
            for (int d = 0; d <= 51; d++)
            {
                Console.Write(deck[d] + " ");
            }
            Console.WriteLine();
        }

    }
}

