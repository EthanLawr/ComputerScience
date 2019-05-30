import java.io.FileNotFoundException;
import java.io.IOException;
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
		x.add("look");
		x.add("run");
		x.add("loot");
		x.add("inventory");
		x.add("equip");
	}
	public void CommandSeek(String x) throws IOException {
		if (Arrays.stream(Location.allDirectionNames).anyMatch(x::equals)) {
			Move(x);
		}
		else if (x.startsWith("go ")) {
			x = x.substring(3);
			for (String s : Location.allDirectionNames) if (x.equals(s)) { Move(x);} // some movement
		} else if (x.equals("help")) {
			for (int i=0; i < TextAdventure.Commands.size(); i++) {
				System.out.print(TextAdventure.Commands.get(i) + " ");
				if (i % 15 == 0) System.out.println();
			}
		} else if (x.startsWith("kill")){
			if (x.equals("kill me") || x.equals("kill self") || x.equals("kill myself")) {
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
		} else if (x.startsWith("run")) {
			if (StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 0) {
				MoveHelper(3);
			} else {
				System.out.println("There's nothing to run from!");
			}
		} else if (x.startsWith("equip")) {
			if (x.equals("equip knife") && Player.Inventory.get(0).equals("Knife")) {
				Player.weapon = "Knife";
			    Player.CheckStats();
			} else {
				System.out.println("Enter something valid to equip!");
			}
		} else if (x.startsWith("inventory")) {
			if (Player.Inventory.size() == 0) System.out.println("You have no items at this time.");
			else {
				System.out.println("You have the following items: ");
				for (int i = 0; i < Player.Inventory.size(); i++) System.out.print(Player.Inventory.get(i));
				System.out.println();
			}
		} else if (x.startsWith("loot")) {
			if (x.equals("all")) {
				if (StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 1) {
					System.out.println("You picked up a knife.");
					StoryFileReader.OverWriteLine("4+1+%east%~Dead end~There used to be an injured goblin here. Now there is only a knife.",
						"4+2+%east%~Dead end~There used to be an injured goblin here.");
					Player.Inventory.add("Knife");
				}
			} else {
				System.out.println("There's nothing to pick up!");
			}
		} else if (x.startsWith("fight")) {
			if (x.trim().equals("fight")) {
				System.out.print("Fight who?");
			}
			else if (x.substring(6).equals("goblin") && StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 0) {
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
    	if (Arrays.stream(Location.allDirectionNames).anyMatch(x::equals)) {
    		if (StoryFileReader.lineLookedFor == 1) {
    			if (Location.MovementCheck(x, "north")) MoveHelper(2);
    			else if (Location.MovementCheck(x, "south")) MoveHelper(3);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 2) {
    			if (Location.MovementCheck(x, "south")) MoveHelper(1);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 3) {
    			if (Location.MovementCheck(x, "north")) MoveHelper(1); 
    			else if (Location.MovementCheck(x, "west")) MoveHelper(4);
    			else System.out.print("You can't move in that direction!");
    		} else if (StoryFileReader.lineLookedFor == 4) {
    			if (Location.MovementCheck(x, "east")) MoveHelper(3);
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
					if (Enemy.HealthRemaining > 0) {
					System.out.println("You punched the goblin and did " + damage + " damage. The goblin now has " + 
					Enemy.HealthRemaining + " health left.");
						int enemyDamage = (int)(Enemy.Attack - (Enemy.Attack * (Player.Defense / (200 + (Player.Level*20)))));
						Player.HealthRemaining -= enemyDamage;
						System.out.println("The goblin stabbed you and did " + enemyDamage + " damage. You now have " + 
								Player.HealthRemaining + " health left.");	
					} else {
						Player.Level = 2;
						System.out.println("You punched the goblin and did " + damage + " damage.");
						System.out.print("Congratulations! You have defeated the goblin and gained 20 Exp. You are now " + 
					"level 2.\nThe knife it was holding dropped onto the ground.");
						StoryFileReader.OverWriteLine("4+0+%east%~Goblin's Last Stand~There is a small goblin with a dagger in front of you. You can try knocking it out to get its dagger, and it's pretty beat up. |You can choose to fight or run.\r\n", 
							"4+1+%east%~Dead end~There used to be an injured goblin here. Now there is only a knife.");
						
					}
					
				}
			}
		}
	}
}
