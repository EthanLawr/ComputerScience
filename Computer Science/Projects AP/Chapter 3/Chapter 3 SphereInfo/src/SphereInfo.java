import java.util.Scanner;

public class SphereInfo {
	// This program will make a calculation for the information of a sphere
    // By Ethan Lawrence 10/12/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner userInput = new Scanner(System.in);
		System.out.println("This program will find the stats of a sphere.");
		System.out.print("Please enter the unit of length: ");
		String units = userInput.nextLine();
        System.out.print("Please enter the radius of the sphere (double): ");
        double radius = userInput.nextDouble(); 
        double diameter = radius * 2.000, circumference = radius * 3.141 * 2, 
        		area = radius * 3.141 * radius * 4, volume = 4/3 * 3.141 * radius * radius * radius;
        System.out.println("The diameter is: " + (int)diameter + " " + units + "²" + "\n" +
        		"The circumference is: " + (int)circumference + " " + units + "\n" +
        		"The surface area is: " + (int)area + " " + units + "²" + "\n" +
        		"The volume is: " + (int)volume + " " + units + "3" + "\n");
	}

}
