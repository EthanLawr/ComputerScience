import java.util.Scanner;
public class SurfaceCube {
	// This program will make a calculation for the surface of a cube
    // By Ethan Lawrence 10/12/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner userInput = new Scanner(System.in);
		System.out.println("This program will find the surface area of a cube.");
		System.out.print("Please enter the unit of length: ");
		String units = userInput.nextLine();
        System.out.print("Please enter the length of an edge (integer): ");
        int side = userInput.nextInt();
        int area = side * side * 6;
        System.out.println("The surface area is: " + area + " " + units + "²");
	}

}
