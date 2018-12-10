
public class DiceTotal {
	// This program will roll 100 dice
    // By Ethan Lawrence 12/7/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// Defining variables and classes
		DiceRoller diceRoller = new DiceRoller();
		int resultOne = 0, resultTwo = 0, resultThree = 0, resultFour = 0, resultFive = 0, 
				resultSix = 0, resultSeven = 0, resultEight = 0, resultNine = 0, resultTen = 0, resultEleven = 0;;
		
		
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
		System.out.println("This program will roll 100 dice.");
		
		System.out.println("Number Rolled\tFrequency\n2\t\t" + resultOne + "\n3\t\t" + resultTwo + "\n4\t\t" + resultThree +
				"\n5\t\t" + resultFour + "\n6\t\t" + resultFive + "\n7\t\t" + resultSix + "\n8\t\t" + resultSeven + "\n9\t\t" + 
				resultEight + "\n10\t\t" + resultNine + "\n11\t\t" + resultTen + "\n12\t\t" + resultEleven);
		
			
	}

}
