using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project2
{
    public class DpsHero2 : IDpsCharacter
    {
        public int Cost = 0, Level = Properties.Settings.Default.DpsHero2Level, BaseDPS = Properties.Settings.Default.DpsHero2Level*22;
        public int Dps = 0, UpgradeCost = 2500, UpgradeLevelRequirement = 10;
        public int DamageMultipliers = Properties.Settings.Default.DpsHero2Upgrades;
        public bool AttemptUpgrade(int Cash)
        {
            Form1.DpsHeroOne.UpdateCost();
            if (Cost > Cash) { return false; }
            else return true;
        }
        public void UpdateCost()
        {
            Cost = (int)(250 * Math.Pow(1.075, Properties.Settings.Default.DpsHero2Level));
        }
        public void UpdateDamage()
        {
            BaseDPS = Properties.Settings.Default.DpsHero2Level * 22;
            if (DamageMultipliers == 0)
            {
                Dps = BaseDPS;
                UpgradeCost = 2500;
                UpgradeLevelRequirement = 10;
            }
            else if (DamageMultipliers == 1)
            {
                Dps = BaseDPS *2 ;
                UpgradeCost = 6250;
                UpgradeLevelRequirement = 25;
            }
            else if (DamageMultipliers == 2)
            {
                Dps = BaseDPS * 4;
                UpgradeCost = 25000;
                UpgradeLevelRequirement = 50;
            }
            else if (DamageMultipliers == 3)
            {
                Dps = BaseDPS* 8;
                UpgradeCost = 200000;
                UpgradeLevelRequirement = 75;
            }
            else if (DamageMultipliers == 4)
            {
                Dps = BaseDPS * 16;
                UpgradeCost = 2000000;
                UpgradeLevelRequirement = 100;
            }
        }
        public DpsHero2()
        {
            UpdateCost();
            UpdateDamage();
        }
    }
}