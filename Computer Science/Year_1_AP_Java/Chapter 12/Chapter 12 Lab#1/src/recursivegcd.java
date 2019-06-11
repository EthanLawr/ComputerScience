import java.util.Scanner;

public class recursivegcd {
	// Ethan Lawrence
	// This program will get the Greatest Common Divisor of two integers
	// 3/27/2019
	// elawrence152@gmail.com
	
	public static void main(String[] args) {

		System.out.println("This program will get the Greatest Common Divisor of two integers.");
        int numberOne = userInputMethod("Please enter your first integer: "), 
        		numberTwo = userInputMethod("Please enter your second integer: ");
        int gcd = GreatestCommonDivisor(numberOne, numberTwo);

        System.out.printf("The Greatest Common Divisor of %d and %d is %d.", numberOne, numberTwo, gcd);
	}

	public static int userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print(x);
            int intInput = userInput.nextInt();
            if (intInput <= 0) return userInputMethod("You must enter an integer above 0: ");
            return intInput;
        } catch (Exception e) {
            System.out.print("You entered an invalid integer. ");
            return userInputMethod(x);
        }
    }


    public static int GreatestCommonDivisor(int x, int y)
    {
        if (y != 0)
            return GreatestCommonDivisor(y, x % y);
        else
            return x;
    }
}