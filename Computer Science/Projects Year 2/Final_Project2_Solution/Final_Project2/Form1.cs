using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project2
{
    public partial class Form1 : Form
    {
      
        public static Enemy Patient = new Enemy();
        public static ClickerHero ClickingHero = new ClickerHero();
        public static DpsHero1 DpsHeroOne = new DpsHero1();
        public static DpsHero2 DpsHeroTwo = new DpsHero2();

        public static int cash = (int)Properties.Settings.Default.Cash, currentRound = Properties.Settings.Default.RoundMax, enemiesKilledThisRound = 0;
        public static double Dps = DpsHeroOne.Dps + DpsHeroTwo.Dps;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[][] newArray = new string[Properties.Settings.Default.Properties.Count][];
            int i = 0;
            string saveFileText = "";
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                saveFileText += currentProperty.Name + " " + Properties.Settings.Default[currentProperty.Name].ToString() + "\n";
            }
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("TextFile1.txt", true))
            {
                file.Write(saveFileText);
                file.Close();
            }
            
            //System.IO.File.Encrypt("TextFile1.txt");
            string text = System.IO.File.ReadAllText("TextFile1.txt");
            
            MessageBox.Show(saveFileText);

            this.Cursor = new Cursor(GetType(), "CustomMadeCursor.cur");
            Patient.EnemyUnit(Properties.Settings.Default.RoundMax);
            Invoke((MethodInvoker)delegate
            {
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 50;
                timer1.Start();
            });
            Invoke((MethodInvoker)delegate
            {
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 200;
                timer2.Start();
            });
            label1.Text = "Cash: $" + cash;
            label2.Text = "Level: " + string.Format("{0:#,##0.##}", ClickingHero.Level);
            label4.Text = "Current Round: " + currentRound.ToString();
            label8.Text = "Highest Round: " + Properties.Settings.Default.RoundMax;
            label13.Text = $"Click Damage: {string.Format("{0:#,##0.##}", ClickingHero.DamagePerClick)}";
            button3.Text = $"${string.Format("{0:#,##0.##}", DpsHeroOne.Cost)}";
            button2.Text = $"${string.Format("{0:#,##0.##}", ClickingHero.Cost)}";
            button8.Text = $"${string.Format("{0:#,##0.##}", DpsHeroTwo.UpgradeCost)}";
            button9.Text = $"${string.Format("{0:#,##0.##}", DpsHeroTwo.Cost)}";
            button5.Text = $"${string.Format("{0:#,##0.##}", ClickingHero.UpgradeCost)}";
            button7.Text = $"${string.Format("{0:#,##0.##}", DpsHeroOne.UpgradeCost)}";
            label11.Text = $"Level: {string.Format("{0:#,##0.##}", DpsHeroTwo.Level)}";
            label12.Text = $"Total Dps: {Dps}";
            label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining) + "/" + string.Format("{0:#,##0.##}", Patient.healthMax);
            progressBar1.Maximum = Patient.healthMax;
            progressBar1.Value = Patient.healthMax;
            ModifyProgressBarColor.SetState(progressBar1, 2);
            label7.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero1Level);
            //Properties.Settings.Default.Reset();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient.healthRemaining -= ClickingHero.DamagePerClick;
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    Patient.EnemyUnit(currentRound);
                    label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining);
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
                else
                {
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining);
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    enemiesKilledThisRound = 0;
                    if (Patient.boss) label10.Text = $"{enemiesKilledThisRound}/1 Enemy Killed";
                    else label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
            }
            else
            {
                progressBar1.Value = (int)Patient.healthRemaining;
                label5.Text = "Health Left: " + string.Format("{0:#,##0.00}", Patient.healthRemaining) + "/" + string.Format("{0:#,##0.##}", Patient.healthMax);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                if (i > Properties.Settings.Default.RoundMax) int.Parse("error");
                else
                {
                    currentRound = i;
                    Patient.EnemyUnit(currentRound);
                    label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining);
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    label4.Text = "Current Round: " + currentRound.ToString();
                }
#pragma warning disable CS0168 // Variable is declared but never used
            }
            catch (Exception f)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("That is not a valid round to go to.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Patient.healthRemaining -= Math.Round(Dps / 20.0000, 2);
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    Patient.EnemyUnit(currentRound);
                    label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining);
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
                else
                {
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    label5.Text = "Health Left: " + string.Format("{0:#,##0.##}", Patient.healthRemaining);
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    enemiesKilledThisRound = 0;
                    if (Patient.boss) label10.Text = $"{enemiesKilledThisRound}/1 Enemy Killed";
                    else label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
            }
            else
            {
                progressBar1.Value = (int)Patient.healthRemaining;
                label5.Text = "Health Left: " + string.Format("{0:#,##0.00}", Patient.healthRemaining) + "/" + string.Format("{0:#,##0.##}", Patient.healthMax);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cash > ClickingHero.UpgradeCost && ClickingHero.Level >= ClickingHero.UpgradeLevelRequirement && ClickingHero.DamageMultipliers <= 6)
            {
                cash -= ClickingHero.UpgradeCost;
                ClickingHero.DamageMultipliers++;
                ClickingHero.UpdateDamage();
                Properties.Settings.Default.Cash = cash;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                button5.Text = "$" + string.Format("{0:#,##0.##}", ClickingHero.UpgradeCost);
                Properties.Settings.Default.ClickerHeroUpgrades++;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Confirmation = MessageBox.Show("Do you really want to reset?", "Confirmation Message", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.Restart();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cash > DpsHeroOne.UpgradeCost && DpsHeroOne.Level >= DpsHeroOne.UpgradeLevelRequirement && DpsHeroOne.DamageMultipliers <= 5)
            {
                cash -= DpsHeroOne.UpgradeCost;
                DpsHeroOne.DamageMultipliers++;
                DpsHeroOne.UpdateDamage();
                Properties.Settings.Default.Cash = cash;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                button7.Text = "$" + string.Format("{0:#,##0.##}", DpsHeroOne.UpgradeCost);
                Properties.Settings.Default.DpsHero1Upgrades++;
                Dps = DpsHeroOne.Dps;

                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ClickingHero.UpdateDamage();
            ClickingHero.UpdateCost();
            DpsHeroOne.UpdateDamage();
            DpsHeroOne.UpdateCost();
            DpsHeroTwo.UpdateDamage();
            DpsHeroTwo.UpdateCost();
            Dps = DpsHeroOne.Dps + DpsHeroTwo.Dps;

            // Color changes if you can purchase the upgrade
            if (ClickingHero.Cost > cash) button2.BackColor = Color.DarkGray;
            else button2.BackColor = SystemColors.Control;
            if (ClickingHero.UpgradeCost > cash) button5.BackColor = Color.DarkGray;
            else button5.BackColor = SystemColors.Control;

            if (DpsHeroOne.Cost > cash) button3.BackColor = Color.DarkGray;
            else button3.BackColor = SystemColors.Control;
            if (DpsHeroOne.UpgradeCost > cash) button7.BackColor = Color.DarkGray;
            else button7.BackColor = SystemColors.Control;

            if (DpsHeroTwo.Cost > cash) button9.BackColor = Color.DarkGray;
            else button9.BackColor = SystemColors.Control;
            if (DpsHeroTwo.UpgradeCost > cash) button8.BackColor = Color.DarkGray;
            else button8.BackColor = SystemColors.Control;

            // Damage Updater
            label13.Text = $"Click Damage: {string.Format("{0:#,##0.##}", ClickingHero.DamagePerClick)}";
            label12.Text = $"Total Dps: {string.Format("{0:#,##0.##}", Dps)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClickingHero.AttemptUpgrade(cash))
            {
                cash -= ClickingHero.Cost;
                ClickingHero.BaseDamagePerClick++;
                Properties.Settings.Default.Cash = cash;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                label2.Text = "Level: " + string.Format("{0:#,##0.##}", ++Properties.Settings.Default.CashClickLevel);
                ClickingHero.UpdateCost();
                button2.Text = $"${string.Format("{0:#,##0.##}", ClickingHero.Cost)}";
                Properties.Settings.Default.Save();
                ClickingHero.Level = Properties.Settings.Default.CashClickLevel;
                ClickingHero.UpdateDamage();
            } else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cash > DpsHeroTwo.UpgradeCost && DpsHeroTwo.Level >= DpsHeroTwo.UpgradeLevelRequirement && DpsHeroTwo.DamageMultipliers <= 5)
            {
                cash -= DpsHeroTwo.UpgradeCost;
                DpsHeroTwo.DamageMultipliers++;
                DpsHeroTwo.UpdateDamage();
                Properties.Settings.Default.Cash = cash;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                button8.Text = "$" + string.Format("{0:#,##0.##}", DpsHeroTwo.UpgradeCost);
                Properties.Settings.Default.DpsHero2Upgrades++;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DpsHeroOne.AttemptUpgrade(cash))
            {
                Properties.Settings.Default.DpsHero1Level += 1;
                cash -= DpsHeroOne.Cost;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                label7.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero1Level);
                DpsHeroOne.Level = Properties.Settings.Default.DpsHero1Level;
                DpsHeroOne.UpdateCost();
                DpsHeroOne.UpdateDamage();
                Properties.Settings.Default.Cash = cash;
                button3.Text = $"${string.Format("{0:#,##0.##}", DpsHeroOne.Cost)}";
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DpsHeroTwo.AttemptUpgrade(cash))
            {
                Properties.Settings.Default.DpsHero2Level += 1;
                cash -= DpsHeroTwo.Cost;
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                label11.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero2Level);
                DpsHeroTwo.Level = Properties.Settings.Default.DpsHero2Level;
                DpsHeroTwo.UpdateCost();
                DpsHeroTwo.UpdateDamage();
                Properties.Settings.Default.Cash = cash;
                button9.Text = $"${string.Format("{0:#,##0.##}", DpsHeroTwo.Cost)}";
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            }
        }

    }
}