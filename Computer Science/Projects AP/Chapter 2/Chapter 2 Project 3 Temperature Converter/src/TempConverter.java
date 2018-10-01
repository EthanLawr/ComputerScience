import java.util.Scanner;
public class TempConverter {
	// This program will say Hello World with a mug!
    // By Ethan Lawrence 9/27/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        Scanner reader = new Scanner(System.in);
        double fahrenheit;
        double celsius;
        
        System.out.print("Enter degrees Fahrenheit:");
        fahrenheit = reader.nextDouble();
        celsius = (fahrenheit - 32.0)*5.0/9.0;
        System.out.print("The equivalent in Celsious is ");
        System.out.println(celsius);
	}

}
