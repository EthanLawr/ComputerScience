
public class Enemy {
	public static double Health = 0, Attack = 0, Speed = 0, HealthRemaining = 0, Defense = 0, Level = 1;
	public Enemy() {
		
	}
	public static void newEnemy(int hp, int attk, int speed, int def, int lvl) {
		Health = hp;
		Attack = attk;
		Speed = speed;
		HealthRemaining = hp;
		Defense = def;
		Level = lvl;
		
	}
}
