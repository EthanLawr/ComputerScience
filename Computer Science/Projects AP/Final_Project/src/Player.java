import java.util.ArrayList;

public class Player {

	public static double Health = 100, Exp = 0, Attack = 10, Speed = 10, HealthRemaining = 100, Defense = 10, Level = 1;
	public static ArrayList<String> Inventory = new ArrayList<String>();
	public static String weapon = "Hands";
	public Player() {
		
	}
	public static void CheckStats() {
		if (weapon.equals("Hands")) Attack = 10;
		if (weapon.equals("Knife")) Attack = 15;
	}
}
