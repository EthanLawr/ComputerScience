import java.util.Scanner;

public class LeapYear {
	// This program will find if a user entered year is a leap year.
    // By Ethan Lawrence 11/09/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		Scanner userInput = new Scanner(System.in);
		boolean leapYear;
		
		System.out.println("This program will find if a user entered year is a leap year.");
		
		System.out.print("Please enter a year (Whole number): ");
		int year = userInput.nextInt();
        
        // Checks for if an entered year is a leap year using nested if and else statements and modulus
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                	leapYear = true;
                else
                	leapYear = false;
            }
            else
            	leapYear = true;
        }
        else
        	leapYear = false;

        
        if (year < 0)
        	// Positive year check
        	System.out.println("Please restart the program and enter a valid year");
        else if (leapYear)
        	// If leapYear is true then it will display that the user entered value is a leap year
            System.out.println("The year " + year + " is a leap year.");
        else
        	// If leapYear is false then it will display that the user entered value is not a leap year
            System.out.println("The year " + year + " is not a leap year.");
	}

}
