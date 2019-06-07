import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;
@SuppressWarnings("unused")
public class TextAdventure {
	// Ethan Lawrence
	// This program is a text adventure!
	// 6/7/2019
	// elawrence152@gmail.com
	public static ArrayList<String> Commands = new ArrayList<String>();
	public static CommandCheck CommandInstructor = new CommandCheck(Commands);
	public static Location PlayerPosition = new Location();
	public static Player Character = new Player();
	public static Enemy Foe = new Enemy();
	public static String input = "";
	public static void main(String[] args) throws IOException {
		TextAdventure.ArrayListSort(TextAdventure.Commands);
		StoryFileReader NewStorySave = new StoryFileReader();
		System.out.print("Hello! Welcome to City Z. We are in huge danger. There are mon" +
		"sters running about everywhere and we are losing quite a bit of hope.\nWe are glad" +
				"that you could regain consciousness. ");
			StoryFileReader StoryReader = new StoryFileReader(1, PlayerPosition);
			System.out.print(PlayerPosition.roomDescription);
			PlayerPosition.DirectionDisplay();
			while (CommandInstructor.AliveOrPlaying) {
				userInputMethod(">");
				CommandInstructor.CommandSeek(input);
			}
			System.out.println("You stepped into the plains and the doors shut behind you."); 
			System.out.println("You left a mess behind you and let yourself go into the heavens of life");
			System.out.println("Here you could prosper forever, outside of that demon like land");
			System.out.println("However, it seemed rather easy.");
			System.out.println("You realized after a while it was really all done.");
			System.out.println("The end is here.");
			System.out.println("You are free.");
			System.out.println("Press enter to continue...");
			Spacer();
			System.out.println("\n\n\n\n\n\n\nCONGRATULATIONS");
			System.out.println("YOU WON");
	}
	 // Method for a Nasty Gram in a user input
    public static String userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print("\n" + x);
            String string = userInput.nextLine();
            if (string.length() == 0) return userInputMethod(">");
            input = string.toLowerCase();
            return null;
        } catch (Exception e) {
            System.out.print("You entered an invalid string. ");
            return userInputMethod(">");
        }
    }
    
    public static void Spacer() {
            try {
				System.in.read();
			} catch (IOException e) {
				e.printStackTrace();
			}
    }
    
    public static void ArrayListSort(ArrayList<String> x) {
    	Collections.sort(x, String.CASE_INSENSITIVE_ORDER);
    }  
    
}