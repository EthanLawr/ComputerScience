import java.util.Arrays;
import java.util.Scanner;

public class ModeArray {
	/* Ethan Lawrence
	 * 2/6/2019
	 * This program will get the mode,median, and frequency of 10 numbers */
	
	public static void main(String[] args) 
    { 
        Scanner userInput = new Scanner(System.in);
        double[] arrayBase = new double[10];
        double valueCheck = 0;

        System.out.println("This program will get the mode, median, and frequency of 10 numbers");
        System.out.print("Please enter 10 numbers to obtain the mode, median, and frequency of: ");
        
        for (int i = 0; i < arrayBase.length; i++) {
        	arrayBase[i]=userInput.nextInt();
        }
        
        System.out.println("The mode is: " + mode(arrayBase));
        System.out.println("The median is: " + median(arrayBase));

        System.out.println("Here is a table of the numbers entered.");
        for (double d : arrayBase) {
        	if (d == valueCheck) System.out.print(d + " ");
        	else {
        		valueCheck = d;
        		System.out.print("\n" + d + " ");
        	}
        }
        System.out.println();
        System.out.println("Here are the frequencies.");
        frequency(arrayBase, arrayBase.length);
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
		
		if (x.length % 2 == 0){
			median = ((double)x[x.length/2] + (double)x[x.length/2 - 1])/2;
		    return median;
		}	else {
			median = ((double)x[x.length/2] + (double)x[x.length/2 - 1])/2;
		    return median;
		}
			
	}

	public static void frequency(double arr[], int n) 
	{ 
	    boolean numbersUsed[] = {false, false, false, false, false, false, false, false, false, false}; 
	  
	    for (int i = 0; i < n; i++) { 
	  
	        if (numbersUsed[i] == true) continue; 
	  
	        int count = 1; 
	        for (int j = i + 1; j < n; j++) { 
	            if (arr[i] == arr[j]) { 
	            	numbersUsed[j] = true; 
	                count++; 
	            } 
	        } 
	        System.out.println(arr[i] + ": " + count); 
	    }
	} 
}
