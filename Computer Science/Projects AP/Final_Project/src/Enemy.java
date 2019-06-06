
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
		{ "9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.","Basic Skeleton,punched you,30,10,16,10,5,30" },
		{ "9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.","Axe Skeleton,swung it's axe at you,30,30,11,13,8,50"},
		{ "9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.","Fire Caster Skeleton,shot fire at you,20,25,20,5,10,50"},
		{ "9+1+%south%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor","Knight Skeleton,swung it's sword at you,40,20,6,40,20,125"},
		{ "9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.","Basic Skeleton,punched you,30,10,16,10,5,30" },
		{ "9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.","Basic Skeleton,punched you,30,10,16,10,5,30" },
		{ "9+1+%southwest%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.","Axe Skeleton,swung it's axe at you,30,30,11,13,8,50"},
		{ "9+1+%southeast%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.","Fire Caster Skeleton,shot fire at you,20,25,20,5,10,50"},
		{ "9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.","Axe Skeleton,swung it's axe at you,30,30,11,13,8,50"},
		{ "9+1+%northwest%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.","Fire Caster Skeleton,shot fire at you,20,25,20,5,10,50"},
		{ "9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with a key","Key holder,punched you,30,10,20,15,3,20"},
		{ "9+1+%northwest%~Skeleton Hideout~You ventured further and came upon a red potion","Potion"},
		{ "9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a purple potion","Potion"},
		{ "9+1+%southeast%~Skeleton Hideout~You ventured further and came upon a green potion","Potion"},
		{ "9+1+%north%~Skeleton Hideout~You ventured further and came upon a orange potion","Potion"},
		{ "9+1+%east%~Skeleton Hideout~You ventured further and came upon a black potion","Potion"},
		{ "9+1+%north%~Skeleton Hideout~You ventured further and came upon a red potion","Potion"},
		{ "9+1+%south%~Skeleton Hideout~You ventured further and came upon a purple potion","Potion"},
		{ "9+1+%southwest%~Skeleton Hideout~You ventured further and came upon a green potion","Potion"},
		{ "9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a orange potion","Potion"},
		{ "9+1+%west%~Skeleton Hideout~You ventured further and came upon a black potion","Potion"},

	};
}
