import java.util.Scanner;

public class BatAvg {
	// This program will make a calculation for batting averages
    // By Ethan Lawrence 10/15/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner userInput = new Scanner(System.in);
		System.out.println("This program will find the batting average of someone.");
		System.out.print("Please enter the number of bats (Integer): ");
		int bats = userInput.nextInt();
        System.out.print("Please enter the number of hits (Integer): ");
        int hits = userInput.nextInt();
        double battingAverage = (double)((int)(((double)bats)/((double)hits)*1000))/1000;
        System.out.println("The batting average for someone with " + bats + " bats and " +
        hits + " hits is: " + battingAverage);
	}

}
