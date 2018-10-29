import java.util.*;
public class PayRate {
	// This program will calculate the user's pay
    // By Ethan Lawrence 10/29/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        System.out.println("This program will calculate the user's pay.");
        Scanner UserInput = new Scanner(System.in);
        System.out.print("Please enter how many hours you worked: ");
        double hours = UserInput.nextDouble();
        System.out.print("Please enter how much you get paid per hour (In american dollars): ");
        double wage = UserInput.nextDouble(), overtime = (Math.max(hours, 40) - 40) * wage * 1.5,
        payment = (double)((int)((Math.min(hours, 40) * wage + overtime) * 100)) / 100;
        hours = (double)((int)(hours * 100)) / 100; // Rounding for standardized hour formatting on jobs
        System.out.print("You got $" + payment + " over the time of " + hours + " hours.");
	}

}
