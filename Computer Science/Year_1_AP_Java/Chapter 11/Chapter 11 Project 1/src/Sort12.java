import java.util.*;

public class Sort12 {
	// Ethan Lawrence
	// This program will will sort a list and display it as well as the original list
	// 3/12/2019
	// elawrence152@gmail.com
	
	public static void main(String[] args) {
		int[] intArray = new int[12];
		int lengthOfArray = intArray.length;
		
		System.out.println("This program will will sort a list and display it as well as the original list of integers");
		
		for (int i = 0; i < lengthOfArray; i++)  intArray[i] = userInputMethod("Please enter a valid integer: ");
		
		System.out.println("Here is your original unsorted array: ");
		printArray(intArray);

		for (int i = 0; i < lengthOfArray-1; i++) 
        { 
            // Find the minimum element in the given unsorted array 
            int minimum = i; 
            for (int j = i+1; j < lengthOfArray; j++) if (intArray[j] < intArray[minimum]) minimum = j; 
  
            // Swap the found minimum element with the first element 
            int temp = intArray[minimum]; 
            intArray[minimum] = intArray[i]; 
            intArray[i] = temp;
        }
		
		System.out.println("Here is your sorted array: ");
		printArray(intArray);

	}
	
	 // Method for a Nasty Gram in a user input
    public static int userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print(x);
            int number = userInput.nextInt();
            return number;
        } catch (Exception e) {
            System.out.print("You entered an invalid integer. ");
            return userInputMethod(x);
        }
    }

    // Shortens the amount of code used to print arrays
    public static void printArray(int[] someArray) {
    	for (int x : someArray) System.out.print(x + " ");
    	System.out.println();
    }
}