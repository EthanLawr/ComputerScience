using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static int cash = (int)Properties.Settings.Default.Cash, DamagePerClick = Properties.Settings.Default.CashClickLevel,
            currentRound = Properties.Settings.Default.RoundMax, enemiesKilledThisRound = 0;
        public static double Dps = Properties.Settings.Default.DpsHero1Level;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Patient.EnemyUnit(Properties.Settings.Default.RoundMax);
            Invoke((MethodInvoker)delegate
            {
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 50;
                timer1.Start();
            });
            
            label1.Text = "Cash: $" + cash;
            label2.Text = "Level: " + Properties.Settings.Default.CashClickLevel;
            label4.Text = "Current Round: " + currentRound.ToString();
            label8.Text = "Highest Round: " + Properties.Settings.Default.RoundMax;
            button3.Text = "$" + (int)(50 * Math.Pow(1.07, Properties.Settings.Default.DpsHero1Level));
            button2.Text = $"${(int)(20 * Math.Pow(1.075, Properties.Settings.Default.CashClickLevel))}";
            label5.Text = "Health Left: " + Patient.healthRemaining.ToString() + "/" + Patient.healthMax.ToString();
            progressBar1.Maximum = Patient.healthMax;
            progressBar1.Value = Patient.healthMax;
            ModifyProgressBarColor.SetState(progressBar1, 2);
            label7.Text = "Level: " + Properties.Settings.Default.DpsHero1Level;
            //Properties.Settings.Default.Reset();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient.healthRemaining -= DamagePerClick;
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    Patient.EnemyUnit(currentRound);
                    label5.Text = "Health Left: " + Patient.healthRemaining.ToString();
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + cash;
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
                else
                {
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    label5.Text = "Health Left: " + Patient.healthRemaining.ToString();
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + cash;
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
                label5.Text = "Health Left: " + Patient.healthRemaining.ToString("0.00") + "/" + Patient.healthMax.ToString();
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
                    label5.Text = "Health Left: " + Patient.healthRemaining.ToString();
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    label4.Text = "Current Round: " + currentRound.ToString();
                }
#pragma warning disable CS0168 // Variable is declared but never used
            } catch (Exception f)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("That is not a valid round to go to.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Patient.healthRemaining -= Dps / 20.0000;
            if (0 >= Patient.healthRemaining)
            {
                if (Patient.boss) enemiesKilledThisRound += 5;
                else enemiesKilledThisRound++;
                if (enemiesKilledThisRound < 5)
                {
                    Patient.EnemyUnit(currentRound);
                    label5.Text = "Health Left: " + Patient.healthRemaining.ToString();
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + cash;
                    label4.Text = "Current Round: " + currentRound.ToString();
                    Properties.Settings.Default.Cash = cash;
                    Properties.Settings.Default.Save();
                    label10.Text = $"{enemiesKilledThisRound}/5 Enemies Killed";
                }
                else
                {
                    if (currentRound >= Properties.Settings.Default.RoundMax) label8.Text = "Highest Round: " + ++Properties.Settings.Default.RoundMax;
                    Patient.EnemyUnit(++currentRound);
                    label5.Text = "Health Left: " + Patient.healthRemaining.ToString();
                    progressBar1.Maximum = Patient.healthMax;
                    progressBar1.Value = Patient.healthMax - 1;
                    cash += Patient.GoldReward();
                    label1.Text = "Cash: $" + cash;
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
                label5.Text = "Health Left: " + Patient.healthRemaining.ToString("0.00") + "/" + Patient.healthMax.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int cost = (int)((Math.Pow(int.Parse(label2.Text.Substring(7)), 3) / 6) + (int.Parse(label2.Text.Substring(7)) * 1.5));
            int cost = (int)(20 * Math.Pow(1.075, Properties.Settings.Default.CashClickLevel));
            if (cost > cash) MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            else
            {

                cash -= cost;
                Properties.Settings.Default.CashClickLevel++;
                DamagePerClick++;
                Properties.Settings.Default.Cash = cash;
                label1.Text = "Cash: $" + cash;
                label2.Text = "Level: " + Properties.Settings.Default.CashClickLevel;
                button2.Text = $"${(int)(20 * Math.Pow(1.075, Properties.Settings.Default.CashClickLevel))}";
                Properties.Settings.Default.Save();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int cost = (int)(50 * Math.Pow(1.07, Properties.Settings.Default.DpsHero1Level));
            if (cost > cash) MessageBox.Show("You are unable to purchase this upgrade.", "Oh no!", MessageBoxButtons.OK);
            else
            {

                cash -= cost;
                Properties.Settings.Default.DpsHero1Level++;
                Properties.Settings.Default.Cash = cash;
                Dps++;
                label1.Text = "Cash: $" + cash;
                label7.Text = "Level: " + Properties.Settings.Default.DpsHero1Level;
                button3.Text = $"${(int)(50 * Math.Pow(1.07, Properties.Settings.Default.DpsHero1Level))}";
                Properties.Settings.Default.Save();
            }
        }
    }
}
