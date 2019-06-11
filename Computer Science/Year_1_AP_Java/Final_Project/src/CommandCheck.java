import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

@SuppressWarnings("unused")
public class CommandCheck {
	public boolean AliveOrPlaying = true;
	public static Random randy = new Random();
	public CommandCheck(ArrayList < String > x) {
		// Setting up commands
		for (String s: Location.allDirectionNames) x.add(s);
		x.add("help");
		x.add("go");
		x.add("kill");
		x.add("fight");
		x.add("look");
		x.add("run");
		x.add("loot");
		x.add("inventory");
		x.add("equip");
		x.add("pick-up");
		x.add("i");
		x.add("stats");
	}
	public void CommandSeek(String x) throws IOException {
		x = x.trim();
		if (Arrays.stream(Location.allDirectionNames).anyMatch(x::equals)) {
			Move(x);
		} else if (x.startsWith("go")) {
			if (x.equals("go")) System.out.print("Go where?");
			x = x.substring(3);
			for (String s: Location.allDirectionNames)
				if (x.equals(s)) {
					Move(x);
				} // some movement
		} else if (x.equals("help")) {
			for (int i = 0; i < TextAdventure.Commands.size(); i++) {
				System.out.print(TextAdventure.Commands.get(i) + " ");
				if (i % 15 == 0 && i >= 15) System.out.println();
			}
		} else if (x.startsWith("kill")) {
			if (x.equals("kill me") || x.equals("kill self") || x.equals("kill myself")) {
				if (Player.weapon.equals("Hands")) {
					System.out.println("You tried to strangle yourself but ended up passing out instead...");
					StoryFileReader.ResetProgressionPartial();
					MoveHelper(1);
				} else if (Player.weapon.equals("Knife")) {
					System.out.println("You stabbed yourself and died.");
					StoryFileReader.ResetProgressionPartial();
					Player.Exp = 0;
					Player.Level = 0;
					MoveHelper(1);
				}
			} else if (x.trim().equals("kill")) System.out.print("Kill who?");
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
			TextAdventure.ArrayListSort(Player.Inventory);
			if (x.equals("equip knife") && Player.Inventory.get(0).equals("Knife") && !Player.weapon.equals("Knife")) {
				Player.weapon = "Knife";
				System.out.print("Equipped a knife. You now have more attack.");
				Player.CheckStats();
			} else if (x.equals("equip knife") && Player.weapon.equals("Knife")) {
				System.out.print("You already have the knife equipped.");
			} else {
				System.out.print("Enter something valid to equip!");
			}
		} else if (x.startsWith("inventory") || x.startsWith("i")) {
			TextAdventure.ArrayListSort(Player.Inventory);
			if (Player.Inventory.size() == 0) System.out.println("You have no items at this time.");
			else {
				System.out.println("You have the following items: ");
				for (int i = 0; i < Player.Inventory.size(); i++) System.out.print(Player.Inventory.get(i) + " ");
			}
		} else if (x.startsWith("loot") || x.startsWith("pick up") || x.startsWith("pick-up")) {
			x = x.startsWith("loot") ? x.substring(4) : x.substring(7);
			x = x.trim();
			if (x.equals("all")) {
				if (StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 1) {
					System.out.print("You picked the knife up. ");
					StoryFileReader.OverWriteLine("4+1+%east%~Dead end~There used to be an injured goblin here. Now there is only a knife.",
						"4+2+%east%~Dead end~There used to be an injured goblin here.");
					Player.Inventory.add("Knife");
					TextAdventure.Commands.add("cut");
					TextAdventure.ArrayListSort(TextAdventure.Commands);
					System.out.print("You have a new command! You can now use CUT!");
					StoryFileReader StoryReader = new StoryFileReader(4, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else if (StoryFileReader.lineLookedFor == 2 && Location.stateOfRoom == 0) {
					System.out.print("You picked up some rope.");
					StoryFileReader.OverWriteLine("2+0+%south%~Head of the Hideout~This is the head of the hideout. There is a rope on the floor.",
						"2+0+%south%~Head of the Hideout~This is the head of the hideout. There is nothing here.");
					Player.Inventory.add("Rope");
					StoryFileReader StoryReader = new StoryFileReader(2, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else if ((StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 1) || (StoryFileReader.lineLookedFor == 2 && Location.stateOfRoom == 0)) {
					System.out.print("Pick what up?");
				} else
					System.out.print("There's nothing to pick up.");
			} else if (x.equals("knife")) {
				if (StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 1) {
					System.out.print("You picked the knife up. ");
					StoryFileReader.OverWriteLine("4+1+%east%~Dead end~There used to be an injured goblin here. Now there is only a knife.",
						"4+2+%east%~Dead end~There used to be an injured goblin here.");
					Player.Inventory.add("Knife");
					TextAdventure.Commands.add("cut");
					TextAdventure.ArrayListSort(TextAdventure.Commands);
					System.out.print("You have a new command! You can now use CUT!");
					StoryFileReader StoryReader = new StoryFileReader(4, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else {
					System.out.print("There's no knife!");
				}
			} else if (x.equals("rope")) {
				if (StoryFileReader.lineLookedFor == 2 && Location.stateOfRoom == 0) {
					System.out.print("You picked up some rope.");
					StoryFileReader.OverWriteLine("2+0+%south%~Head of the Hideout~This is the head of the hideout. There is a rope on the floor.",
						"2+0+%south%~Head of the Hideout~This is the head of the hideout. There is nothing here.");
					Player.Inventory.add("Rope");
					StoryFileReader StoryReader = new StoryFileReader(2, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else {
					System.out.print("There's no rope to pick up!");
				}
			} else {
				System.out.print("There's nothing to pick up!");
			}
		} else if (x.startsWith("fight")) {
			if (x.trim().equals("fight")) {
				System.out.print("Fight who?");
			} else if (x.substring(6).equals("goblin") && StoryFileReader.lineLookedFor == 4 && Location.stateOfRoom == 0) {
				Fight(0);
			} else if (x.substring(6).equals("skeleton") && StoryFileReader.lineLookedFor == 7 && Location.stateOfRoom == 0) {
				Fight(1);
			} else if (x.substring(6).equals("spirit") || x.substring(6).equals("glowing spirit") &&
				StoryFileReader.lineLookedFor == 7 && (Location.stateOfRoom == 0 || Location.stateOfRoom == 1)) {
				Fight(2);
			} else {
				System.out.print("Fight who?");
			}
		} else if (x.startsWith("cut") && TextAdventure.Commands.contains("cut")) {
			if (x.trim().equals("cut")) {
				System.out.print("Cut who or what?");
			} else if (x.trim().equals("cut vines")) {
				if (StoryFileReader.lineLookedFor == 5 && Location.stateOfRoom == 0) {
					System.out.print("You cut the vines up revealing a pathway to the outside world");
					StoryFileReader.OverWriteLine("5+0+%west%~Vine Filled Dead end~There is a barricade of vines that can be cut with a knife here. There must be a knife somewhere around here...",
						"5+1+%west, northeast, northwest, north%~Outside of the Hideout Territory~There is an intersection ahead.");
					StoryFileReader StoryReader = new StoryFileReader(5, TextAdventure.PlayerPosition);
				} else if (StoryFileReader.lineLookedFor == 5 && Location.stateOfRoom != 0) {
					System.out.println("You already cut the vines here!");
				} else {
					System.out.print("There are no vines to cut");
				}
			} else {
				System.out.print("Please enter something valid to cut");
			}
		} else if (x.startsWith("look")) {
			if (StoryFileReader.lineLookedFor == 8 && Location.stateOfRoom == 0) {
				System.out.print("The old man started to talk. He showed you the path to light. He knew everything. Then suddenly he was gone and you were" +
					"\nout of your vision, but still in a trance. The tree was gone too. All that was left was some armor where the tree used to be. " +
					"\nYou picked up the armor, and you were still in a trance. You then put it on without a second thought. Suddenly a shrine appeared as you put it on." +
					"\nEquipped Armor. Your defense was raised. You may also heal yourself here.");
				Player.armor = "Magic Armor";
				TextAdventure.Commands.add("heal");
				TextAdventure.ArrayListSort(TextAdventure.Commands);
				StoryFileReader.OverWriteLine("8+0+%southeast,east%~Prophet Tree~There is a large tree that has blue glowing leaves here and an old man too. He seems like he might be dangerous. |His aura has great magical power.",
					"8+1+%southeast,east%~Prophet Shrine~There is a shrine here. You may heal yourself when you want to here.");
				StoryFileReader StoryReader = new StoryFileReader(8, TextAdventure.PlayerPosition);
			} else MoveHelper(StoryFileReader.lineLookedFor);
		} else if (x.startsWith("heal")) {
			if (StoryFileReader.lineLookedFor == 8 && Location.stateOfRoom == 1) {
				Player.HealthRemaining = Player.Health;
				System.out.print("You have fully restored your health");
			} else System.out.print("You can't do that here!");
		} else if (x.startsWith("stats")) {
			Player.DisplayStats();
			System.out.print("\nWeapon: " + Player.weapon + "\tArmor: " + Player.armor);
		} else {
			System.out.print("Please enter something valid to do! Your input (" + TextAdventure.input + ") " +
				"was not recognized as a command!");
		}
	}

	public void Move(String x) throws IOException {
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
				else if (Location.MovementCheck(x, "east")) MoveHelper(5);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 4) {
				if (Location.MovementCheck(x, "east")) MoveHelper(3);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 5) {
				if (Location.MovementCheck(x, "west")) MoveHelper(3);
				else if (Location.MovementCheck(x, "northwest") && Location.stateOfRoom != 0) MoveHelper(8);
				else if (Location.MovementCheck(x, "north") && Location.stateOfRoom != 0) MoveHelper(7);
				else if (Location.MovementCheck(x, "northeast") && Location.stateOfRoom != 0) MoveHelper(6);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 6) {
				if (Location.MovementCheck(x, "west")) MoveHelper(7);
				else if (Location.MovementCheck(x, "southwest")) MoveHelper(5);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 7) {
				if (Location.MovementCheck(x, "east")) MoveHelper(6);
				else if (Location.MovementCheck(x, "south")) MoveHelper(5);
				else if (Location.MovementCheck(x, "west")) MoveHelper(8);
				else if (Location.MovementCheck(x, "down") && Location.stateOfRoom != 0) MoveHelper(9);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 8) {
				if (Location.MovementCheck(x, "east")) MoveHelper(7);
				else if (Location.MovementCheck(x, "southeast")) MoveHelper(5);
				else System.out.print("You can't move in that direction!");
			} else if (StoryFileReader.lineLookedFor == 9) {

				if (Location.MovementCheck(x, Location.directionsArray[0])) {
					if (Player.randomlyGeneratedRoomsEntered > 10) {
						if (randy.nextInt(5) == 0) {
							MoveHelper(0);
							Fight(4);
						} else {
							Fight(3);
						}
					}else Fight(3);

				}
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

	public void Fight(int x) throws IOException {
		if (x == 0) {
			Enemy.newEnemy("Injured Goblin", "stabbed you with a knife", 30, 18, 3, 10, 1, 20);
			Enemy.HealthRemaining = 13;
			boolean winner = Player.Fight();
			if (winner) {
				System.out.print("\nThe knife it was holding dropped onto the ground.\n");
				Player.LevelUp();
				StoryFileReader.OverWriteLine("4+0+%east%~Goblin's Last Stand~There is a small goblin with a dagger in front of you. You can try knocking it out to get its dagger, and it's pretty beat up. |You can choose to fight or run.",
					"4+1+%east%~Dead end~There used to be an injured goblin here. Now there is only a knife.");
				StoryFileReader StoryReader = new StoryFileReader(4, TextAdventure.PlayerPosition);
				TextAdventure.PlayerPosition.DirectionDisplay();
			} else {
				MoveHelper(1);
			}
		} else if (x == 1) {
			Enemy.newEnemy("Guard Skeleton", "stabbed you with a spear", 80, 25, 10, 70, 5, 30);
			boolean winner = Player.Fight();
			if (winner) {
				System.out.print("You may now enter the hideout.");
				Player.LevelUp();
				StoryFileReader.OverWriteLine("7+0+%west,south,east,down%~Skeleton Hideout Entrance~There is a skeleton guarding a large hole in the ground, guarding it. |You can either fight it to get inside the hole or run away.",
					"7+1+%west,south,east,down%~Skeleton Hideout Entrance~There is a large hole in the ground that you can go into.");
				StoryFileReader StoryReader = new StoryFileReader(7, TextAdventure.PlayerPosition);
				TextAdventure.PlayerPosition.DirectionDisplay();
			} else {
				StoryFileReader.ResetProgressionPartial();
				Player.Exp = 0;
				Player.Level = 0;
				Player.HealthRemaining = 100;
				MoveHelper(1);
			}
		} else if (x == 2) {
			Enemy.newEnemy("Angelic Knight", "shot you with a beam of light", 300, 50, 40, 100, 20, 500);
			boolean winner = Player.Fight();
			if (winner) {
				Player.LevelUp();
				if (Location.stateOfRoom == 0) {
					StoryFileReader.OverWriteLine("6+0+%southwest,west%~The Great Door~There is a set of doors that are tall as buildings in front of you, guarded by two yellow glowing spirits.",
						"6+1+%southwest,west%~The Great Door~There is a set of doors that are tall as buildings in front of you, guarded by one yellow glowing spirit.");
					StoryFileReader StoryReader = new StoryFileReader(6, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else if (Location.stateOfRoom == 1) {
					System.out.println("The doors appeared to open as the spirit dissipated in the wind...");
					StoryFileReader.OverWriteLine("6+1+%southwest,west%~The Great Door~There is a set of doors that are tall as buildings in front of you, guarded by one yellow glowing spirit.",
						"6+2+%southwest,west,east%~The Great Door~There is a set of doors that are tall as buildings in front of you, but they are open. Beyond them are glowing fields that look like heaven.");
					StoryFileReader StoryReader = new StoryFileReader(6, TextAdventure.PlayerPosition);
					TextAdventure.PlayerPosition.DirectionDisplay();
					TextAdventure.CommandInstructor.AliveOrPlaying = false;
				}
			} else {
				StoryFileReader.ResetProgressionPartial();
				Player.Exp = 0;
				Player.Level = 0;
				MoveHelper(1);
				Player.HealthRemaining = 100;
			}
		} else if (x == 3) {
			Player.randomlyGeneratedRoomsEntered++;
			int i = randy.nextInt(Enemy.SkeletonBaseLayout.length);
			String[] SpawnSkelly = Enemy.SkeletonBaseLayout[i][1].split(",");
			//Enemy.SkeletonBaseLayout[i][0]
			String desc = Enemy.SkeletonBaseLayout[i][0].substring(Enemy.SkeletonBaseLayout[i][0].lastIndexOf('~')+1);
			System.out.println(desc);
			StoryFileReader.OverWriteLine(Location.roomDescription, desc);
			StoryFileReader.OverWriteLine("9+0+%" + Location.directionsArray[0], "9+0+%" +Enemy.SkeletonBaseLayout[i][0]
					.substring(Enemy.SkeletonBaseLayout[i][0].indexOf('%') + 1, Enemy.SkeletonBaseLayout[i][0].lastIndexOf('%')));
			StoryFileReader StoryReader = new StoryFileReader(9, TextAdventure.PlayerPosition);

			if (SpawnSkelly[0].startsWith("Potion")) {
				String Answer = ForceQuestion("Would you like to drink the potion? (yes/no)");
				if (Answer.equals("yes")) {
					if (SpawnSkelly[0].equals("Potion1")) {
						System.out.print("\nYou drank the potion and felt greater than ever! You feel stronger somehow...");
						Player.Exp += ((Math.pow(Player.Level, 1.75) + 20 * (Player.Level + 1)) - Player.Exp);
						Player.LevelUp();
						TextAdventure.PlayerPosition.DirectionDisplay();
					} else if (SpawnSkelly[0].equals("Potion")) {
						System.out.print("\nYou drank the potion and feel restored. Your health has been completely returned.");
						TextAdventure.PlayerPosition.DirectionDisplay();
					} else if (SpawnSkelly[0].equals("Potion2")) {
						System.out.print("\nYou drank the potion and feel nauseous. You suddenly passed out.");
						MoveHelper(1);
						StoryFileReader.ResetProgressionPartial();
						Player.randomlyGeneratedRoomsEntered = 0;
					}
				} else {
					TextAdventure.PlayerPosition.DirectionDisplay();
				}

			} else {
				Enemy.newEnemy(SpawnSkelly[0], SpawnSkelly[1], Integer.parseInt(SpawnSkelly[2]), Integer.parseInt(SpawnSkelly[3]),
					Integer.parseInt(SpawnSkelly[4]), Integer.parseInt(SpawnSkelly[5]), Integer.parseInt(SpawnSkelly[6]),
					Integer.parseInt(SpawnSkelly[7]));
				boolean winner = Player.Fight();
				if (winner) {
					Player.LevelUp();
					TextAdventure.PlayerPosition.DirectionDisplay();
				} else {
					MoveHelper(1);
					StoryFileReader.ResetProgressionPartial();
					Player.randomlyGeneratedRoomsEntered = 0;
				}
			}


		} else if (x == 4) {

			Enemy.newEnemy("Giant Death Knight", "struck you with it's great sword", 500, 80, 4, 300, 100, 300);
			System.out.println("");
			Player.CheckStats();
			System.out.print("As the large being gets ready to fight you, you can't help but feel you are especially powerful right now. \nYou took a look at your stats a second before the fight.");
			Player.DisplayStats();
			System.out.println("");
			boolean winner = Player.Fight();
			if (winner) {
				Enemy.Name = "None";
				Player.CheckStats();
				Player.LevelUp();
				if (Player.Inventory.contains("Rope")) {
					System.out.println("\nYou used your rope to get out of the boss hideout! Now that you were " +
							"strong there were only two opponents left to fight. The spirits.");
					Player.Inventory.remove("Rope");
					System.out.print("\nYou no longer have rope.");
					MoveHelper(7);
				} else {
					System.out.print("You have no rope! You are stuck here until you die!");
					StoryFileReader.ResetProgressionPartial();
					Player.Exp = 0;
					Player.Level = 0;
					MoveHelper(1);
					Player.HealthRemaining = 100;
				}

			} else {
				StoryFileReader.ResetProgressionPartial();
				Player.Exp = 0;
				Player.Level = 0;
				MoveHelper(1);
			}
		}
	}

	public String ForceQuestion(String x) {
			Scanner userInput = new Scanner(System.in);
			System.out.print(x);
			String string = userInput.nextLine();
			string = string.toLowerCase().trim();
			if (!string.equals("yes") && !string.equals("no")) {
				System.out.print("Enter a valid answer (yes/no)\n");
				ForceQuestion(x);
			}
			return string;
	}
}