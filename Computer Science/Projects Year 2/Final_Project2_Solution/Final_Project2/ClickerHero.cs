using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project2
{
    public class ClickerHero
    {
        public int Cost = 0, Level = Properties.Settings.Default.CashClickLevel, BaseDamagePerClick = Properties.Settings.Default.CashClickLevel;
        public int DamagePerClick = 0, UpgradeCost = 100, UpgradeLevelRequirement = 10;
        public int DamageMultipliers = Properties.Settings.Default.ClickerHeroUpgrades;
        public bool AttemptUpgrade(int Cash)
        {
            Form1.ClickingHero.UpdateCost();
            if (Cost > Cash) { return false; }
            else return true;
        }
        public void UpdateCost()
        {
            Cost = Level > 15 ? (int)(20 * Math.Pow(1.075, Properties.Settings.Default.CashClickLevel)) : (int)((5 + Level) * Math.Pow(1.07, Level - 1));
        }
        public void UpdateDamage()
        {
            if (DamageMultipliers == 0)
            {
                DamagePerClick = BaseDamagePerClick;
                UpgradeCost = 100;
                UpgradeLevelRequirement = 10;
            } else if (DamageMultipliers == 1)
            {
                DamagePerClick = BaseDamagePerClick * 2;
                UpgradeCost = 250;
                UpgradeLevelRequirement = 25;
            } else if (DamageMultipliers == 2)
            {
                DamagePerClick = BaseDamagePerClick * 4;
                UpgradeCost = 1000;
                UpgradeLevelRequirement = 50;
            } else if (DamageMultipliers == 3)
            {
                DamagePerClick = BaseDamagePerClick * 8;
                UpgradeCost = 8000;
                UpgradeLevelRequirement = 75;
            }
            else if (DamageMultipliers == 4)
            {
                DamagePerClick = BaseDamagePerClick * 16;
                UpgradeCost = 80000;
                UpgradeLevelRequirement = 100;
            }
        }
        public ClickerHero()
        {
            UpdateCost();
            UpdateDamage();
        }
    }
}
