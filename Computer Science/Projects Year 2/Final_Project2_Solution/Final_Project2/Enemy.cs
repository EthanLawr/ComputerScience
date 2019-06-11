using System;

namespace Final_Project2
{
    public class Enemy
    {
        private Random randy = new Random();
        public int healthMax = 0;
        public double healthRemaining = 0;
        public bool boss = false;
        public void EnemyUnit(int wave)
        {
            // Health formula
            healthMax = (int)(10 * (wave / 2 + Math.Pow(1.55 + randy.Next(-10, 11) / 1000.00, wave / 2)));
            // Checks for bosses
            if (wave % 10 == 0)
            {
                healthMax *= 10;
                boss = true;
            }
            else boss = false;
            healthRemaining = healthMax;
        }
        public int GoldReward()
        {
            // Cash reward formula
            return healthMax / 15 + 1;
        }
    }
}
