import java.util.ArrayList;

public class Player {

	public static double Health = 100, Exp = 0, Attack = 10, Speed = 10, HealthRemaining = 100, Defense = 10, Level = 0;
	public static ArrayList<String> Inventory = new ArrayList<String>();
	public static String weapon = "Hands";
	public static String armor = "Nothing";
	public Player() {
		
	}
	public static void LevelUp() {
		Level += 1;
		System.out.println("You leveled up to level " + NForm(Level) + " and your health has been restored!");
		CheckStats();
		HealthRemaining = Health;
		DisplayStats();
	}
	public static void CheckStats() {
		if (weapon.equals("Hands")) Attack = 10;
		if (weapon.equals("Knife")) Attack = 15;
		Attack += Level;
		Health = 100 + (5*Level);
		if (Player.armor.equals("Magic Armor")) {
			Defense = 10 + (5*Level) + 100;
		} else Defense = 10 + (5*Level);
		Speed = 10 + (2*Level);
	}
	public static void DisplayStats() {
		CheckStats();
		System.out.print("Health Remaining: " + NForm(HealthRemaining) + "\tDefense: " + NForm(Defense) + 
				"\nAttack: " + NForm(Attack) + "\tSpeed: " + NForm(Speed));
	}
	public static int NForm(double x) {
    	return (int)Math.round(x);
    }
}
