import java.util.Scanner;

public class Momentum {
	// This program will calculate momentum
    // By Ethan Lawrence 10/3/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner userinput = new Scanner(System.in);
		System.out.print("This program will calculate momentum\nPlease enter a mass (in kg): ");
		double mass = userinput.nextDouble();
		System.out.print("Please enter a velocity (in meters per second): ");
		double velocity = userinput.nextDouble();
		System.out.print("The momentum is " + mass*velocity + "kgm/s");
	}

}
