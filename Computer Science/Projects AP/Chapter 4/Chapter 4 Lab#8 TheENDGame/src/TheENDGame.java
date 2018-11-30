import java.util.Scanner;
import java.util.Random;
public class TheENDGame {
	// This program will play rock paper scissors with the user.
    // By Ethan Lawrence 11/13/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables and classes
		Scanner userInput = new Scanner(System.in);
		Random randomizer = new Random();
		String userPick, computerPick;
		// Showing what the program is for
		System.out.println("This program will play rock paper scissors with the user.");
		
		// Getting the user's choice
		System.out.print("1 = Scissors\t2 = Rock\t3 = Paper\nPlease enter a valid number to play rock paper scissors:");
		int userPlay = userInput.nextInt();
		
		int computerAI = randomizer.nextInt(4);
		
		// Making a string of the user's choice
		if (userPlay == 1) userPick = "Scissors";
		else if (userPlay == 2) userPick = "Rock";
		else userPick = "Paper";
		
		// Making a string of the computer's choice
		if (computerAI == 1) computerPick = "Scissors";
		else if (computerAI == 2) computerPick = "Rock";
		else computerPick = "Paper";
		
		// Results of what the user and computer choose
		if (userPlay != 1 && userPlay != 2 && userPlay != 3) System.out.print("Please enter a valid option.");
		else if (userPlay == computerAI) System.out.print("It was a tie! You picked " + userPick + " and so did the computer!");
		else if (userPlay == 1 && computerAI == 2 || userPlay == 2 && computerAI == 3|| userPlay == 3 && computerAI == 1)
			System.out.print("You lost! You chose " + userPick + " and the computer chose " + computerPick + "!");
		else if (userPlay == 2 && computerAI == 1 || userPlay == 3 && computerAI == 2|| userPlay == 1 && computerAI == 3) 
			System.out.print("You won! You chose " + userPick + " and the computer chose " + computerPick + "!");		
        	
	}

}
