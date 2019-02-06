import java.util.Arrays;
import java.util.Scanner;

public class ModeArray {
	/* Ethan Lawrence
	 * 2/6/2019
	 * This program will get the mode of 10 numbers */
	public static void main(String[] args) 
    { 
        Scanner userInput = new Scanner(System.in);
        double[] arrayBase = new double[10];

        System.out.println("This program will get the mode of 10 numbers");
        System.out.print("Please enter 10 numbers to obtain the mode of: ");
        
        for (int i = 0; i < arrayBase.length; i++) arrayBase[i]=userInput.nextInt();
        
        System.out.println("The mode is: " + mode(arrayBase));
        System.out.println("The median is: " + median(arrayBase));

        userInput.close();
    } 
	
	public static double mode(double[] x) {
	    double mode = x[0];
	    int maxCount = 0;
	    for (int i = 0; i < x.length; i++) {
	        double value = x[i];
	        int count = 1;
	        for (int j = 0; j < x.length; j++) {
	            if (x[j] == value) count++;
	            if (count > maxCount) {
	                mode = value;
	                maxCount = count;
	            }
	        }
	    }
	    return mode;
	}
	
	public static double median(double[] x) {
		Arrays.sort(x);
		double median;
		if (x.length % 2 == 0)
		    return median = ((double)x[x.length/2] + (double)x[x.length/2 - 1])/2;
		else
		    return median = (double) x[x.length/2];
	}
}
