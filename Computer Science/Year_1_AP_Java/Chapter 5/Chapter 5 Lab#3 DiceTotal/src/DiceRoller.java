import java.util.Random;

public class DiceRoller {
	public int rollDie(){
		Random randomizer = new Random();
		int theDie = randomizer.nextInt(7);
		while (theDie > 6 || theDie < 1) theDie = randomizer.nextInt(7);
		return theDie;
	}
}
