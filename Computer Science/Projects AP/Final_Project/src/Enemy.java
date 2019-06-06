
public class Enemy {
	public static double Health = 0, Attack = 0, Speed = 0, HealthRemaining = 0, Defense = 0, Level = 1, Exp = 0;
	public static String Name = "", AttackName = "";
	public Enemy() {
		
	}
	public static void newEnemy(String name, String attackName, int hp, int attk, int speed, int def, int lvl, int exp) {
		Name = name;
		AttackName = attackName;
		Health = hp;
		Attack = attk;
		Speed = speed;
		HealthRemaining = hp;
		Defense = def;
		Level = lvl;
		Exp = exp;
	}
	public static String[][] SkeletonBaseLayout = { 
			{ "9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items" },
			{ "Basic Skeleton,punched you,30,10,16,10,5,30"}
	};
}
