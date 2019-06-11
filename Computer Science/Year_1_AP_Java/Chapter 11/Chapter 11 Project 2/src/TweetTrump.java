import java.util.*;

public class TweetTrump {
	// Ethan Lawrence
	// This program will ask a user to tweet to Trump
	// 3/18/2019
	// elawrence152@gmail.com
	
	public static void main(String[] args) {
		double counter = 0;
		
		System.out.println("This program will ask a user to tweet to Trump");
		String tweet = userInputMethod("Please enter something to tweet to President Trump: ");
		
		String[] tweetArray = tweet.split(" ");
        
		System.out.println("Here is your tweet: " + tweet);
		System.out.println("Total number of words: " + tweetArray.length);
		System.out.println("Total length of the tweet: " + tweet.length() + " characters");
		
		for (String x : tweetArray) counter += x.length();
		
		System.out.println("Average length of words: " + counter/tweetArray.length); 
	}
	
	 // Method for a Nasty Gram in a user input
    public static String userInputMethod(String x) {
        try {
            Scanner userInput = new Scanner(System.in);
            System.out.print(x);
            String string = userInput.nextLine();
            if (string.length() > 144) return userInputMethod("You entered an invalid string. Please enter one with less than 144 characters.");
            if (string.length() == 0) return userInputMethod("You must enter a string with atleast one character to tweet!");
            return string;
        } catch (Exception e) {
            System.out.print("You entered an invalid string. ");
            return userInputMethod(x);
        }
    }
}