using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MP2_BattleShip_Files
{
    public partial class OppBoard : Form
    {
        public int playerTurn = 1;
        public string inValue;
        public int p1Counter = 0;
        public int p2Counter = 0;

        public OppBoard()
        {
            InitializeComponent();
            P1.BringToFront();
            P2.BringToFront();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt"))
            {
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt");
                    fil.Close();
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
            else
            {
                File.Create("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt");
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt");
                    fil.Close();
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            if (File.Exists("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP2.txt"))
            {
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP2.txt");
                    fil.Close();
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
            else
            {
                File.Create("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP2.txt");
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP2.txt");
                    fil.Close();
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        private void P1O1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M1");
            }
        }

        private void P1O2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M2");
            }
        }

        private void P1O3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M3");
            }
        }

        private void P1O4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M4");
            }
        }

        private void P1O5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M5");
            }
        }

        private void P1O6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M6");
            }
        }

        private void P1O7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M7");
            }
        }

        private void P1O8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M8");
            }
        }

        private void P1O9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M9");
            }
        }

        private void P1O10_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M10");
            }
        }

        private void P1O11_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M11");
            }
        }

        private void P1O12_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M12");
            }
        }

        private void P1O13_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M13");
            }
        }

        private void P1O14_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M14");

            }
        }

        private void P1O15_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M15");
            }
        }

        private void P1O16_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M16");
            }
        }

        private void P1O17_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M17");
            }
        }

        private void P1O18_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M18");
            }
        }

        private void P1O19_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M19");
            }
        }

        private void P1O20_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M20");
            }
        }

        private void P1O21_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M21");
            }
        }

        private void P1O22_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M22");
            }
        }

        private void P1O23_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M23");
            }
        }

        private void P1O24_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M24");
            }
        }

        private void P1O25_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToP1("P2M25");
            }
        }
        private void P2O1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M1");
            }
        }

        private void P2O2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M2");
            }
        }

        private void P2O3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M3");
            }
        }

        private void P2O4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M4");
            }
        }

        private void P2O5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M5");
            }
        }

        private void P2O6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M6");
            }
        }

        private void P2O7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M7");
            }
        }

        private void P2O8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M8");
            }
        }

        private void P2O9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M9");
            }
        }

        private void P2O10_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M10");
            }
        }

        private void P2O11_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M11");
            }
        }

        private void P2O12_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M12");
            }
        }

        private void P2O13_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M13");
            }
        }

        private void P2O14_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M14");
            }
        }

        private void P2O15_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M15");
            }
        }

        private void P2O16_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M16");
            }
        }

        private void P2O17_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M17");
            }
        }

        private void P2O18_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M18");
            }
        }

        private void P2O19_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M19");
            }
        }

        private void P2O20_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M20");
            }
        }

        private void P2O21_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M21");
            }
        }

        private void P2O22_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M22");
            }
        }

        private void P2O23_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M23");
            }
        }

        private void P2O24_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M24");
            }
        }

        private void P2O25_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToP2("P1M25");
            }
        }

        private void P1_Click(object sender, EventArgs e)
        {
            P1Timer.Start();
            P1MyBoard();
            PlaceGreenShipP1();
            PlaceGoldenrodShipP1();
        }

        private void P2_Click(object sender, EventArgs e)
        {
            P2Timer.Start();
            P2MyBoard();
            PlaceGreenShipP2();
            PlaceGoldenrodShipP2();
        }
        public void P1OpponentBoard()
        {
            P1O1.BringToFront();
            P1O2.BringToFront();
            P1O3.BringToFront();
            P1O4.BringToFront();
            P1O5.BringToFront();
            P1O6.BringToFront();
            P1O7.BringToFront();
            P1O8.BringToFront();
            P1O9.BringToFront();
            P1O10.BringToFront();
            P1O11.BringToFront();
            P1O12.BringToFront();
            P1O13.BringToFront();
            P1O14.BringToFront();
            P1O15.BringToFront();
            P1O16.BringToFront();
            P1O17.BringToFront();
            P1O18.BringToFront();
            P1O19.BringToFront();
            P1O20.BringToFront();
            P1O21.BringToFront();
            P1O22.BringToFront();
            P1O23.BringToFront();
            P1O24.BringToFront();
            P1O25.BringToFront();
        }
        public void P1MyBoard()
        {
            P1M1.BringToFront();
            P1M2.BringToFront();
            P1M3.BringToFront();
            P1M4.BringToFront();
            P1M5.BringToFront();
            P1M6.BringToFront();
            P1M7.BringToFront();
            P1M8.BringToFront();
            P1M9.BringToFront();
            P1M10.BringToFront();
            P1M11.BringToFront();
            P1M12.BringToFront();
            P1M13.BringToFront();
            P1M14.BringToFront();
            P1M15.BringToFront();
            P1M16.BringToFront();
            P1M17.BringToFront();
            P1M18.BringToFront();
            P1M19.BringToFront();
            P1M20.BringToFront();
            P1M21.BringToFront();
            P1M22.BringToFront();
            P1M23.BringToFront();
            P1M24.BringToFront();
            P1M25.BringToFront();
        }
        public void P2OpponentBoard()
        {
            P2O1.BringToFront();
            P2O2.BringToFront();
            P2O3.BringToFront();
            P2O4.BringToFront();
            P2O5.BringToFront();
            P2O6.BringToFront();
            P2O7.BringToFront();
            P2O8.BringToFront();
            P2O9.BringToFront();
            P2O10.BringToFront();
            P2O11.BringToFront();
            P2O12.BringToFront();
            P2O13.BringToFront();
            P2O14.BringToFront();
            P2O15.BringToFront();
            P2O16.BringToFront();
            P2O17.BringToFront();
            P2O18.BringToFront();
            P2O19.BringToFront();
            P2O20.BringToFront();
            P2O21.BringToFront();
            P2O22.BringToFront();
            P2O23.BringToFront();
            P2O24.BringToFront();
            P2O25.BringToFront();
        }
        public void P2MyBoard()
        {
            P2M1.BringToFront();
            P2M2.BringToFront();
            P2M3.BringToFront();
            P2M4.BringToFront();
            P2M5.BringToFront();
            P2M6.BringToFront();
            P2M7.BringToFront();
            P2M8.BringToFront();
            P2M9.BringToFront();
            P2M10.BringToFront();
            P2M11.BringToFront();
            P2M12.BringToFront();
            P2M13.BringToFront();
            P2M14.BringToFront();
            P2M15.BringToFront();
            P2M16.BringToFront();
            P2M17.BringToFront();
            P2M18.BringToFront();
            P2M19.BringToFront();
            P2M20.BringToFront();
            P2M21.BringToFront();
            P2M22.BringToFront();
            P2M23.BringToFront();
            P2M24.BringToFront();
            P2M25.BringToFront();
        }

        public static void WriteToP1(string x)
        {
            try
            {
                StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt");
                fil.WriteLine(x);
                fil.Close();
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public static void WriteToP2(string x)
        {
            try
            {
                StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP2.txt");
                fil.WriteLine(x);
                fil.Close();
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                StreamReader inFile = new StreamReader("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShipP1.txt");
                inValue = inFile.ReadLine();
                inFile.Close();
                switch (inValue)
                {
                    case "P1M1":
                        TestForHit(P1M1);
                        break;
                    case "P1M2":
                        TestForHit(P1M2);
                        break;
                    case "P1M3":
                        TestForHit(P1M3);
                        break;
                    case "P1M4":
                        TestForHit(P1M4);
                        break;
                    case "P1M5":
                        TestForHit(P1M5);
                        break;
                    case "P1M6":
                        TestForHit(P1M6);
                        break;
                    case "P1M7":
                        TestForHit(P1M7);
                        break;
                    case "P1M8":
                        TestForHit(P1M8);
                        break;
                    case "P1M9":
                        TestForHit(P1M9);
                        break;
                    case "P1M10":
                        TestForHit(P1M10);
                        break;
                    case "P1M11":
                        TestForHit(P1M11);
                        break;
                    case "P1M12":
                        TestForHit(P1M12);
                        break;
                    case "P1M13":
                        TestForHit(P1M13);
                        break;
                    case "P1M14":
                        TestForHit(P1M14);
                        break;
                    case "P1M15":
                        TestForHit(P1M15);
                        break;
                    case "P1M16":
                        TestForHit(P1M16);
                        break;
                    case "P1M17":
                        TestForHit(P1M17);
                        break;
                    case "P1M18":
                        TestForHit(P1M18);
                        break;
                    case "P1M19":
                        TestForHit(P1M19);
                        break;
                    case "P1M20":
                        TestForHit(P1M20);
                        break;
                    case "P1M21":
                        TestForHit(P1M21);
                        break;
                    case "P1M22":
                        TestForHit(P1M22);
                        break;
                    case "P1M23":
                        TestForHit(P1M23);
                        break;
                    case "P1M24":
                        TestForHit(P1M24);
                        break;
                    case "P1M25":
                        TestForHit(P1M25);
                        break;
                    case "P2M1":
                        TestForHit(P2M1);
                        break;
                    case "P2M2":
                        TestForHit(P2M2);
                        break;
                    case "P2M3":
                        TestForHit(P2M3);
                        break;
                    case "P2M4":
                        TestForHit(P2M4);
                        break;
                    case "P2M5":
                        TestForHit(P2M5);
                        break;
                    case "P2M6":
                        TestForHit(P2M6);
                        break;
                    case "P2M7":
                        TestForHit(P2M7);
                        break;
                    case "P2M8":
                        TestForHit(P2M8);
                        break;
                    case "P2M9":
                        TestForHit(P2M9);
                        break;
                    case "P2M10":
                        TestForHit(P2M10);
                        break;
                    case "P2M11":
                        TestForHit(P2M11);
                        break;
                    case "P2M12":
                        TestForHit(P2M12);
                        break;
                    case "P2M13":
                        TestForHit(P2M13);
                        break;
                    case "P2M14":
                        TestForHit(P2M14);
                        break;
                    case "P2M15":
                        TestForHit(P2M15);
                        break;
                    case "P2M16":
                        TestForHit(P2M16);
                        break;
                    case "P2M17":
                        TestForHit(P2M17);
                        break;
                    case "P2M18":
                        TestForHit(P2M18);
                        break;
                    case "P2M19":
                        TestForHit(P2M19);
                        break;
                    case "P2M20":
                        TestForHit(P2M20);
                        break;
                    case "P2M21":
                        TestForHit(P2M21);
                        break;
                    case "P2M22":
                        TestForHit(P2M22);
                        break;
                    case "P2M23":
                        TestForHit(P2M23);
                        break;
                    case "P2M24":
                        TestForHit(P2M24);
                        break;
                    case "P2M25":
                        TestForHit(P2M25);
                        break;
                    default:
                        break;
                }
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public static string TestForHit(PictureBox x)
        {
            if (x.BackColor == Color.ForestGreen
                || x.BackColor == Color.Goldenrod)
            {
                return "Hit";
            }
            else if (x.BackColor == Color.DodgerBlue)
            {
                return "miss";
            }
            else if (x.BackColor == Color.WhiteSmoke || x.BackColor == Color.Black)
            {
                return "redo";
            }
            else
            {
                return "";
            }
        }
        public static void ChangePicture(PictureBox x,PictureBox y)
        {
            string result = TestForHit(x);
            if (result == "Hit")
            {
                MessageBox.Show("Hit");
                x.BackColor = Color.OrangeRed;
                y.BackColor = Color.OrangeRed;
            }
            else if (result == "Miss")
            {
                MessageBox.Show("Nope.");
            }
            else
            {
            }
        }
        public void PlaceGreenShipP1()
        {
            Random rnd = new Random();
            int orientation = rnd.Next(1, 3);
            int firstSpot = rnd.Next(1, 15);

            if (orientation == 1)
            {
                switch (firstSpot)
                {
                    case 1:
                        P1M1.BackColor = Color.ForestGreen;
                        P1M6.BackColor = Color.ForestGreen;
                        P1M11.BackColor = Color.ForestGreen;
                        break;
                    case 2:
                        P1M2.BackColor = Color.ForestGreen;
                        P1M7.BackColor = Color.ForestGreen;
                        P1M12.BackColor = Color.ForestGreen;
                        break;
                    case 3:
                        P1M3.BackColor = Color.ForestGreen;
                        P1M8.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        break;
                    case 4:
                        P1M4.BackColor = Color.ForestGreen;
                        P1M9.BackColor = Color.ForestGreen;
                        P1M14.BackColor = Color.ForestGreen;
                        break;
                    case 5:
                        P1M5.BackColor = Color.ForestGreen;
                        P1M10.BackColor = Color.ForestGreen;
                        P1M15.BackColor = Color.ForestGreen;
                        break;
                    case 6:
                        P1M6.BackColor = Color.ForestGreen;
                        P1M11.BackColor = Color.ForestGreen;
                        P1M16.BackColor = Color.ForestGreen;
                        break;
                    case 7:
                        P1M7.BackColor = Color.ForestGreen;
                        P1M12.BackColor = Color.ForestGreen;
                        P1M17.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        P1M8.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        break;
                    case 9:
                        P1M9.BackColor = Color.ForestGreen;
                        P1M14.BackColor = Color.ForestGreen;
                        P1M19.BackColor = Color.ForestGreen;
                        break;
                    case 10:
                        P1M10.BackColor = Color.ForestGreen;
                        P1M15.BackColor = Color.ForestGreen;
                        P1M20.BackColor = Color.ForestGreen;
                        break;
                    case 11:
                        P1M11.BackColor = Color.ForestGreen;
                        P1M16.BackColor = Color.ForestGreen;
                        P1M21.BackColor = Color.ForestGreen;
                        break;
                    case 12:
                        P1M12.BackColor = Color.ForestGreen;
                        P1M17.BackColor = Color.ForestGreen;
                        P1M22.BackColor = Color.ForestGreen;
                        break;
                    case 13:
                        P1M13.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        P1M23.BackColor = Color.ForestGreen;
                        break;
                    case 14:
                        P1M14.BackColor = Color.ForestGreen;
                        P1M19.BackColor = Color.ForestGreen;
                        P1M24.BackColor = Color.ForestGreen;
                        break;
                    case 15:
                        P1M15.BackColor = Color.ForestGreen;
                        P1M20.BackColor = Color.ForestGreen;
                        P1M25.BackColor = Color.ForestGreen;
                        break;
                    default:
                        break;
                }
            }
            else if (orientation == 2)
            {
                switch (firstSpot)
                {
                    case 1:
                        P1M1.BackColor = Color.ForestGreen;
                        P1M2.BackColor = Color.ForestGreen;
                        P1M3.BackColor = Color.ForestGreen;
                        break;
                    case 2:
                        P1M2.BackColor = Color.ForestGreen;
                        P1M3.BackColor = Color.ForestGreen;
                        P1M4.BackColor = Color.ForestGreen;
                        break;
                    case 3:
                        P1M3.BackColor = Color.ForestGreen;
                        P1M4.BackColor = Color.ForestGreen;
                        P1M5.BackColor = Color.ForestGreen;
                        break;
                    case 4:
                        P1M4.BackColor = Color.ForestGreen;
                        P1M5.BackColor = Color.ForestGreen;
                        P1M3.BackColor = Color.ForestGreen;
                        break;
                    case 5:
                        P1M5.BackColor = Color.ForestGreen;
                        P1M4.BackColor = Color.ForestGreen;
                        P1M3.BackColor = Color.ForestGreen;
                        break;
                    case 6:
                        P1M6.BackColor = Color.ForestGreen;
                        P1M7.BackColor = Color.ForestGreen;
                        P1M8.BackColor = Color.ForestGreen;
                        break;
                    case 7:
                        P1M7.BackColor = Color.ForestGreen;
                        P1M8.BackColor = Color.ForestGreen;
                        P1M9.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        P1M8.BackColor = Color.ForestGreen;
                        P1M9.BackColor = Color.ForestGreen;
                        P1M10.BackColor = Color.ForestGreen;
                        break;
                    case 9:
                        P1M9.BackColor = Color.ForestGreen;
                        P1M10.BackColor = Color.ForestGreen;
                        P1M8.BackColor = Color.ForestGreen;
                        break;
                    case 10:
                        P1M10.BackColor = Color.ForestGreen;
                        P1M9.BackColor = Color.ForestGreen;
                        P1M8.BackColor = Color.ForestGreen;
                        break;
                    case 11:
                        P1M11.BackColor = Color.ForestGreen;
                        P1M12.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        break;
                    case 12:
                        P1M12.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        P1M14.BackColor = Color.ForestGreen;
                        break;
                    case 13:
                        P1M13.BackColor = Color.ForestGreen;
                        P1M14.BackColor = Color.ForestGreen;
                        P1M15.BackColor = Color.ForestGreen;
                        break;
                    case 14:
                        P1M14.BackColor = Color.ForestGreen;
                        P1M15.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        break;
                    case 15:
                        P1M15.BackColor = Color.ForestGreen;
                        P1M14.BackColor = Color.ForestGreen;
                        P1M13.BackColor = Color.ForestGreen;
                        break;
                    case 16:
                        P1M16.BackColor = Color.ForestGreen;
                        P1M17.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        break;
                    case 17:
                        P1M17.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        P1M19.BackColor = Color.ForestGreen;
                        break;
                    case 18:
                        P1M18.BackColor = Color.ForestGreen;
                        P1M19.BackColor = Color.ForestGreen;
                        P1M20.BackColor = Color.ForestGreen;
                        break;
                    case 19:
                        P1M19.BackColor = Color.ForestGreen;
                        P1M20.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        break;
                    case 20:
                        P1M20.BackColor = Color.ForestGreen;
                        P1M19.BackColor = Color.ForestGreen;
                        P1M18.BackColor = Color.ForestGreen;
                        break;
                    case 21:
                        P1M21.BackColor = Color.ForestGreen;
                        P1M22.BackColor = Color.ForestGreen;
                        P1M23.BackColor = Color.ForestGreen;
                        break;
                    case 22:
                        P1M22.BackColor = Color.ForestGreen;
                        P1M23.BackColor = Color.ForestGreen;
                        P1M24.BackColor = Color.ForestGreen;
                        break;
                    case 23:
                        P1M23.BackColor = Color.ForestGreen;
                        P1M24.BackColor = Color.ForestGreen;
                        P1M25.BackColor = Color.ForestGreen;
                        break;
                    case 24:
                        P1M24.BackColor = Color.ForestGreen;
                        P1M25.BackColor = Color.ForestGreen;
                        P1M23.BackColor = Color.ForestGreen;
                        break;
                    case 25:
                        P1M25.BackColor = Color.ForestGreen;
                        P1M24.BackColor = Color.ForestGreen;
                        P1M23.BackColor = Color.ForestGreen;
                        break;
                    default:
                        break;
                }
            }
        }
        public void PlaceGreenShipP2()
        {
            Random rnd = new Random();
            int orientation = rnd.Next(1, 3);
            int firstSpot1 = rnd.Next(1, 15);
            int firstSpot2 = rnd.Next(1, 25);

            if (orientation == 1)
            {
                switch (firstSpot1)
                {
                    case 1:
                        P2M1.BackColor = Color.ForestGreen;
                        P2M6.BackColor = Color.ForestGreen;
                        P2M11.BackColor = Color.ForestGreen;
                        break;
                    case 2:
                        P2M2.BackColor = Color.ForestGreen;
                        P2M7.BackColor = Color.ForestGreen;
                        P2M12.BackColor = Color.ForestGreen;
                        break;
                    case 3:
                        P2M3.BackColor = Color.ForestGreen;
                        P2M8.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        break;
                    case 4:
                        P2M4.BackColor = Color.ForestGreen;
                        P2M9.BackColor = Color.ForestGreen;
                        P2M14.BackColor = Color.ForestGreen;
                        break;
                    case 5:
                        P2M5.BackColor = Color.ForestGreen;
                        P2M10.BackColor = Color.ForestGreen;
                        P2M15.BackColor = Color.ForestGreen;
                        break;
                    case 6:
                        P2M6.BackColor = Color.ForestGreen;
                        P2M11.BackColor = Color.ForestGreen;
                        P2M16.BackColor = Color.ForestGreen;
                        break;
                    case 7:
                        P2M7.BackColor = Color.ForestGreen;
                        P2M12.BackColor = Color.ForestGreen;
                        P2M17.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        P2M8.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        break;
                    case 9:
                        P2M9.BackColor = Color.ForestGreen;
                        P2M14.BackColor = Color.ForestGreen;
                        P2M19.BackColor = Color.ForestGreen;
                        break;
                    case 10:
                        P2M10.BackColor = Color.ForestGreen;
                        P2M15.BackColor = Color.ForestGreen;
                        P2M20.BackColor = Color.ForestGreen;
                        break;
                    case 11:
                        P2M11.BackColor = Color.ForestGreen;
                        P2M16.BackColor = Color.ForestGreen;
                        P2M21.BackColor = Color.ForestGreen;
                        break;
                    case 12:
                        P2M12.BackColor = Color.ForestGreen;
                        P2M17.BackColor = Color.ForestGreen;
                        P2M22.BackColor = Color.ForestGreen;
                        break;
                    case 13:
                        P2M13.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        P2M23.BackColor = Color.ForestGreen;
                        break;
                    case 14:
                        P2M14.BackColor = Color.ForestGreen;
                        P2M19.BackColor = Color.ForestGreen;
                        P2M24.BackColor = Color.ForestGreen;
                        break;
                    case 15:
                        P2M15.BackColor = Color.ForestGreen;
                        P2M20.BackColor = Color.ForestGreen;
                        P2M25.BackColor = Color.ForestGreen;
                        break;
                    default:
                        break;
                }
            }
            else if (orientation == 2)
            {
                switch (firstSpot2)
                {
                    case 1:
                        P2M1.BackColor = Color.ForestGreen;
                        P2M2.BackColor = Color.ForestGreen;
                        P2M3.BackColor = Color.ForestGreen;
                        break;
                    case 2:
                        P2M2.BackColor = Color.ForestGreen;
                        P2M3.BackColor = Color.ForestGreen;
                        P2M4.BackColor = Color.ForestGreen;
                        break;
                    case 3:
                        P2M3.BackColor = Color.ForestGreen;
                        P2M4.BackColor = Color.ForestGreen;
                        P2M5.BackColor = Color.ForestGreen;
                        break;
                    case 4:
                        P2M4.BackColor = Color.ForestGreen;
                        P2M5.BackColor = Color.ForestGreen;
                        P2M3.BackColor = Color.ForestGreen;
                        break;
                    case 5:
                        P2M5.BackColor = Color.ForestGreen;
                        P2M4.BackColor = Color.ForestGreen;
                        P2M3.BackColor = Color.ForestGreen;
                        break;
                    case 6:
                        P2M6.BackColor = Color.ForestGreen;
                        P2M7.BackColor = Color.ForestGreen;
                        P2M8.BackColor = Color.ForestGreen;
                        break;
                    case 7:
                        P2M7.BackColor = Color.ForestGreen;
                        P2M8.BackColor = Color.ForestGreen;
                        P2M9.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        P2M8.BackColor = Color.ForestGreen;
                        P2M9.BackColor = Color.ForestGreen;
                        P2M10.BackColor = Color.ForestGreen;
                        break;
                    case 9:
                        P2M9.BackColor = Color.ForestGreen;
                        P2M10.BackColor = Color.ForestGreen;
                        P2M8.BackColor = Color.ForestGreen;
                        break;
                    case 10:
                        P2M10.BackColor = Color.ForestGreen;
                        P2M9.BackColor = Color.ForestGreen;
                        P2M8.BackColor = Color.ForestGreen;
                        break;
                    case 11:
                        P2M11.BackColor = Color.ForestGreen;
                        P2M12.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        break;
                    case 12:
                        P2M12.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        P2M14.BackColor = Color.ForestGreen;
                        break;
                    case 13:
                        P2M13.BackColor = Color.ForestGreen;
                        P2M14.BackColor = Color.ForestGreen;
                        P2M15.BackColor = Color.ForestGreen;
                        break;
                    case 14:
                        P2M14.BackColor = Color.ForestGreen;
                        P2M15.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        break;
                    case 15:
                        P2M15.BackColor = Color.ForestGreen;
                        P2M14.BackColor = Color.ForestGreen;
                        P2M13.BackColor = Color.ForestGreen;
                        break;
                    case 16:
                        P2M16.BackColor = Color.ForestGreen;
                        P2M17.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        break;
                    case 17:
                        P2M17.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        P2M19.BackColor = Color.ForestGreen;
                        break;
                    case 18:
                        P2M18.BackColor = Color.ForestGreen;
                        P2M19.BackColor = Color.ForestGreen;
                        P2M20.BackColor = Color.ForestGreen;
                        break;
                    case 19:
                        P2M19.BackColor = Color.ForestGreen;
                        P2M20.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        break;
                    case 20:
                        P2M20.BackColor = Color.ForestGreen;
                        P2M19.BackColor = Color.ForestGreen;
                        P2M18.BackColor = Color.ForestGreen;
                        break;
                    case 21:
                        P2M21.BackColor = Color.ForestGreen;
                        P2M22.BackColor = Color.ForestGreen;
                        P2M23.BackColor = Color.ForestGreen;
                        break;
                    case 22:
                        P2M22.BackColor = Color.ForestGreen;
                        P2M23.BackColor = Color.ForestGreen;
                        P2M24.BackColor = Color.ForestGreen;
                        break;
                    case 23:
                        P2M23.BackColor = Color.ForestGreen;
                        P2M24.BackColor = Color.ForestGreen;
                        P2M25.BackColor = Color.ForestGreen;
                        break;
                    case 24:
                        P2M24.BackColor = Color.ForestGreen;
                        P2M25.BackColor = Color.ForestGreen;
                        P2M23.BackColor = Color.ForestGreen;
                        break;
                    case 25:
                        P2M25.BackColor = Color.ForestGreen;
                        P2M24.BackColor = Color.ForestGreen;
                        P2M23.BackColor = Color.ForestGreen;
                        break;
                    default:
                        break;
                }
            }
        }
        public void PlaceGoldenrodShipP1()
        {
            Random rnd = new Random();
            int orientation = rnd.Next(1, 3);
            int firstSpot1 = rnd.Next(1, 20);
            int firstSpot2 = rnd.Next(1, 25);

            if (orientation == 1)
            {
                switch (firstSpot1)
                {
                    case 1:
                        if (P1M1.BackColor == Color.DodgerBlue && P1M6.BackColor == Color.DodgerBlue)
                        {
                            P1M1.BackColor = Color.Goldenrod;
                            P1M6.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                            break;
                    case 2:
                        if (P1M2.BackColor == Color.DodgerBlue && P1M7.BackColor == Color.DodgerBlue)
                        {
                            P1M2.BackColor = Color.Goldenrod;
                        P1M7.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 3:
                        if (P1M3.BackColor == Color.DodgerBlue && P1M8.BackColor == Color.DodgerBlue)
                        {
                            P1M3.BackColor = Color.Goldenrod;
                        P1M8.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 4:
                        if (P1M4.BackColor == Color.DodgerBlue && P1M9.BackColor == Color.DodgerBlue)
                        {
                            P1M4.BackColor = Color.Goldenrod;
                        P1M9.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 5:
                        if (P1M5.BackColor == Color.DodgerBlue && P1M10.BackColor == Color.DodgerBlue)
                        {
                            P1M5.BackColor = Color.Goldenrod;
                        P1M10.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 6:
                        if (P1M11.BackColor == Color.DodgerBlue && P1M6.BackColor == Color.DodgerBlue)
                        {
                            P1M6.BackColor = Color.Goldenrod;
                        P1M11.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 7:
                        if (P1M7.BackColor == Color.DodgerBlue && P1M12.BackColor == Color.DodgerBlue)
                        {
                            P1M7.BackColor = Color.Goldenrod;
                        P1M12.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 8:
                        if (P1M8.BackColor == Color.DodgerBlue && P1M13.BackColor == Color.DodgerBlue)
                        {
                            P1M8.BackColor = Color.Goldenrod;
                        P1M13.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 9:
                        if (P1M9.BackColor == Color.DodgerBlue && P1M14.BackColor == Color.DodgerBlue)
                        {
                            P1M9.BackColor = Color.Goldenrod;
                        P1M14.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 10:
                        if (P1M10.BackColor == Color.DodgerBlue && P1M15.BackColor == Color.DodgerBlue)
                        {
                            P1M10.BackColor = Color.Goldenrod;
                        P1M15.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 11:
                        if (P1M11.BackColor == Color.DodgerBlue && P1M16.BackColor == Color.DodgerBlue)
                        {
                            P1M11.BackColor = Color.Goldenrod;
                        P1M16.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 12:
                        if (P1M12.BackColor == Color.DodgerBlue && P1M17.BackColor == Color.DodgerBlue)
                        {
                            P1M12.BackColor = Color.Goldenrod;
                        P1M17.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 13:
                        if (P1M13.BackColor == Color.DodgerBlue && P1M18.BackColor == Color.DodgerBlue)
                        {
                            P1M13.BackColor = Color.Goldenrod;
                        P1M18.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 14:
                        if (P1M14.BackColor == Color.DodgerBlue && P1M19.BackColor == Color.DodgerBlue)
                        {
                            P1M14.BackColor = Color.Goldenrod;
                        P1M19.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 15:
                        if (P1M15.BackColor == Color.DodgerBlue && P1M25.BackColor == Color.DodgerBlue)
                        {
                            P1M15.BackColor = Color.Goldenrod;
                        P1M20.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 16:
                        if (P1M16.BackColor == Color.DodgerBlue && P1M21.BackColor == Color.DodgerBlue)
                        {
                            P1M16.BackColor = Color.Goldenrod;
                        P1M21.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 17:
                        if (P1M17.BackColor == Color.DodgerBlue && P1M22.BackColor == Color.DodgerBlue)
                        {
                            P1M17.BackColor = Color.Goldenrod;
                        P1M22.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 18:
                        if (P1M18.BackColor == Color.DodgerBlue && P1M23.BackColor == Color.DodgerBlue)
                        {
                            P1M18.BackColor = Color.Goldenrod;
                        P1M23.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 19:
                        if (P1M19.BackColor == Color.DodgerBlue && P1M24.BackColor == Color.DodgerBlue)
                        {
                            P1M24.BackColor = Color.Goldenrod;
                        P1M19.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 20:
                        if (P1M25.BackColor == Color.DodgerBlue && P1M20.BackColor == Color.DodgerBlue)
                        {
                            P1M25.BackColor = Color.Goldenrod;
                        P1M20.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (orientation == 2)
            {
                switch (firstSpot2)
                {
                    case 1:
                            if (P1M1.BackColor == Color.DodgerBlue && P1M2.BackColor == Color.DodgerBlue)
                            {
                                P1M1.BackColor = Color.Goldenrod;
                        P1M2.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 2:
                            if (P1M2.BackColor == Color.DodgerBlue && P1M3.BackColor == Color.DodgerBlue)
                            {
                                P1M2.BackColor = Color.Goldenrod;
                        P1M3.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 3:
                            if (P1M3.BackColor == Color.DodgerBlue && P1M4.BackColor == Color.DodgerBlue)
                            {
                                P1M3.BackColor = Color.Goldenrod;
                        P1M4.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 4:
                            if (P1M4.BackColor == Color.DodgerBlue && P1M3.BackColor == Color.DodgerBlue)
                            {
                                P1M4.BackColor = Color.Goldenrod;
                        P1M3.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 5:
                            if (P1M5.BackColor == Color.DodgerBlue && P1M4.BackColor == Color.DodgerBlue)
                            {
                                P1M5.BackColor = Color.Goldenrod;
                        P1M4.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 6:
                            if (P1M7.BackColor == Color.DodgerBlue && P1M6.BackColor == Color.DodgerBlue)
                            {
                                P1M6.BackColor = Color.Goldenrod;
                        P1M7.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 7:
                            if (P1M7.BackColor == Color.DodgerBlue && P1M8.BackColor == Color.DodgerBlue)
                            {
                                P1M7.BackColor = Color.Goldenrod;
                        P1M8.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 8:
                            if (P1M8.BackColor == Color.DodgerBlue && P1M9.BackColor == Color.DodgerBlue)
                            {
                                P1M8.BackColor = Color.Goldenrod;
                        P1M9.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 9:
                            if (P1M9.BackColor == Color.DodgerBlue && P1M10.BackColor == Color.DodgerBlue)
                            {
                                P1M9.BackColor = Color.Goldenrod;
                        P1M10.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 10:
                            if (P1M10.BackColor == Color.DodgerBlue && P1M9.BackColor == Color.DodgerBlue)
                            {
                                P1M10.BackColor = Color.Goldenrod;
                        P1M9.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 11:
                            if (P1M11.BackColor == Color.DodgerBlue && P1M12.BackColor == Color.DodgerBlue)
                            {
                                P1M11.BackColor = Color.Goldenrod;
                        P1M12.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 12:
                            if (P1M12.BackColor == Color.DodgerBlue && P1M13.BackColor == Color.DodgerBlue)
                            {
                                P1M12.BackColor = Color.Goldenrod;
                        P1M13.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 13:
                            if (P1M13.BackColor == Color.DodgerBlue && P1M14.BackColor == Color.DodgerBlue)
                            {
                                P1M13.BackColor = Color.Goldenrod;
                        P1M14.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 14:
                            if (P1M14.BackColor == Color.DodgerBlue && P1M15.BackColor == Color.DodgerBlue)
                            {
                                P1M14.BackColor = Color.Goldenrod;
                        P1M15.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 15:
                            if (P1M15.BackColor == Color.DodgerBlue && P1M14.BackColor == Color.DodgerBlue)
                            {
                                P1M15.BackColor = Color.Goldenrod;
                        P1M14.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 16:
                            if (P1M16.BackColor == Color.DodgerBlue && P1M17.BackColor == Color.DodgerBlue)
                            {
                                P1M16.BackColor = Color.Goldenrod;
                        P1M17.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 17:
                            if (P1M17.BackColor == Color.DodgerBlue && P1M18.BackColor == Color.DodgerBlue)
                            {
                                P1M17.BackColor = Color.Goldenrod;
                        P1M18.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 18:
                            if (P1M18.BackColor == Color.DodgerBlue && P1M19.BackColor == Color.DodgerBlue)
                            {
                                P1M18.BackColor = Color.Goldenrod;
                        P1M19.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 19:
                            if (P1M19.BackColor == Color.DodgerBlue && P1M20.BackColor == Color.DodgerBlue)
                            {
                                P1M19.BackColor = Color.Goldenrod;
                        P1M20.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 20:
                            if (P1M20.BackColor == Color.DodgerBlue && P1M19.BackColor == Color.DodgerBlue)
                            {
                                P1M20.BackColor = Color.Goldenrod;
                        P1M19.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 21:
                            if (P1M21.BackColor == Color.DodgerBlue && P1M22.BackColor == Color.DodgerBlue)
                            {
                                P1M21.BackColor = Color.Goldenrod;
                        P1M22.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 22:
                            if (P1M22.BackColor == Color.DodgerBlue && P1M23.BackColor == Color.DodgerBlue)
                            {
                                P1M22.BackColor = Color.Goldenrod;
                        P1M23.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 23:
                            if (P1M23.BackColor == Color.DodgerBlue && P1M24.BackColor == Color.DodgerBlue)
                            {
                                P1M23.BackColor = Color.Goldenrod;
                        P1M24.BackColor = Color.Goldenrod;
                        }
                        else
                        {
                            P1M24.BackColor = Color.Goldenrod;
                            P1M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 24:
                        P1M24.BackColor = Color.Goldenrod;
                        P1M25.BackColor = Color.Goldenrod;
                        break;
                    case 25:
                        P1M25.BackColor = Color.Goldenrod;
                        P1M24.BackColor = Color.Goldenrod;
                        break;
                    default:
                        break;
                }
            }
        }
        public void PlaceGoldenrodShipP2()
        {
            Random rnd = new Random();
            int orientation = rnd.Next(1, 3);
            int firstSpot1 = rnd.Next(1, 25);
            int firstSpot2 = rnd.Next(1, 20);

            if (orientation == 1)
            {
                switch (firstSpot1)
                {
                    case 1:
                        if (P2M1.BackColor == Color.DodgerBlue && P2M2.BackColor == Color.DodgerBlue)
                        {
                            P2M1.BackColor = Color.Goldenrod;
                        P2M2.BackColor = Color.Goldenrod;
                }
                        else
                        {
                    P2M24.BackColor = Color.Goldenrod;
                    P2M25.BackColor = Color.Goldenrod;
                }
                break;
                    case 2:
                        if (P2M2.BackColor == Color.DodgerBlue && P2M3.BackColor == Color.DodgerBlue)
                        {
                            P2M2.BackColor = Color.Goldenrod;
                        P2M3.BackColor = Color.Goldenrod;
            }
            else
            {
                P2M24.BackColor = Color.Goldenrod;
                P2M25.BackColor = Color.Goldenrod;
            }
            break;
                    case 3:
                        if (P2M3.BackColor == Color.DodgerBlue && P2M4.BackColor == Color.DodgerBlue)
                        {
                            P2M3.BackColor = Color.Goldenrod;
                        P2M4.BackColor = Color.Goldenrod;
        }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 4:
                        if (P2M4.BackColor == Color.DodgerBlue && P2M5.BackColor == Color.DodgerBlue)
                        {
                            P2M4.BackColor = Color.Goldenrod;
                        P2M5.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 5:
                        if (P2M5.BackColor == Color.DodgerBlue && P2M4.BackColor == Color.DodgerBlue)
                        {
                            P2M5.BackColor = Color.Goldenrod;
                            P2M4.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 6:
                        if (P2M7.BackColor == Color.DodgerBlue && P2M6.BackColor == Color.DodgerBlue)
                        {
                            P2M6.BackColor = Color.Goldenrod;
                        P2M7.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 7:
                        if (P2M7.BackColor == Color.DodgerBlue && P2M8.BackColor == Color.DodgerBlue)
                        {
                            P2M7.BackColor = Color.Goldenrod;
                        P2M8.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 8:
                        if (P2M8.BackColor == Color.DodgerBlue && P2M9.BackColor == Color.DodgerBlue)
                        {
                            P2M8.BackColor = Color.Goldenrod;
                        P2M9.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 9:
                        if (P2M9.BackColor == Color.DodgerBlue && P2M10.BackColor == Color.DodgerBlue)
                        {
                            P2M9.BackColor = Color.Goldenrod;
                        P2M10.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 10:
                        if (P2M10.BackColor == Color.DodgerBlue && P2M9.BackColor == Color.DodgerBlue)
                            {
                    P2M10.BackColor = Color.Goldenrod;
                        P2M9.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 11:
                        if (P2M11.BackColor == Color.DodgerBlue && P2M12.BackColor == Color.DodgerBlue)
                        {
                            P2M11.BackColor = Color.Goldenrod;
                        P2M12.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 12:
                        if (P2M12.BackColor == Color.DodgerBlue && P2M13.BackColor == Color.DodgerBlue)
                        {
                            P2M12.BackColor = Color.Goldenrod;
                        P2M13.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 13:
                        if (P2M13.BackColor == Color.DodgerBlue && P2M14.BackColor == Color.DodgerBlue)
                        {
                            P2M13.BackColor = Color.Goldenrod;
                        P2M14.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 14:
                        if (P2M14.BackColor == Color.DodgerBlue && P2M15.BackColor == Color.DodgerBlue)
                        {
                            P2M14.BackColor = Color.Goldenrod;
                        P2M15.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 15:
                        if (P2M15.BackColor == Color.DodgerBlue && P2M14.BackColor == Color.DodgerBlue)
                        {
                            P2M15.BackColor = Color.Goldenrod;
                        P2M14.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 16:
                        if (P2M16.BackColor == Color.DodgerBlue && P2M17.BackColor == Color.DodgerBlue)
                        {
                            P2M16.BackColor = Color.Goldenrod;
                        P2M17.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 17:
                        if (P2M17.BackColor == Color.DodgerBlue && P2M18.BackColor == Color.DodgerBlue)
                        {
                            P2M17.BackColor = Color.Goldenrod;
                            P2M18.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 18:
                        if (P2M18.BackColor == Color.DodgerBlue && P2M19.BackColor == Color.DodgerBlue)
                        {
                            P2M18.BackColor = Color.Goldenrod;
                        P2M19.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 19:
                        if (P2M19.BackColor == Color.DodgerBlue && P2M20.BackColor == Color.DodgerBlue)
                        {
                            P2M19.BackColor = Color.Goldenrod;
                        P2M20.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 20:
                        if (P2M20.BackColor == Color.DodgerBlue && P2M19.BackColor == Color.DodgerBlue)
                        {
                            P2M20.BackColor = Color.Goldenrod;
                        P2M19.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 21:
                        if (P2M21.BackColor == Color.DodgerBlue && P2M22.BackColor == Color.DodgerBlue)
                        {
                            P2M21.BackColor = Color.Goldenrod;
                        P2M22.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 22:
                        if (P2M22.BackColor == Color.DodgerBlue && P2M23.BackColor == Color.DodgerBlue)
                        {
                            P2M22.BackColor = Color.Goldenrod;
                        P2M23.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 23:
                        if (P2M23.BackColor == Color.DodgerBlue && P2M24.BackColor == Color.DodgerBlue)
                        {
                            P2M23.BackColor = Color.Goldenrod;
                        P2M24.BackColor = Color.Goldenrod;
                            }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 24:
                            P2M24.BackColor = Color.Goldenrod;
                        P2M25.BackColor = Color.Goldenrod;
                        break;
                    case 25:
                            P2M25.BackColor = Color.Goldenrod;
                        P2M24.BackColor = Color.Goldenrod;
                        break;
                    default:
                        break;
                }
            }
            else if (orientation == 2)
            {
                switch (firstSpot2)
                {
                    case 1:
                        if (P2M1.BackColor == Color.DodgerBlue && P2M6.BackColor == Color.DodgerBlue)
                        {
                            P2M1.BackColor = Color.Goldenrod;
                        P2M6.BackColor = Color.Goldenrod;
                }
                        else
                        {
                    P2M24.BackColor = Color.Goldenrod;
                    P2M25.BackColor = Color.Goldenrod;
                }
                break;
                    case 2:
                        if (P2M2.BackColor == Color.DodgerBlue && P2M7.BackColor == Color.DodgerBlue)
                        {
                            P2M2.BackColor = Color.Goldenrod;
                        P2M7.BackColor = Color.Goldenrod;
            }
            else
            {
                P2M24.BackColor = Color.Goldenrod;
                P2M25.BackColor = Color.Goldenrod;
            }
            break;
                    case 3:
                        if (P2M3.BackColor == Color.DodgerBlue && P2M8.BackColor == Color.DodgerBlue)
                        {
                            P2M3.BackColor = Color.Goldenrod;
                        P2M8.BackColor = Color.Goldenrod;
        }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 4:
                        if (P2M9.BackColor == Color.DodgerBlue && P2M4.BackColor == Color.DodgerBlue)
                        {
                            P2M4.BackColor = Color.Goldenrod;
                        P2M9.BackColor = Color.Goldenrod;
                                    }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 5:
                        if (P2M5.BackColor == Color.DodgerBlue && P2M10.BackColor == Color.DodgerBlue)
                        {
                            P2M5.BackColor = Color.Goldenrod;
                        P2M10.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 6:
                        if (P2M6.BackColor == Color.DodgerBlue && P2M11.BackColor == Color.DodgerBlue)
                        {
                            P2M6.BackColor = Color.Goldenrod;
                        P2M11.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 7:
                        if (P2M7.BackColor == Color.DodgerBlue && P2M12.BackColor == Color.DodgerBlue)
                        {
                            P2M7.BackColor = Color.Goldenrod;
                        P2M12.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 8:
                        if (P2M8.BackColor == Color.DodgerBlue && P2M13.BackColor == Color.DodgerBlue)
                        {
                            P2M8.BackColor = Color.Goldenrod;
                        P2M13.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 9:
                        if (P2M9.BackColor == Color.DodgerBlue && P2M14.BackColor == Color.DodgerBlue)
                        {
                            P2M9.BackColor = Color.Goldenrod;
                        P2M14.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 10:
                        if (P2M10.BackColor == Color.DodgerBlue && P2M15.BackColor == Color.DodgerBlue)
                        {
                            P2M10.BackColor = Color.Goldenrod;
                        P2M15.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 11:
                        if (P2M11.BackColor == Color.DodgerBlue && P2M16.BackColor == Color.DodgerBlue)
                        {
                            P2M11.BackColor = Color.Goldenrod;
                        P2M16.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 12:
                        if (P2M12.BackColor == Color.DodgerBlue && P2M17.BackColor == Color.DodgerBlue)
                        {
                            P2M12.BackColor = Color.Goldenrod;
                        P2M17.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 13:
                        if (P2M13.BackColor == Color.DodgerBlue && P2M18.BackColor == Color.DodgerBlue)
                        {
                            P2M13.BackColor = Color.Goldenrod;
                        P2M18.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 14:
                        if (P2M14.BackColor == Color.DodgerBlue && P2M19.BackColor == Color.DodgerBlue)
                        {
                            P2M14.BackColor = Color.Goldenrod;
                        P2M19.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 15:
                        if (P2M15.BackColor == Color.DodgerBlue && P2M20.BackColor == Color.DodgerBlue)
                        {
                            P2M15.BackColor = Color.Goldenrod;
                        P2M20.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 16:
                        if (P2M16.BackColor == Color.DodgerBlue && P2M21.BackColor == Color.DodgerBlue)
                        {
                            P2M16.BackColor = Color.Goldenrod;
                        P2M21.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 17:
                        if (P2M17.BackColor == Color.DodgerBlue && P2M22.BackColor == Color.DodgerBlue)
                        {
                            P2M17.BackColor = Color.Goldenrod;
                            P2M22.BackColor = Color.Goldenrod;
                         }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 18:
                        if (P2M23.BackColor == Color.DodgerBlue && P2M18.BackColor == Color.DodgerBlue)
                        {
                            P2M18.BackColor = Color.Goldenrod;
                            P2M23.BackColor = Color.Goldenrod;
                         }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 19:
                        if (P2M19.BackColor == Color.DodgerBlue && P2M24.BackColor == Color.DodgerBlue)
                        {
                            P2M19.BackColor = Color.Goldenrod;
                        P2M24.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    case 20:
                        if (P2M20.BackColor == Color.DodgerBlue && P2M25.BackColor == Color.DodgerBlue)
                        {
                            P2M20.BackColor = Color.Goldenrod;
                        P2M25.BackColor = Color.Goldenrod;
                                }
                        else
                        {
                            P2M24.BackColor = Color.Goldenrod;
                            P2M25.BackColor = Color.Goldenrod;
                        }
                        break;
                    default:
                        break;
                }

            }

        }

        private void P1Timer_Tick(object sender, EventArgs e)
        {
            p1Counter++;
            if (p1Counter == 3)
            {   
                P1OpponentBoard();
                P1Timer.Stop();
                p1Counter = 0;
                playerTurn = 1;
            }
        }

        private void P2Timer_Tick(object sender, EventArgs e)
        {
            p2Counter++;
            if (p2Counter == 3)
            {
                P2OpponentBoard();
                P2Timer.Stop();
                p2Counter = 0;
                playerTurn = 1;
            }
        }
    }
}
