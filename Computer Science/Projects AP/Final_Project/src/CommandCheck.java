import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;

public class CommandCheck {

	public boolean AliveOrPlaying = true;
	public CommandCheck(ArrayList<String> x) {
		// Setting up commands
		for (String s : Location.allDirectionNames) x.add(s);
		x.add("help");
		x.add("go");
		x.add("kill");
	}
	public void CommandSeek(String x) {
		if (Arrays.stream(Location.allDirectionNames).anyMatch(x::equals)) {
			Move(x);
		}
		else if (x.startsWith("go ")) {
			x = x.substring(3);
			for (String s : Location.allDirectionNames) if (x.equals(s)) { Move(x);} // some movement
		} else if (x.equals("help")) {
			for (int i=0; i < TextAdventure.Commands.size(); i++) System.out.print(TextAdventure.Commands.get(i) + " ");
		} else if (x.startsWith("kill")){
			if (x.equals("kill me") || x.equals("kill self")) {
				System.out.println("You tried to strangle yourself but ended up passing out instead...");
				try {
					StoryFileReader StoryReader = new StoryFileReader(1, TextAdventure.PlayerPosition);
					System.out.print(TextAdventure.PlayerPosition.roomDescription);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				}
			}
			//String Response = TextAdventure.userInputMethod("Kill Who?");
			//if (Response.equals("self") || Response.equals("me")) {
				
				
			//}
		} else {
			System.out.print("Please enter something valid to do! Your input (" + TextAdventure.input + ") " +
		"was not recognized as a command!");
		}
	}
	public  void Move(String x) {
    	if (Arrays.stream(TextAdventure.PlayerPosition.directionsArray).anyMatch(x::equals)) {
    		if (StoryFileReader.lineLookedFor == 1) {
    			if (x.equals("north")) {
    				try {
						StoryFileReader StoryReader = new StoryFileReader(2, TextAdventure.PlayerPosition);
						System.out.print(TextAdventure.PlayerPosition.roomDescription);
	    				TextAdventure.PlayerPosition.DirectionDisplay();
					} catch (FileNotFoundException e) {
						e.printStackTrace();
					}
    				
    			}
    		} else if (StoryFileReader.lineLookedFor == 2) {
    			if (x.equals("south")) {
    				try {
						StoryFileReader StoryReader = new StoryFileReader(1, TextAdventure.PlayerPosition);
						System.out.print(TextAdventure.PlayerPosition.roomDescription);
	    				TextAdventure.PlayerPosition.DirectionDisplay();
					} catch (FileNotFoundException e) {
						e.printStackTrace();
					}
    				
    			}
    		}
    	}
    }
	
}
