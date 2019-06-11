import java.util.Scanner;

public class MagicSquareFinder {
    /* Ethan Lawrence
     * 2/8/2019
     * This program will test magic squares*/
    public static void main(String[] args) {
        Scanner userInput = new Scanner(System.in);
        int[][] arrayBase = new int[4][4];

        System.out.println("This program will test a magic square");
        System.out.println("When entering integers keep them above -10,000 and below 10,000.");
        // Limit at 10000 for formatting purposes and to keep the program more simple

        System.out.print("Please enter 4 integers  of a first column to make a magic square: ");
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i][0] = userInputMethod();

        System.out.print("Please enter 4 integers  of a second column to make a magic square: ");
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i][1] = userInputMethod();

        System.out.print("Please enter 4 integers  of a third column to make a magic square: ");
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i][2] = userInputMethod();

        System.out.print("Please enter 4 integers  of a fourth column to make a magic square: ");
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i][3] = userInputMethod();

        // 4 versions of that so the user can keep track of what they are doing
        // Using methods to make the program robust and working even with errors

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                if (arrayBase[i][j] < 10) System.out.print(" ");    // for alignment
                if (arrayBase[i][j] < 100) System.out.print(" ");   // for alignment
                if (arrayBase[i][j] < 1000) System.out.print("  "); // for alignment
                if (arrayBase[i][j] < 10000) System.out.print(" "); // for alignment

                System.out.printf("%,d ", arrayBase[i][j]); // Printf for formatting
            }
            System.out.println();
        }

        if (magicSquare(arrayBase) == false) System.out.print("This is not a magic square.");
        else System.out.print("This is a magic square.");
        userInput.close();
    }

    public static boolean magicSquare(int[][] magicSquare) {
        int n = sumOfRow(magicSquare[0]);

        // Rows
        for (int[] row: magicSquare) {
            int sum = sumOfRow(row);
            if (sum != n) return false;
        }
        int sum = 0;

        // Columns
        for (int i = 0; i < magicSquare.length; i++) {
            sum = 0;
            for (int j = 0; j < magicSquare.length; j++) sum += magicSquare[j][i];
            if (sum != n) return false;
        }

        // Diagonal top left to bottom right
        sum = 0;
        for (int i = 0; i < magicSquare.length; i++) {
            sum += magicSquare[i][i];
        }
        if (sum != n) return false;

        // Diagonal top right to bottom left
        sum = 0;
        for (int i = 0; i < magicSquare.length; i++) {
            sum += magicSquare[i][magicSquare.length - 1 - i];
        }
        if (sum != n)
            return false;
        return true;
    }

    // Returns the sum of the elements in a row
    public static int sumOfRow(int[] row) {
        int sum = 0;
        for (int el: row) {
            sum += el;
        }
        return sum;
    }
    
    // Method for a Nasty Gram in a user input
    public static int userInputMethod() {
        try {
            Scanner userInput = new Scanner(System.in);
            int number = userInput.nextInt();
            // Nastygram to make sure the user inputs a valid number
            if (number > 10000 || number <= -10000) {
                System.out.print("Please enter a valid number between -10000 and 10000");
                number = userInputMethod();
            }

            return number;
        } catch (Exception e) {
            System.out.print("Please enter a valid integer. ");
            return userInputMethod();
        }
    }
}