using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            healthMax = (int)(10 * (wave / 2 + Math.Pow(1.55 + randy.Next(-10, 11) / 1000.00, wave / 2)));
            if (wave % 10 == 0)
            {
                healthMax *= 10;
                boss = true;
            }
            else
            {
                boss = false;
            }
            healthRemaining = healthMax;
        }
        public int GoldReward()
        {
            return healthMax / 15 + 1;
        }
    }
}
