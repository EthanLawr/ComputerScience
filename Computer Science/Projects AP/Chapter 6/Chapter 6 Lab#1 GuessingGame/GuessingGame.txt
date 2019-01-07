import java.util.Scanner;
import java.util.Random;

public class GuessingGame {
	// This program will allow the user to guess a random number
    // By Ethan Lawrence 01/04/2019
	// elawrence152@gmail.com
	public static void main(String[] args) {

        Random randomize = new Random();
        Scanner userInput = new Scanner(System.in);
        
        String tempSaying = " ";
        int randomNumber = randomize.nextInt(101);
        
        System.out.print("This program will allow the user to guess a random number.");
        
        System.out.print("Enter a guess (1-100): ");
        int guess = userInput.nextInt();
        
        while (guess != randomNumber) {
        	
              if (guess < randomNumber) {
            	  if (guess + 10 >= randomNumber) tempSaying = " You are also getting warmer!";
            	  if (guess + 5 >= randomNumber) tempSaying = " You are also getting hotter!";
                  System.out.println("Your guess is smaller than the number." + tempSaying);
                  tempSaying = " ";

              }  
              else if (guess > randomNumber){
            	  if (guess - 10 <= randomNumber) tempSaying = " You are also getting warmer!";
            	  if (guess - 5 <= randomNumber) tempSaying = " You are also getting hotter!";
                  System.out.println("Your guess is greater than the number." + tempSaying);
            	  tempSaying = " ";
              }
              guess = userInput.nextInt();

        } 
        System.out.println("That's right!");
	}

}
