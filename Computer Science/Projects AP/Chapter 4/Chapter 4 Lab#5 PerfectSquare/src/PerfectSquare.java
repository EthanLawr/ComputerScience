import java.util.Scanner;

public class PerfectSquare {
	// This program will out if an entered number is a perfect square.
    // By Ethan Lawrence 11/12/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		Scanner userInput = new Scanner(System.in);
		
		System.out.println("This program will out if an entered number is a perfect square.");
		
		// Asks for the number and also declares the numbers needed for the display and calculations
		System.out.print("Please enter a number (Whole number): ");
		int number = userInput.nextInt();
		double perfect = Math.sqrt(number);
        
        if (number < 0)
        	// Positive number check
        	System.out.println("Please restart the program and enter a valid year");
        else if (Math.round(perfect) > perfect || Math.round(perfect) < perfect)
        	// If a number is not a perfect square root
        	System.out.println(number + " is not a perfect square root.");
        else 
        	// If a number is a perfect square root
        	System.out.println(number + " is a perfect square root.");
    	
	}

}
