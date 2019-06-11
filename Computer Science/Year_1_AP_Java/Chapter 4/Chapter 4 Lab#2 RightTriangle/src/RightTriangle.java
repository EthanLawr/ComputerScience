import java.util.Scanner;

public class RightTriangle {
	// This program will find out what type of triangle 3 sides make.
        // By Ethan Lawrence 11/5/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Double hypotenuse, opposite, adjacent;
		Scanner userInput = new Scanner(System.in);
		String rightCheck = "not a right triangle.";
		System.out.println("This program will find out what type of triangle 3 sides make.");
		
		// This block of code will collect a user input to get the side's lengths
		System.out.print("Please enter the first side: ");
		Double sideOne = userInput.nextDouble();
		System.out.print("Please enter the second side: ");
		Double sideTwo = userInput.nextDouble();
		System.out.print("Please enter the third side: ");
		Double sideThree = userInput.nextDouble();
		
		
		// These if and else statements will find out the sides of a triangle and single out the hypotenuse.
		if (sideOne > sideTwo && sideOne > sideThree) {
			hypotenuse = sideOne;
			opposite = sideTwo;
			adjacent = sideThree;
		} else if (sideTwo > sideOne && sideTwo > sideThree) {
			hypotenuse = sideTwo;
			opposite = sideOne;
			adjacent = sideThree;
		} else if (sideThree > sideOne && sideThree > sideTwo) {
			hypotenuse = sideThree;
			opposite = sideOne;
			adjacent = sideTwo;
		} else {
			hypotenuse = sideOne;
			opposite = sideTwo;
			adjacent = sideThree;
		}
		
		// These if statements will show if a triangle exists and what type of triangle it is if it does exist.
		if (adjacent * adjacent + opposite * opposite == hypotenuse * hypotenuse) rightCheck = "a right triangle.";
	    if (adjacent * adjacent + opposite * opposite > hypotenuse * hypotenuse) rightCheck = "an acute triangle.";
	    if (adjacent * adjacent + opposite * opposite < hypotenuse * hypotenuse) rightCheck = "an obtuse triangle.";
	    if (adjacent + opposite > hypotenuse) System.out.println("This triangle is " + rightCheck);
	    else System.out.println("These sides do not make a triangle");
        
	}

}
