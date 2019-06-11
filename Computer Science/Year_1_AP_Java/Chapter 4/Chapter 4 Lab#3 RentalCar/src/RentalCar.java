import java.util.Scanner;

public class RentalCar {
	// This program will find out the cost of renting a car in american dollars.
    // By Ethan Lawrence 11/08/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		Scanner userInput = new Scanner(System.in);
		int cost = 517, fee = 120 + cost, dayse = 7;
		double total = 0, tax = 0.06;
		
		System.out.println("This program will find out the cost of renting a car in american dollars.");
		
		System.out.print("Please enter the amount of days the car was rented for (Whole Number greater than zero): ");
		int days = userInput.nextInt();
		total += Math.min(days, dayse) * cost;
		total += (Math.max(days, dayse) - dayse) * fee;
		total += total * tax;
		total = Math.round(total * 100.0) / 100.0;
		String display  ="The total cost of renting a car over " + days + " days is $" + total + ".";
		if (days <= 0) display = "Please restart the program and enter a valid number of days.";
		System.out.print(display);
	}

}
