import java.util.Scanner;

public class reversewords {
	// Ethan Lawrence
    // This program will will reverse characters in a string
	// 3/27/2019
	// elawrence152@gmail.com
		
		public static void main(String[] args) {
            Scanner userInput = new Scanner(System.in);

			System.out.println("This program will will reverse characters in a string");

			System.out.print("Please enter a string to reverse: ");
			String stringInput = userInput.nextLine();
			
			System.out.print("Please enter an index: ");
			int intInput = userInput.nextInt();
			
			String reversedText = reverse(stringInput, intInput);

	        System.out.print("The reverse of  \"" + stringInput + "\" with the index " + intInput + " is \"" + reversedText + "\".");
	        
		}
    	public static String result = "";
        public static String reverse(String stringToReverse, int index){
        	if (index < stringToReverse.length()) {
        		String subStringOne = stringToReverse.substring(0,index), subStringTwo = stringToReverse.substring(index);
        		for(int i = subStringOne.length() - 1; i >= 0; i--) result = result + subStringOne.charAt(i);
        		reverse (subStringTwo, subStringTwo.length());
        	} else for(int i= stringToReverse.length() - 1; i >= 0; i--) result = result + stringToReverse.charAt(i);
            return result;
        }
	}