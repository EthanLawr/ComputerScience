using System;
					
public class Program
{
	
    public static void Main(string[] args)
    {
        string[] players = EnterPlayers();
        string[] pieces = {"O", "X"};
        int[] scores = {0, 0};

        bool playing = true;
        while (playing)
        {
            PlayGame(players, scores, pieces);
            playing = AskToPlayAgain();
        }
    }
    // Array that contains board positions, 0 isnt used --------------------------------
    private static readonly string[] Pos = { "0", "1", "2","3","4","5","6","7","8","9" };

    private static void DrawBoard() // Draw board method ==========================================
    {
        Console.WriteLine("   {0}  |  {1}  |  {2}   \n-------------------\n   {3}  |  {4}  |  {5}   ", Pos[1], Pos[2], Pos[3], Pos[4], Pos[5], Pos[6]);
        Console.WriteLine("-------------------\n   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
    }

    private static string[] EnterPlayers()
    {
        Console.WriteLine("Hello! This is Tic Tac Toe.\nWhat is the name of player 1?");
        var player1 = Console.ReadLine();
        Console.WriteLine("What is the name of player 2?");
        var player2 = Console.ReadLine();
        Console.WriteLine("{0} is O and {1} is X. {0} goes first.", player1, player2);
        return new [] {player1, player2};
    }


    private static void PlayGame(string[] players, int[] scores, string[] pieces)
    {
        bool isGameWon = false, isGameOver = false;
        int playerIndex = 0;

        while (isGameOver == false)
        {
            var nextPlayerIndex = 1 - playerIndex;
            var player = players[playerIndex];
            var piece = pieces[playerIndex];
            var opponentPiece = pieces[nextPlayerIndex];

            PlayerMakesAMove(players, scores, player, piece, opponentPiece);

            isGameWon = CheckWin();
            isGameOver = isGameWon || CheckDraw();

            if (isGameOver == false) playerIndex = nextPlayerIndex;
        }

        Console.Clear();
        DrawBoard();
        ResetBoard();

        if (isGameWon)
        {
            IncrementPlayerScore(scores, playerIndex);
            Console.WriteLine("{0} wins!", players[playerIndex]);
        }
        else Console.WriteLine("It's a draw!");

        ReportScores(players, scores);
    }

    private static void PlayerMakesAMove(string[] players, int[] scores, string player, string piece, string opponentPiece)
    {
        do
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("");
            ReportScores(players, scores);
        } while (!TryToPlaceAPiece(player, piece, opponentPiece));
    }

    private static bool CheckDraw()
    {
        return false;
    }

    private static void IncrementPlayerScore(int[] scores, int playerIndex)
    {
        scores[playerIndex] = scores[playerIndex] + 1;
    }

    private static void ReportScores(string[] players, int[] scores)
    {
        Console.WriteLine("Score: {0} - {1}     {2} - {3}", players[0], scores[0], players[1], scores[1]);
    }

    private static bool TryToPlaceAPiece(string player, string playerPiece, string opponentsPiece)
    {
        Console.WriteLine("{0}'s ({1}) turn", player, playerPiece);
        var move = AskTheUser("Which position would you like to take?", 1, 9);
        if (!IsMoveTaken(playerPiece, opponentsPiece, move))
        {
            Pos[move] = playerPiece;
            return true;
        }

        Console.Write("That positions is taken!\n Try again.");
        Console.ReadLine();
        Console.Clear();
        return false;
    }

    private static bool IsMoveTaken(string playerPiece, string opponentsPiece, int move)
    {
        return Pos[move] == opponentsPiece || Pos[move] == playerPiece;
    }

    private static bool AskToPlayAgain()
    {
        Console.WriteLine("\nWhat would you like to do now?\n1. Play again\n2. Leave");
        var choice = AskTheUser("Enter your option: ", 1, 2);
        Console.Clear();
        if (choice == 1) return true;
        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
        return false;
    }

    private static int AskTheUser(string prompt, int min, int max)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            int choice = int.Parse(Console.ReadLine());
            if (choice >= min && choice <= max) return choice;
        }
    }

    private static void ResetBoard()
    {
        for (int i = 1; i < 10; i++) Pos[i] = i.ToString();
    }

    static bool CheckWin() // Win checker method ================================================
    {
        return IsAnyHorizontalLine(1) || IsAnyHorizontalLine(4) || IsAnyHorizontalLine(7) ||
               IsAnyLine(1, 4) ||  IsAnyLine(3, 2) ||  // Diagonal
               IsAnyVerticalLine(1) || IsAnyVerticalLine(2) || IsAnyVerticalLine(3);
    }

    private static bool IsLine(int index0, int index1, int index2, string piece)
    {
        return Pos[index0] == piece && Pos[index1] == piece && Pos[index2] == piece;
    }

    private static bool IsAnyLine(int start, int step)
    {
        return IsLine(start, start+step, start+step+step, Pos[start]);
    }

    private static bool IsAnyHorizontalLine(int startindex)
    {
        return IsAnyLine(startindex, 1);
    }

    private static bool IsAnyVerticalLine(int startindex)
    {
        return IsAnyLine(startindex, 3);
    }
}
