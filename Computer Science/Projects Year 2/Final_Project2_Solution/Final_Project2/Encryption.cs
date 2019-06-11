using System.Configuration;
using System.IO;

namespace Final_Project2
{
    static class Encryption
    {
        public static string LastEncryption = "";
        public static void Encrypt(ref string x)
        {
            x = x.Replace("1",  "aEe");
            x = x.Replace("2", "cPp");
            x = x.Replace("3", "rWQ");
            x = x.Replace("4", "gxS");
            x = x.Replace("5", "zYM");
            x = x.Replace("6", "LKT");
            x = x.Replace("7", "KOK");
            x = x.Replace("8", "YAY");
            x = x.Replace("9", "FON");
            x = x.Replace("0", "HVvJ");
            x = x.Replace('\n', 'U');
            LastEncryption = x;
        }
        public static void Decrypt(ref string x)
        {
            x = x.Replace("aEe", "1");
            x = x.Replace("cPp", "2");
            x = x.Replace("rWQ", "3");
            x = x.Replace("gxS", "4");
            x = x.Replace("zYM", "5");
            x = x.Replace("LKT", "6");
            x = x.Replace("KOK", "7");
            x = x.Replace("YAY", "8");
            x = x.Replace("FON", "9");
            x = x.Replace("HVvJ", "0");
            x = x.Replace('U', '\n');
        }
        public static string Decrypt(string x)
        {
            x = x.Replace("aEe", "1");
            x = x.Replace("cPp", "2");
            x = x.Replace("rWQ", "3");
            x = x.Replace("gxS", "4");
            x = x.Replace("zYM", "5");
            x = x.Replace("LKT", "6");
            x = x.Replace("KOK", "7");
            x = x.Replace("YAY", "8");
            x = x.Replace("FON", "9");
            x = x.Replace("HVvJ", "0");
            x = x.Replace('U', '\n');
            return x;
        }
        public static bool DecryptTest(string x)
        {
            x = x.Replace("aEe", "");
            x = x.Replace("cPp", "");
            x = x.Replace("rWQ", "");
            x = x.Replace("gxS", "");
            x = x.Replace("zYM", "");
            x = x.Replace("LKT", "");
            x = x.Replace("KOK", "");
            x = x.Replace("YAY", "");
            x = x.Replace("FON", "");
            x = x.Replace("HVvJ", "");
            x = x.Replace("U", "");
            if (x.Trim(' ', '\n') == "")
            {
                return true;
            }
            else return false;
        }
        // Saves to file
        public static void AutoEncrypt()
        {
            string saveFileText = "";
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                saveFileText += Properties.Settings.Default[currentProperty.Name].ToString() + "\n";
            }
            Encrypt(ref saveFileText);
            try
            {
                File.Delete(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt");
                File.AppendAllText(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt", saveFileText);

            } catch (System.Exception f)
            {
                // Do nothing
            }
        }
        // Restarts Program
        public static void AutoEncrypt(int x)
        {
            string saveFileText = "";
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                saveFileText += Properties.Settings.Default[currentProperty.Name].ToString() + "\n";
            }
            Encrypt(ref saveFileText);
            File.Delete(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt");
            File.AppendAllText(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt", saveFileText);
            System.Windows.Forms.Application.Exit();
        }
        
    }
}
