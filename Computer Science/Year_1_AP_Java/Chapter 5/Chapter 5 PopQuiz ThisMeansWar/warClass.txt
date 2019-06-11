import java.util.Random;

public class warClass {
	public int resultTwo = 2, resultThree = 2, resultFour = 2, resultFive = 2, 
			resultSix = 2, resultSeven = 2, resultEight = 2, resultNine = 2, resultTen = 2, resultJack = 2, 
            resultQueen = 2, resultKing = 2, resultAce = 2;
	
	public int userRoll(int x){
		if (x > 14 && x < 2) x = drawCard();
		if (x == 2 && resultTwo - 1 != -1) resultTwo--;
		else if (x == 3 && resultThree - 1 != -1) resultThree--;
		else if (x == 4 && resultFour - 1 != -1) resultFour--;
		else if (x == 5 && resultFive - 1 != -1) resultFive--;
		else if (x == 6 && resultSix - 1 != -1) resultSix--;
		else if (x == 7 && resultSeven - 1 != -1) resultSeven--;
		else if (x == 8 && resultEight - 1 != -1) resultEight--;
		else if (x == 9 && resultNine - 1 != -1) resultNine--;
		else if (x == 10 && resultTen - 1 != -1) resultTen--;
		else if (x == 11 && resultJack - 1 != -1) resultJack--;
		else if (x == 12 && resultQueen - 1 != -1) resultQueen--;
		else if (x == 13 && resultKing - 1 != -1) resultKing--;
		else if (x == 14 && resultAce - 1 != -1) resultAce--;
		else userRoll(drawCard());
		return x;
	}
	
	public void userWin(int x, int y){
		while (x <= 13) {
		if (x == 2&& resultTwo + 1 != 5) { resultTwo++; x += 13; }
		else if (x == 3&& resultThree + 1 != 5) { resultThree++; x += 13; }
		else if (x == 4&& resultFour + 1 != 5) { resultFour++; x += 13; }
		else if (x == 5&& resultFive + 1 != 5) { resultFive++; x += 13; }
		else if (x == 6&& resultSix + 1 != 5) { resultSix++; x += 13; }
		else if (x == 7&& resultSeven + 1 != 5) { resultSeven++; x += 13; }
		else if (x == 8&& resultEight + 1 != 5) { resultEight++; x += 13; }
		else if (x == 9&& resultNine + 1 != 5) { resultNine++; x += 13; }
		else if (x == 10&& resultTen + 1 != 5) { resultTen++; x += 13; }
		else if (x == 11&& resultJack + 1 != 5) { resultJack++; x += 13; }
		else if (x == 12&& resultQueen + 1 != 5) { resultQueen++; x += 13; }
		else if (x == 13&& resultKing + 1 != 5) { resultKing++; x += 13; }
		else if (x == 13&& resultAce + 1 != 5) { resultAce++; x += 13; }
		else x++;
		x += 13;
	    }
		while (y <= 13) {
		if (y == 2&& resultTwo + 1 != 5) { resultTwo++; y += 13; }
		else if (y == 3&& resultThree + 1 != 5) { resultThree++; y += 13; }
		else if (y == 4&& resultFour + 1 != 5) { resultFour++; y += 13; }
		else if (y == 5&& resultFive + 1 != 5) { resultFive++; y += 13; }
		else if (y == 6&& resultSix + 1 != 5) { resultSix++; y += 13; }
		else if (y == 7&& resultSeven + 1 != 5) { resultSeven++; y += 13; }
		else if (y == 8&& resultEight + 1 != 5) { resultEight++; y += 13; }
		else if (y == 9&& resultNine + 1 != 5) { resultNine++; y += 13; }
		else if (y == 10&& resultTen + 1 != 5) { resultTen++; y += 13; }
		else if (y == 11&& resultJack + 1 != 5) { resultJack++; y += 13; }
		else if (y == 12&& resultQueen + 1 != 5) { resultQueen++; y += 13; }
		else if (y == 13&& resultKing + 1 != 5) { resultKing++; y += 13; }
		else if (y == 13&& resultAce + 1 != 5) { resultAce++; y += 13; }
		else y++;
		y += 13;
	    }
	}
	public int drawCard(){
		Random randomizer = new Random();
		int theCard = randomizer.nextInt(15);
		while (theCard > 14 || theCard < 2) theCard = randomizer.nextInt(15);
		return theCard;
	}
	
	public static int random(){
		Random randomizer = new Random();
		int selection = randomizer.nextInt(3);
		while (selection > 2 || selection < 1) selection = randomizer.nextInt(2);
		return selection;
	}
}
