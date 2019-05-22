import java.util.Scanner;

public class TextAdventure {
	// Ethan Lawrence
	// This program will ask a user to enter a SCRABBLE word and then it will determine its point value
	// 3/19/2019
	// elawrence152@gmail.com
	public static String input = "";
	public static void main(String[] args) {
		userInputMethod("Please enter something to do.");
		InvalidOption(input);
	}
	
	 // Method for a Nasty Gram in a user input
    public static String userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print(x);
            String string = userInput.nextLine();
            if (string.length() == 0) return userInputMethod("You must enter a string with atleast one character!");
            input = string.toLowerCase();
            return null;
        } catch (Exception e) {
            System.out.print("You entered an invalid string. ");
            return userInputMethod(x);
        }
    }
    
    public static void InvalidOption(String X) {
    	System.out.print("Please enter something valid to do! Your input was not recognized as a command!");
    	userInputMethod("Please enter something to do.");
    }
}