import java.util.Random;
import java.util.Scanner;

public class ToyBattleship {
    public static void main(String args[]) {
        // 5x5 grid battleship 6 attempts to get a ship, 1 square battleship
        int[][] board = {{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0}};
        int[][] board2 = {{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0}};
        boolean win = false;
        Random rand = new Random();
        int placement = rand.nextInt(26), tries = 6;
        
        for (int row = 0; row < board.length; row++) {
            for (int col = 0; col < board[row].length; col++) {
                if ((col + 1) + (row * 5) == placement) {
                    board[row][col] = 1;
                    break;
                }
            }
        }
        
        System.out.println("This program will allow the user to play Battleship in a 5 x 5 grid with only 6 shots.");
        System.out.println("The grid below represents the board. A 0 means an unknown space, a 1 means a ship was there, and a 2 means a missed shot.");
        
        for (int i = 0; i < tries; i++) {
            System.out.print("Please enter the cordinate you want to hit (Enter an integer between 1 and 25)");
            int userInput = userInputMethod();
            for (int row = 0; row < board.length; row++) {
                for (int col = 0; col < board[row].length; col++) {
                    if (board2[row][col] == 2 && (col + 1) + (row * 5) == userInput) {
                        i--;
                        System.out.print("Please try again. There was already a missed shot here. ");
                        break;
                    }
                    else if (board[row][col] == 1 && (col + 1) + (row * 5) == userInput) {
                        board2[row][col] = 1;
                        win = true;
                        i = 6;
                        break;
                    }
                    else if ((col + 1) + (row * 5) == userInput) {
                        board2[row][col] = 2;
                        for (int roww = 0; roww < board2.length; roww++) {
                            for (int coll = 0; coll < board2[row].length; coll++) {
                                System.out.print(board2[roww][coll] + " ");
                            }
                            System.out.println();    
                        }
                        break;
                    }
                }
            }
        }
        
        //Reveals the winning ship
        for (int row = 0; row < board.length; row++) {
            for (int col = 0; col < board[row].length; col++) {
                if ((col + 1) + (row * 5) == placement) {
                    board2[row][col] = 1;
                    break;
                }
            }
        }
        
        if (win) System.out.println("Congratulations! You won! Here is your board:");
        else System.out.println("Unfortunately you lost. Here is your board.");
        for (int row = 0; row < board2.length; row++) {
            for (int col = 0; col < board2[row].length; col++) {
                    System.out.print(board2[row][col] + " ");
            }
            System.out.println();    
        }
    }
    // Method for a Nasty Gram in a user input
    public static int userInputMethod() {
        try {
            Scanner userInput = new Scanner(System.in);
            int number = userInput.nextInt();
            // Nastygram to make sure the user inputs a valid number
            if (number > 25 || number < 1) {
                System.out.print("Please enter a valid integer between 1 and 25");
                number = userInputMethod();
            }

            return number;
        } catch (Exception e) {
            System.out.print("Please enter a valid integer. ");
            return userInputMethod();
        }
    }
}
