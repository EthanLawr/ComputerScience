import java.util.*;

public class ArrayAverage {
	/* Ethan Lawrence
	 * 2/4/2019
	 * This program will get the average of 10 numbers */
	public static void main(String[] args) 
    { 
        Scanner userInput = new Scanner(System.in);
        double[] arrayBase = new double[10];
        double average = 0;

        System.out.println("This program will get the average of 10 numbers");
        System.out.print("Please enter 10 numbers to obtain the average of: ");
        
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i]=userInput.nextInt();
        for (double d : arrayBase) average += d;
        average /= arrayBase.length;
        System.out.println("The average is: " + average);
        System.out.print("Numbers greater than the average: ");
        for(double i : arrayBase) if (average < i) System.out.print(i + " ");
        userInput.close();
    } 
}
