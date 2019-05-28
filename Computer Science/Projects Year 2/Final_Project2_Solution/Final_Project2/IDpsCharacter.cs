using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project2
{
    interface IDpsCharacter
    {
        /*int Cost =  {
            Iget;
        ISet
    }
    Level = Properties.Settings.Default.DpsHero1Level, BaseDPS = Properties.Settings.Default.DpsHero1Level;
        int Dps = 0, UpgradeCost = 500, UpgradeLevelRequirement = 10;
        public int DamageMultipliers;
        */
        bool AttemptUpgrade(int Something);
        void UpdateCost();
        void UpdateDamage();
    }
}
