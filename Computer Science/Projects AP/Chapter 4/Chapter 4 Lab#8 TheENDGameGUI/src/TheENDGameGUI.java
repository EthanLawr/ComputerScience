import java.util.Scanner;
import java.util.Random;
import javax.swing.*;

public class TheENDGameGUI {
	// This program will play rock paper scissors with the user using a GUI.
    // By Ethan Lawrence 11/13/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables and classes
		Random randomizer = new Random();
		String userPick, computerPick, computerString;
		JFrame frame = new JFrame();
		
		// Getting a computer's input
	    int computerAI = randomizer.nextInt(4);
		
		// Getting a user input
		String userPlay = JOptionPane.showInputDialog("This program will play rock paper scissors with the user using a GUI.\n" + ""
				+ "1 = Scissors     2 = Rock     3 = Paper\nPlease enter a valid number to play rock paper scissors:");
		
		
		// Making words of the user's input
		if (userPlay.equals("1") == true) userPick = "Scissors";
		else if (userPlay.equals("2") == true) userPick = "Rock";
		else if (userPlay.equals("3") == true) userPick = "Paper";
		else { 
			userPlay = "Error";
			userPick = "Error";
		}
		
		// Making a string of the computer's choice
		if (computerAI == 1) {
			computerPick = "Scissors"; computerString = "1"; 
		}
		else if (computerAI == 2)  {
			computerPick = "Rock"; computerString = "2"; 
		}
		else  {
			computerPick = "Paper"; computerString = "3"; 
		}

		// Output
		if (userPlay.equals("1") == false && userPlay.equals("2") == false && userPlay.equals("3") == false || userPlay.equals("Error")) 		
			JOptionPane.showMessageDialog(frame, "Please enter a valid option.", "Rock Paper Scissors", 0);
		else if (userPlay.equals(computerString)) 
			JOptionPane.showMessageDialog(frame, "It was a tie! You picked " + userPick + 
					" and so did the computer!", "Rock Paper Scissors", 3);
		else if (userPlay.equals("1") && computerString.equals("2") || userPlay.equals("2") && computerString.equals("3") || 
				userPlay.equals("3") && computerString.equals("1"))
			JOptionPane.showMessageDialog(frame, "You lost! You chose " + userPick + " and the computer chose " +
		        computerPick + "!", "Rock Paper Scissors", 0);
		else if (userPlay.equals("2") && computerString.equals("1") || userPlay.equals("3") && computerString.equals("2") || 
				userPlay.equals("1") && computerString.equals("3")) 
			JOptionPane.showMessageDialog(frame, "You won! You chose " + userPick + " and the computer chose " + 
		        computerPick + "!", "Rock Paper Scissors", 3);
		
			
	}

}
