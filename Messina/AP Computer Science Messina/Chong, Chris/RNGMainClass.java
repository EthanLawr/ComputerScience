import java.util.Random;
import java.util.Scanner;
public class RNGMainClass {
	/* Chapter 6 - Random Number Generator and Predictor
	 * This program is intended to generate a random number and make user predictions
	 * Questions? Email me - christophermchong@gmail.com
	 */
	//10 digits = colder, 5 digits = warmer,
	public static void main(String[] args) {
		Random random = new Random();
		Scanner reader = new Scanner(System.in);
		//Number is between 1 and 100 (default is 99 to 0 inclusive)
		//Add 1 in order to offset the default
		int randomNumber = random.nextInt(99) + 1;
		System.out.println("Enter a number between 1 and 100: ");
		int userInput = reader.nextInt();
		// if 1 <= userInput <= 100
		if (randomNumber >= 1 && randomNumber <= 100)
		{
			if (userInput == randomNumber)
			{
				System.out.println("You guessed it!!!! You was right!!!!!!");
			}
			else if (userInput > randomNumber)
			{
				System.out.println("You are much colder");
				if (userInput - 10 <= randomNumber)
				{
					System.out.println("You're getting warmer");
					if(userInput - 5 <= randomNumber)
					{
						System.out.println("You're good! You're good! You're good!");
					}
				}
			}
			else if (userInput < randomNumber)
			{
				System.out.println("You are getting colder");
				if (userInput + 10 >= randomNumber)
				{
					System.out.println("You're getting warmer");
					if (userInput + 5 >= randomNumber)
					{
						System.out.println("You're on fire!");
					}
				}
			}
			else
			{
				System.out.println("Fallthrough");
			}
		}
		else
		{
		System.out.println("This is not a proper value!");
		}
	}
}