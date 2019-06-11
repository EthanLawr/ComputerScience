public class ThisMeansWar {
	// This program will make a game of war
    // By Ethan Lawrence 12/11/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		System.out.println("This program will make a game of war.");

		// Defining variables and classes
		warClass Human = new warClass();
		warClass Computer = new warClass();		
		
		for (int i = 0; i < 5; i++) {
			int humanDraw = Human.drawCard(), computerDraw = Computer.drawCard();
			Human.userRoll(humanDraw);
		    Computer.userRoll(computerDraw);
		    if (humanDraw > computerDraw) {
		    	Human.userWin(humanDraw, computerDraw);
		    }
		    else if (computerDraw > humanDraw) {
		    	Computer.userWin(humanDraw, computerDraw);
		    }
		    while (humanDraw == computerDraw){
		    	int human1 = Human.userRoll(Human.drawCard()), human2 = Human.userRoll(Human.drawCard()),
						human3 = Human.userRoll(Human.drawCard()), humanLeftover = humanDraw;
				humanDraw = Human.drawCard(); 
				
				int computer1 = Computer.userRoll(Computer.drawCard()), computer2 = Computer.userRoll(Computer.drawCard()),
						computer3 = Computer.userRoll(Computer.drawCard()), computerLeftover = humanDraw;
				computerDraw = Computer.drawCard();
				if (humanDraw > computerDraw) {
			    	Human.userWin(humanDraw, computerDraw);
			    	Human.userWin(human1, computer1);
			    	Human.userWin(human2, computer2);
			    	Human.userWin(human3, computer3);
			    	Human.userWin(humanLeftover, computerLeftover);
			    }
			    else if (computerDraw > humanDraw) {
			    	Computer.userWin(humanDraw, computerDraw);
			    	Computer.userWin(human1, computer1);
			    	Computer.userWin(human2, computer2);
			    	Computer.userWin(human3, computer3);
			    	Computer.userWin(humanLeftover, computerLeftover);
			    }
		    }
		}
		
		int humanCards = Human.resultAce + Human.resultEight + Human.resultFive + Human.resultFour + Human.resultJack +
				Human.resultKing + Human.resultNine + Human.resultQueen + Human.resultSeven + Human.resultSix +
				Human.resultTen + Human.resultThree + Human.resultTwo;
		int computerCards = Computer.resultAce + Computer.resultEight + Computer.resultFive + Computer.resultFour + Computer.resultJack +
				Computer.resultKing + Computer.resultNine + Computer.resultQueen + Computer.resultSeven + Computer.resultSix +
				Computer.resultTen + Computer.resultThree + Computer.resultTwo;
		
		System.out.println("The computer won " + computerCards + " cards.");
		System.out.println("You won " + humanCards + " cards.");
		if (humanCards > computerCards) System.out.println("You won the game of war!");
		else System.out.println("You lost the game of war!");

		
			
	}

}
