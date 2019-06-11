import java.util.Scanner;

public class GCDFun {
	// This program will allow the user to find the greatest common denominator of 2 numbers
    // By Ethan Lawrence 01/08/2019
	// elawrence152@gmail.com
	public static void main(String[] args) {

        Scanner userInput = new Scanner(System.in);
        
        //Stating what the program does
        System.out.println("This program will allow the user to find the greatest common denominator of 2 numbers.");
        
        // Getting the user inputs (as absolute numbers)
        System.out.print("Please enter the first integer: ");
        int numberOne = Math.abs(userInput.nextInt());
        System.out.print("Please enter the second integer: ");
        int numberTwo = Math.abs(userInput.nextInt());
        
        //Prints the greatest common denominator
        System.out.println("The greatest common denominator is: " + getGreatestCommonDenominator(numberOne, numberTwo));
        
        
	}

	// Public static method used to return the greatest common denominator
	public static int getGreatestCommonDenominator(int numberOne, int numberTwo)
	{
	    // Getting the greater value
	    if (numberOne > numberTwo)
        {
	    	// Setting up a for loop
            for (int i = numberTwo; i >= 1; i--)
            {
            	// Seeing if a number is a denominator, and if it is the value is returned
                if (numberOne % i == 0 && numberTwo % i == 0) return i;
            }
        }
	    // If numberOne is not greater use this else statement
        else
        {
        	// Setting up a for loop
            for (int j = numberOne; j >=1; j--)
            {
            	// Seeing if a number is a denominator, and if it is the value is returned
                if (numberOne % j == 0 && numberTwo % j == 0) return j;
            }
        } 
	    // If no number is found then the greatest common denominator is shown as "1"
	    return 1;

	}
}
