
public class Dice {
	// This program will roll 2 dice
    // By Ethan Lawrence 12/7/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables and classes
		DiceRoller diceRoller = new DiceRoller();
		int dieOne = diceRoller.rollDie(), dieTwo = diceRoller.rollDie();
		
		
		System.out.println("This program will roll 2 dice.");
		
		System.out.println("The first die rolled as " + dieOne + " and the second rolled as " + dieTwo + " so they rolled " +
		     "as " + (dieOne + dieTwo) + " in total");
		
			
	}

}
