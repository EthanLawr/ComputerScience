using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project2
{
    public partial class Form1 : Form
    {
        // aEeUaEeUaEeUaEeUaEeUaEeUaEeUaEe
        public static Enemy Patient = new Enemy();
        public static ClickerHero ClickingHero = new ClickerHero();
        public static DpsHero1 DpsHeroOne = new DpsHero1();
        public static DpsHero2 DpsHeroTwo = new DpsHero2();
        public static Random Randy = new Random();
        public static Image[] Images = { Properties.Resources.ef6e92a2b2c94b5fb7b9bedb3ba007eeb1b2844c_hq, Properties.Resources.GoombaNSMB, Properties.Resources.Shy_Guy__Mario_, Properties.Resources.Spiny_Artwork___New_Super_Mario_Bros__2, Properties.Resources._220px_Blooper__mario_ };
        public static int cash = (int)Properties.Settings.Default.Cash, currentRound = Properties.Settings.Default.RoundMax, enemiesKilledThisRound = 0;
        public static double Dps = DpsHeroOne.Dps + DpsHeroTwo.Dps;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Saves the data to a file
            Encryption.AutoEncrypt();
            // Activates my custom cursor but ONLY in the form
            Cursor = new Cursor(GetType(), "CustomMadeCursor.cur");
            // Sets a new enemy
            Patient.EnemyUnit(Properties.Settings.Default.RoundMax);

            button1.BackgroundImage = Images[Randy.Next(Images.Length)];
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            #region Timers
            // Invoke allows for threading, so it makes the process faster for more real time gameplay
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
            #endregion

            #region Label text update
            // Major formatting adjustments
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
            label7.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero1Level);
            #endregion

            #region Progress bar edit
            progressBar1.Maximum = Patient.healthMax;
            progressBar1.Value = Patient.healthMax;
            // Sets the bar to red
            ModifyProgressBarColor.SetState(progressBar1, 2);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Damage per click ( or by pressing enter if you want to be sonic )
            Patient.healthRemaining -= ClickingHero.DamagePerClick;
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    // Respawns enemy on the current round
                    Patient.EnemyUnit(currentRound);
                    button1.BackgroundImage = Images[Randy.Next(Images.Length)];
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
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
                    // If this is the fifth non boss enemy killed or first boss enemy
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    button1.BackgroundImage = Images[Randy.Next(Images.Length)];
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
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
                // Damage received 
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
                    // Sets you to a round you specify but only if its valid
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
            // Removing warning of the variable not being used
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("That is not a valid round to go to.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Dps to an enemy
            Patient.healthRemaining -= Math.Round(Dps / 20.0000, 2);
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    // Respawns enemy on the current round
                    Patient.EnemyUnit(currentRound);
                    button1.BackgroundImage = Images[Randy.Next(Images.Length)];
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
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
                    // If this is the fifth non boss enemy killed or first boss enemy
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    button1.BackgroundImage = Images[Randy.Next(Images.Length)];
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
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
                // Damage received 
                progressBar1.Value = (int)Patient.healthRemaining;
                label5.Text = "Health Left: " + string.Format("{0:#,##0.00}", Patient.healthRemaining) + "/" + string.Format("{0:#,##0.##}", Patient.healthMax);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Checks if you can buy this upgrade
            if (cash > ClickingHero.UpgradeCost && ClickingHero.Level >= ClickingHero.UpgradeLevelRequirement && ClickingHero.DamageMultipliers <= 5)
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
            // Reset button
            var Confirmation = MessageBox.Show("Do you really want to reset?", "Confirmation Message", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
            {
                // Resets all data
                Properties.Settings.Default.Reset();
                Encryption.AutoEncrypt();

                Application.Exit();
                

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Checks if you can buy this upgrade
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
            #region Updating hero stats
            ClickingHero.UpdateDamage();
            ClickingHero.UpdateCost();
            DpsHeroOne.UpdateDamage();
            DpsHeroOne.UpdateCost();
            DpsHeroTwo.UpdateDamage();
            DpsHeroTwo.UpdateCost();
            Dps = DpsHeroOne.Dps + DpsHeroTwo.Dps;
            #endregion

            Encryption.AutoEncrypt();

            #region Button color updates
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
            #endregion

            // Damage Updater
            label13.Text = $"Click Damage: {string.Format("{0:#,##0.##}", ClickingHero.DamagePerClick)}";
            label12.Text = $"Total Dps: {string.Format("{0:#,##0.##}", Dps)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Checks if you can buy this upgrade
            if (ClickingHero.AttemptUpgrade(cash))
            {
                cash -= ClickingHero.Cost;
                ClickingHero.BaseDamagePerClick++;
                Properties.Settings.Default.Cash = cash;
                // Formatting
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
            // Checks if you can buy this upgrade
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

        private void button10_Click(object sender, EventArgs e)
        {
            // Checks if theres more than one form open
            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Please close the window before trying to open it again! We don't need duplicates here!");
            } else
            {
                // Allows for file encryption to be used
                Form2 f2 = new Form2();
                f2.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Attempts to upgrade. only works if you have enough coins
            if (DpsHeroOne.AttemptUpgrade(cash))
            {
                Properties.Settings.Default.DpsHero1Level += 1;
                cash -= DpsHeroOne.Cost;
                // Changes the text to a specific number format
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                label7.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero1Level);
                DpsHeroOne.Level = Properties.Settings.Default.DpsHero1Level;
                // Update stats
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
            // Attempts to upgrade. only works if you have enough coins
            if (DpsHeroTwo.AttemptUpgrade(cash))
            {
                Properties.Settings.Default.DpsHero2Level += 1;
                cash -= DpsHeroTwo.Cost;
                // Changes numbers to a specific format
                label1.Text = "Cash: $" + string.Format("{0:#,##0.##}", cash);
                label11.Text = "Level: " + string.Format("{0:#,##0.##}", Properties.Settings.Default.DpsHero2Level);
                DpsHeroTwo.Level = Properties.Settings.Default.DpsHero2Level;
                // Update stats
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


        public static void Form2_FormClosed()
        {
            // Resets data 
            Properties.Settings.Default.Save();
            Encryption.AutoEncrypt(100);
            
            
        }

    }
}