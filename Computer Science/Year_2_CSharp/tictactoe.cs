using System;

public class Program {

 public static void Main(string[] args) {
  string[] users = EnterUsers();
  string[] MadeMove = {"O","X"};
  int[] scores = {0,0};

  bool playing = true;
  while (playing) {
   PlayGame(users, scores, MadeMove);
   playing = AskToPlayAgain();
  }
 }
 // Array that contains board positions, 0 isnt used --------------------------------
 private static readonly string[] position = {"0","1","2","3","4","5","6","7","8","9"};

 private static void MakeBoard() // Draw board method ==========================================
 {
  Console.WriteLine("   {0}  |  {1}  |  {2}   \n-------------------\n   {3}  |  {4}  |  {5}   ", position[1], position[2], position[3], position[4], position[5], position[6]);
  Console.WriteLine("-------------------\n   {0}  |  {1}  |  {2}   ", position[7], position[8], position[9]);
 }

 private static string[] EnterUsers() {
  Console.WriteLine("Hello! This is Tic Tac Toe.\nWhat is the name of player 1?");
  var player1 = Console.ReadLine();
  Console.WriteLine("What is the name of player 2?");
  var player2 = Console.ReadLine();
  Console.WriteLine("{0} is O and {1} is X. {0} goes first.", player1, player2);
  return new [] {player1,player2};
 }


 private static void PlayGame(string[] users, int[] scores, string[] MadeMov) {
  bool isGameWon = false, isGameOver = false;
  int playerIndex = 0;

  while (isGameOver == false) {
   var nextPlayerIndex = 1 - playerIndex;
   var player = users[playerIndex];
   var piece = MadeMove[playerIndex];
   var opponentPiece = MadeMove[nextPlayerIndex];

   PlayerMakesAMove(users, scores, player, piece, opponentPiece);

   isGameWon = CheckWin();
   isGameOver = isGameWon || CheckDraw();

   if (isGameOver == false) playerIndex = nextPlayerIndex;
  }

  Console.Clear();
  MakeBoard();
  ResetBoard();

  if (isGameWon) {
   Incrementuserscore(scores, playerIndex);
   Console.WriteLine("{0} wins!", users[playerIndex]);
  } else Console.WriteLine("It's a draw!");

  ReportScores(users, scores);
 }

 private static void PlayerMakesAMove(string[] users, int[] scores, string player, string piece, string opponentPiece) {
  do {
   Console.Clear();
   MakeBoard();
   Console.WriteLine("");
   ReportScores(users, scores);
  } while (!TryToPlaceAPiece(player, piece, opponentPiece));
 }

 private static bool CheckDraw() {
  return false;
 }

 private static void Incrementuserscore(int[] scores, int playerIndex) {
  scores[playerIndex] = scores[playerIndex] + 1;
 }

 private static void ReportScores(string[] users, int[] scores) {
  Console.WriteLine("Score: {0} - {1}     {2} - {3}", users[0], scores[0], users[1], scores[1]);
 }

 private static bool TryToPlaceAPiece(string player, string playerPiece, string opponentsPiece) {
  Console.WriteLine("{0}'s ({1}) turn", player, playerPiece);
  var move = AskTheUser("Which position would you like to take?", 1, 9);
  if (!IsMoveTaken(playerPiece, opponentsPiece, move)) {
   position[move] = playerPiece;
   return true;
  }

  Console.Write("That position is taken!\n Try again.");
  Console.ReadLine();
  Console.Clear();
  return false;
 }

 private static bool IsMoveTaken(string playerPiece, string opponentsPiece, int move) {
  return position[move] == opponentsPiece || position[move] == playerPiece;
 }

 private static bool AskToPlayAgain() {
  Console.WriteLine("\nWhat would you like to do now?\n1. Play again\n2. Leave");
  var choice = AskTheUser("Enter your option: ", 1, 2);
  Console.Clear();
  if (choice == 1) return true;
  Console.WriteLine("Thanks for playing!");
  Console.ReadLine();
  return false;
 }

 private static int AskTheUser(string prompt, int min, int max) {
  while (true) {
   Console.WriteLine(prompt);
   int choice = int.Parse(Console.ReadLine());
   if (choice >= min && choice <= max) return choice;
  }
 }

 private static void ResetBoard() {
  for (int i = 1; i < 10; i++) position[i] = i.ToString();
 }

 static bool CheckWin() // Win checker method ================================================
 {
  return IsAnyHorizontalLine(1) || IsAnyHorizontalLine(4) || IsAnyHorizontalLine(7) ||
   IsAnyLine(1, 4) || IsAnyLine(3, 2) || // Diagonal
   IsAnyVerticalLine(1) || IsAnyVerticalLine(2) || IsAnyVerticalLine(3);
 }

 private static bool IsLine(int index0, int index1, int index2, string piece) {
  return position[index0] == piece && position[index1] == piece && position[index2] == piece;
 }

 private static bool IsAnyLine(int start, int step) {
  return IsLine(start, start + step, start + step + step, position[start]);
 }

 private static bool IsAnyHorizontalLine(int startindex) {
  return IsAnyLine(startindex, 1);
 }

 private static bool IsAnyVerticalLine(int startindex) {
  return IsAnyLine(startindex, 3);
 }
}
