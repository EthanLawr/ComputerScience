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
		x.add("fight");
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
			} else if(x.trim().equals("kill")) System.out.print("Kill who?");
			else {
				System.out.print("Select something valid to kill");
			}
			//String Response = TextAdventure.userInputMethod("Kill Who?");
			//if (Response.equals("self") || Response.equals("me")) {
				
				
			//}
		} else if (x.startsWith("fight")) {
			
			if (x.substring(6).equals("goblin") && StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 0) {
				Fight(0);
			} else {
				System.out.print("Fight who?");
			}
		} else {
			System.out.print("Please enter something valid to do! Your input (" + TextAdventure.input + ") " +
		"was not recognized as a command!");
		}
	}
	
	public void Move(String x) {
    	if (Arrays.stream(TextAdventure.PlayerPosition.directionsArray).anyMatch(x::equals)) {
    		if (StoryFileReader.lineLookedFor == 1) {
    			if (TextAdventure.PlayerPosition.MovementCheck(x, "north")) MoveHelper(2);
    			else if (TextAdventure.PlayerPosition.MovementCheck(x, "south")) MoveHelper(3);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 2) {
    			if (TextAdventure.PlayerPosition.MovementCheck(x, "south")) MoveHelper(1);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 3) {
    			if (TextAdventure.PlayerPosition.MovementCheck(x, "north")) MoveHelper(1); 
    			else if (TextAdventure.PlayerPosition.MovementCheck(x, "west")) MoveHelper(4);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 4) {
    			if (x.equals("east")) MoveHelper(3);
    			else System.out.print("You can't move in that direction!");
    		}
    		
    	}
    }
	public void MoveHelper(int x) {
		try {
			StoryFileReader StoryReader = new StoryFileReader(x, TextAdventure.PlayerPosition);
			System.out.print(TextAdventure.PlayerPosition.roomDescription);
			TextAdventure.PlayerPosition.DirectionDisplay();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
	}

	public void Fight(int x) { 
		if (x == 0) {
			Enemy.newEnemy(30, 18, 3, 10, 1);
			Enemy.HealthRemaining = 13;
			System.out.print("The enemy has " + Enemy.HealthRemaining + " health left. What will you do?\n" +
					"You can do the following: attack");
			while (Enemy.HealthRemaining > 0 && Player.HealthRemaining > 0) {
				TextAdventure.userInputMethod(">");
				if (TextAdventure.input.equals("attack")) {
					// (ArmorValue) / ( 200 + ( (HeroLvl) * 20) )
					int damage = (int)(Player.Attack - (Player.Attack * (Enemy.Defense / (200 + (Enemy.Level*20)))));
					Enemy.HealthRemaining -= damage;
					System.out.println("You punched the goblin and did " + damage + " damage. The goblin now has " + 
					Enemy.HealthRemaining + " health left.");
					if (Enemy.HealthRemaining > 0) {
						int enemyDamage = (int)(Enemy.Attack - (Enemy.Attack * (Player.Defense / (200 + (Player.Level*20)))));
						Player.HealthRemaining -= enemyDamage;
						System.out.println("The goblin stabbed you and did " + enemyDamage + " damage. You now have " + 
								Player.HealthRemaining + " health left.");	
					} else {
						Player.Level = 2;
						System.out.print("Congratulations! You have defeated the goblin and gained 20 Exp. You are now " + 
					"level 2. The knife it was holding dropped on the ground.");
					}
					
				}
			}
		}
	}
}
