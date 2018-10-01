import java.util.Scanner;
public class TempConverter {
	// This program will convert Fahrenheit to Celsius with User Input
    // By Ethan Lawrence 10/1/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner reader = new Scanner(System.in);
        double fahrenheit;
        double celsius;
        
        System.out.println("This program will convert degrees Fahrenheit to degrees Celsius");
        System.out.print("Enter degrees Fahrenheit: ");
        fahrenheit = reader.nextDouble();
        celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
        System.out.print("The equivalent in Celsius is ");
        System.out.println(celsius);
	}

}
