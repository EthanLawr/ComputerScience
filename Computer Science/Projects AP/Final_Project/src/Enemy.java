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
		{
			"9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
			"Basic Skeleton,punched you,60,10,16,10,5,30"
		},
		{
			"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
			"Axe Skeleton,swung it's axe at you,50,30,11,13,8,50"
		},
		{
			"9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
			"Fire Caster Skeleton,shot fire at you,40,25,20,5,10,50"
		},
		{
			"9+1+%south%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
			"Knight Skeleton,swung it's sword at you,80,20,6,239,20,125"
		},
			{
					"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
					"Knight Skeleton,swung it's sword at you,43,20,6,532,60,125"
			},
			{
					"9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
					"Knight Skeleton,swung it's sword at you,75,20,6,60,20,125"
			},
		{
			"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
			"Basic Skeleton,punched you,45,10,16,10,5,30"
		},
		{
			"9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
			"Basic Skeleton,punched you,91,10,16,10,5,30"
		},
		{
			"9+1+%southwest%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
			"Axe Skeleton,swung it's axe at you,43,30,11,13,8,50"
		},
		{
			"9+1+%southeast%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
			"Fire Caster Skeleton,shot fire at you,23,25,20,5,10,50"
		},
		{
			"9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
			"Axe Skeleton,swung it's axe at you,49,30,11,13,8,50"
		},
		{
			"9+1+%northwest%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
			"Fire Caster Skeleton,shot fire at you,49,25,20,5,10,50"
		},
		{
			"9+1+%west%~Skeleton Hideout~You ventured further and came upon a golden skeleton.",
			"Golden Skeleton,punched you,100,20,30,30,50,10"
		},
			{
					"9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
					"Basic Skeleton,punched you,60,10,16,10,5,30"
			},
			{
					"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
					"Axe Skeleton,swung it's axe at you,50,30,11,13,8,50"
			},
			{
					"9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
					"Fire Caster Skeleton,shot fire at you,40,25,20,5,10,50"
			},
			{
					"9+1+%south%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
					"Knight Skeleton,swung it's sword at you,80,20,6,239,20,125"
			},
			{
					"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
					"Knight Skeleton,swung it's sword at you,43,20,6,532,60,125"
			},
			{
					"9+1+%east%~Skeleton Hideout~You ventured further and came upon a skeleton with a long sword and knights armor.",
					"Knight Skeleton,swung it's sword at you,75,20,6,60,20,125"
			},
			{
					"9+1+%west%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
					"Basic Skeleton,punched you,45,10,16,10,5,30"
			},
			{
					"9+1+%north%~Skeleton Hideout~You ventured further and came upon a skeleton that has no items.",
					"Basic Skeleton,punched you,91,10,16,10,5,30"
			},
			{
					"9+1+%southwest%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
					"Axe Skeleton,swung it's axe at you,43,30,11,13,8,50"
			},
			{
					"9+1+%southeast%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
					"Fire Caster Skeleton,shot fire at you,23,25,20,5,10,50"
			},
			{
					"9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a skeleton with an axe.",
					"Axe Skeleton,swung it's axe at you,49,30,11,13,8,50"
			},
			{
					"9+1+%northwest%~Skeleton Hideout~You ventured further and came upon a skeleton with fire coming from its hands.",
					"Fire Caster Skeleton,shot fire at you,49,25,20,5,10,50"
			},
			{
					"9+1+%west%~Skeleton Hideout~You ventured further and came upon a golden skeleton.",
					"Golden Skeleton,punched you,100,20,30,30,50,10"
			},
		{
			"9+1+%northwest%~Skeleton Hideout~You ventured further and came upon a red potion.",
			"Potion"
		},
		{
			"9+1+%southeast%~Skeleton Hideout~You ventured further and came upon a green potion.",
			"Potion2"
		},
		{
			"9+1+%north%~Skeleton Hideout~You ventured further and came upon a orange potion.",
			"Potion1"
		},
		{
			"9+1+%east%~Skeleton Hideout~You ventured further and came upon a black potion.",
			"Potion2"
		},
		{
			"9+1+%north%~Skeleton Hideout~You ventured further and came upon a red potion.",
			"Potion"
		},
		{
			"9+1+%southwest%~Skeleton Hideout~You ventured further and came upon a green potion.",
			"Potion2"
		},
		{
			"9+1+%northeast%~Skeleton Hideout~You ventured further and came upon a orange potion.",
			"Potion1"
		},
		{
			"9+1+%west%~Skeleton Hideout~You ventured further and came upon a black potion.",
			"Potion2"
		},

	};
}
