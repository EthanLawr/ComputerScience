import java.util.Scanner;

public class SCRABBLE {
	// Ethan Lawrence
	// This program will ask a user to enter a SCRABBLE word and then it will determine its point value
	// 3/19/2019
	// elawrence152@gmail.com
	
	public static void main(String[] args) {
		int score = 0;
        int[] EnglishScoreTable = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };

		System.out.println("This program will ask a user to enter a SCRABBLE word and then it will determine its point value");
		String Word = userInputMethod("Please enter a word: ");
				
        String English = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (String Letter : Word.split(""))
        {
        	score += EnglishScoreTable[English.indexOf(Letter)];
        }
		System.out.print("The SCRABBLE value of this word is: " + score);
	}
	
	 // Method for a Nasty Gram in a user input
    public static String userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print(x);
            String string = userInput.nextLine();
            if (string.length() == 0) return userInputMethod("You must enter a string with atleast one character!");
            return string.toUpperCase();
        } catch (Exception e) {
            System.out.print("You entered an invalid string. ");
            return userInputMethod(x);
        }
    }
}