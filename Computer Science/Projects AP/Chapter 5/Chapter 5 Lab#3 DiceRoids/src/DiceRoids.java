import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class DiceRoids {
	// This program will roll 100 dice
    // By Ethan Lawrence 12/10/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables and classes
		DiceRoller diceRoller = new DiceRoller();
		JFrame frame = new JFrame();
		
		int resultOne = 0, resultTwo = 0, resultThree = 0, resultFour = 0, resultFive = 0, 
				resultSix = 0, resultSeven = 0, resultEight = 0, resultNine = 0, resultTen = 0, resultEleven = 0;;
	    int dieRollOne = diceRoller.rollDie(), dieRollTwo = diceRoller.rollDie();

				
	    // Getting the counts of the 100 rolled dice
		for (int i = 0; i <= 100; i++) {
			int dieOne = diceRoller.rollDie() + diceRoller.rollDie();
			
			if (dieOne == 2) resultOne++;
			else if (dieOne == 3) resultTwo++;
			else if (dieOne == 4) resultThree++;
			else if (dieOne == 5) resultFour++;
			else if (dieOne == 6) resultFive++;
			else if (dieOne == 7) resultSix++;
			else if (dieOne == 8) resultSeven++;
			else if (dieOne == 9) resultEight++;
			else if (dieOne == 10) resultNine++;
			else if (dieOne == 11) resultTen++;
			else resultEleven++;
		
			
		}

		// Display
		JOptionPane.showMessageDialog(frame, "This program will roll 100 dice and show the results of that. " +
		"This will also show the results of 2 dice being rolled.", "Dice Statistics", 3);
		
		JOptionPane.showMessageDialog(frame, "The first die rolled as " + dieRollOne + " and the second rolled as " + 
				dieRollTwo + " so they rolled " +
			     "as " + (dieRollOne + dieRollTwo) + " in total", "Dice Statistics", 3);
		
		JOptionPane.showMessageDialog(frame, "Number Rolled     Frequency\n2                               " + resultOne + 
				"\n3                               " + resultTwo + "\n4                               " + resultThree +
				"\n5                               " + resultFour + "\n6                               " + resultFive + 
				"\n7                               " + resultSix + "\n8                               " + resultSeven + 
				"\n9                               " + resultEight + "\n10                             " + 
				resultNine + "\n11                             " + resultTen + "\n12                             " + 
				resultEleven, "Dice Statistics", 3);
		
		
		
		
			
	}
}