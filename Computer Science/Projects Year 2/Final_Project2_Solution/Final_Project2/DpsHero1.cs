using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project2
{
    public class DpsHero1 : IDpsCharacter
    {
        public int Cost = 0, Level = Properties.Settings.Default.DpsHero1Level, BaseDPS = Properties.Settings.Default.DpsHero1Level;
        public int Dps = 0, UpgradeCost = 500, UpgradeLevelRequirement = 10;
        public int DamageMultipliers = Properties.Settings.Default.DpsHero1Upgrades;
        public bool AttemptUpgrade(int Cash)
        {
            Form1.DpsHeroOne.UpdateCost();
            if (Cost > Cash) { return false; }
            else return true;
        }
        public void UpdateCost()
        {
            Cost = (int)(50 * Math.Pow(1.075, Properties.Settings.Default.DpsHero1Level));
        }
        public void UpdateDamage()
        {
            if (DamageMultipliers == 0)
            {
                Dps = BaseDPS;
                UpgradeCost = 500;
                UpgradeLevelRequirement = 10;
            }
            else if (DamageMultipliers == 1)
            {
                Dps = BaseDPS * 2;
                UpgradeCost = 1250;
                UpgradeLevelRequirement = 25;
            }
            else if (DamageMultipliers == 2)
            {
                Dps = BaseDPS * 4;
                UpgradeCost = 5000;
                UpgradeLevelRequirement = 50;
            }
            else if (DamageMultipliers == 3)
            {
                Dps = BaseDPS * 8;
                UpgradeCost = 40000;
                UpgradeLevelRequirement = 75;
            }
            else if (DamageMultipliers == 4)
            {
                Dps = BaseDPS * 8;
                UpgradeCost = 80000;
                UpgradeLevelRequirement = 100;
            }
        }
        public DpsHero1()
        {
            UpdateCost();
            UpdateDamage();
        }
    }
}