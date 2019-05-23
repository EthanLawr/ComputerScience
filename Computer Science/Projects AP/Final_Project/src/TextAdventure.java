import java.io.FileNotFoundException;
import java.util.Scanner;

public class TextAdventure {
	// Ethan Lawrence
	// This program will ask a user to enter a SCRABBLE word and then it will determine its point value
	// 3/19/2019
	// elawrence152@gmail.com
	public static Location PlayerPosition = new Location();
	public static Movement PlayerMovement = new Movement();
	public static String input = "";
	public static void main(String[] args) {
		try {
			StoryFileReader StoryReader = new StoryFileReader(1, PlayerPosition);
			System.out.print(PlayerPosition.roomDescription);
			userInputMethod("Please enter something to do.");
			if (input.equals("help")) {
				System.out.print("Commands:\nhelp");
			} else InvalidOption(input);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		
	}
	 // Method for a Nasty Gram in a user input
    public static String userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print("\n" + x);
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