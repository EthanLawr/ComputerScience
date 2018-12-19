import java.io.*;
import java.util.Scanner;

public class StarRoids {
	// This program will show what movies a star wars character was in
    // By Ethan Lawrence 12/18/2018
	// elawrence152@gmail.com
	public static void main(String[] args) throws IOException
	{
		System.out.println("This program will show what movies a star wars character was in");
		
		Scanner userInput = new Scanner(System.in);
        Scanner sc = new Scanner(new File("C:\\Users\\1005939\\workspace\\StarRoids\\src\\Characters.txt"));

		
	    System.out.print("Please enter a Star Wars character name.");
	    String userInputText = userInput.nextLine();
        while(sc.hasNextLine()){
        	String someLine = sc.nextLine();
            String someLowerCaseLine = someLine.toLowerCase();
        	if(someLowerCaseLine.contains(userInputText.toLowerCase())) {
                System.out.println(someLine);
                break;
        	}
        }
	}

}