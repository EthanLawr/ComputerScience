import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class TextAdventure {
	// Ethan Lawrence
	// This program will ask a user to enter a SCRABBLE word and then it will determine its point value
	// 3/19/2019
	// elawrence152@gmail.com
	public static ArrayList<String> Commands = new ArrayList<String>();
	public static CommandCheck CommandInstructor = new CommandCheck(Commands);
	public static Location PlayerPosition = new Location();
	public static String input = "";
	public static void main(String[] args) {
		try {
			StoryFileReader StoryReader = new StoryFileReader(1, PlayerPosition);
			System.out.print(PlayerPosition.roomDescription);
			PlayerPosition.DirectionDisplay();
			while (CommandInstructor.AliveOrPlaying) {
				userInputMethod(">");
				CommandInstructor.CommandSeek(input);
			}
			
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
    
    
}