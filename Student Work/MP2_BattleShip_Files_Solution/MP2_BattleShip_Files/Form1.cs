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

        public OppBoard()
        {
            InitializeComponent();
            P1.BringToFront();
            P2.BringToFront();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt"))
            {
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt");
                    fil.Close();
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
            else
            {
                File.Create("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt");
                try
                {
                    StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt");
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
                WriteToFile("P2M1");
            }
        }

        private void P1O2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M2");
            }
        }

        private void P1O3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M3");
            }
        }

        private void P1O4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M4");
            }
        }

        private void P1O5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M5");
            }
        }

        private void P1O6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M6");
            }
        }

        private void P1O7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M7");
            }
        }

        private void P1O8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M8");
            }
        }

        private void P1O9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M9");
            }
        }

        private void P1O10_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M10");
            }
        }

        private void P1O11_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M11");
            }
        }

        private void P1O12_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M12");
            }
        }

        private void P1O13_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M13");
            }
        }

        private void P1O14_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M14");

            }
        }

        private void P1O15_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M15");
            }
        }

        private void P1O16_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M16");
            }
        }

        private void P1O17_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M17");
            }
        }

        private void P1O18_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M18");
            }
        }

        private void P1O19_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M19");
            }
        }

        private void P1O20_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M20");
            }
        }

        private void P1O21_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M21");
            }
        }

        private void P1O22_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M22");
            }
        }

        private void P1O23_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M23");
            }
        }

        private void P1O24_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M24");
            }
        }

        private void P1O25_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                WriteToFile("P2M25");
            }
        }
        private void P2O1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M1");
            }
        }

        private void P2O2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M2");
            }
        }

        private void P2O3_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M3");
            }
        }

        private void P2O4_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M4");
            }
        }

        private void P2O5_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M5");
            }
        }

        private void P2O6_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M6");
            }
        }

        private void P2O7_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M7");
            }
        }

        private void P2O8_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M8");
            }
        }

        private void P2O9_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M9");
            }
        }

        private void P2O10_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M10");
            }
        }

        private void P2O11_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M11");
            }
        }

        private void P2O12_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M12");
            }
        }

        private void P2O13_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M13");
            }
        }

        private void P2O14_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M14");
            }
        }

        private void P2O15_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M15");
            }
        }

        private void P2O16_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M16");
            }
        }

        private void P2O17_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M17");
            }
        }

        private void P2O18_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M18");
            }
        }

        private void P2O19_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M19");
            }
        }

        private void P2O20_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M20");
            }
        }

        private void P2O21_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M21");
            }
        }

        private void P2O22_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M22");
            }
        }

        private void P2O23_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M23");
            }
        }

        private void P2O24_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M24");
            }
        }

        private void P2O25_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {
                WriteToFile("P1M25");
            }
        }

        private void P1_Click(object sender, EventArgs e)
        {
            P1OpponentBoard();
            MessageBox.Show("Place the ships.");
        }

        private void P2_Click(object sender, EventArgs e)
        {
            P2MyBoard();
            MessageBox.Show("Place the ships.");
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
            P1M11.BringToFront();
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

        public static void WriteToFile(string x)
        {
            try
            {
                StreamWriter fil = new StreamWriter("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt");
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
                StreamReader inFile = new StreamReader("S:\\Students\\Math\\Student Work\\Computer Science\\BattleShip.txt");
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
        public static bool TestForHit(PictureBox x)
        {
            if (x.ImageLocation == "S:\\Student\\Math\\Student Work\\Computer Science\\green.jpg"
                || x.ImageLocation == "S:\\Student\\Math\\Student Work\\Computer Science\\red.jpg"
                || x.ImageLocation == "S:\\Student\\Math\\Student Work\\Computer Science\\blue.jpg")
            {
                return true;
            }
            else if (x.ImageLocation == "S:\\Student\\Math\\Student Work\\Computer Science\\girl-on-fire-pic.jpg"
                  || x.ImageLocation == "S:\\Student\\Math\\Student Work\\Computer Science\\grey.jpg")
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public static void ChangePicture(PictureBox x)
        {
            TestForHit(x);
            if (true)
            {
                x.ImageLocation = "S:\\Student\\Math\\Student Work\\Computer Science\\grey.jpg";
            }
            else if (false)
            {
                x.ImageLocation = "S:\\Student\\Math\\Student Work\\Computer Science\\grey.jpg";
            }
            else
            {
            }
        }
    }
}
