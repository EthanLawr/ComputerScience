using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Final_Project2
{
    static class Encryption
    {
        public static string LastEncryption = "";
        public static void Encrypt(ref string x)
        {
            x = x.Replace("1",  "aE3");
            x = x.Replace("2", "c4p8");
            x = x.Replace("3", "rWQ");
            x = x.Replace("4", "gxS8");
            x = x.Replace("5", "zYM");
            x = x.Replace("6", "LKT701");
            x = x.Replace("7", "K89K");
            x = x.Replace("8", "Y45Y");
            x = x.Replace("9", "FP1N");
            x = x.Replace("0", "HVvJ");
            x = x.Replace('\n', 'U');
            LastEncryption = x;
        }
        public static void Decrypt(ref string x)
        {
            x = x.Replace("aE3", "1");
            x = x.Replace("c4p8", "2");
            x = x.Replace("rWQ", "3");
            x = x.Replace("gxS8", "4");
            x = x.Replace("zYM", "5");
            x = x.Replace("LKT701", "6");
            x = x.Replace("K89K", "7");
            x = x.Replace("Y45Y", "8");
            x = x.Replace("FP1N", "9");
            x = x.Replace("HVvJ", "0");
            x = x.Replace('U', '\n');
        }
        public static string Decrypt(string x)
        {
            x = x.Replace("aE3", "1");
            x = x.Replace("c4p8", "2");
            x = x.Replace("rWQ", "3");
            x = x.Replace("gxS8", "4");
            x = x.Replace("zYM", "5");
            x = x.Replace("LKT701", "6");
            x = x.Replace("K89K", "7");
            x = x.Replace("Y45Y", "8");
            x = x.Replace("FP1N", "9");
            x = x.Replace("HVvJ", "0");
            x = x.Replace('U', '\n');
            return x;
        }
        public static bool DecryptTest(string x)
        {
            x = x.Replace("aE3", "");
            x = x.Replace("c4p8", "");
            x = x.Replace("rWQ", "");
            x = x.Replace("gxS8", "");
            x = x.Replace("zYM", "");
            x = x.Replace("LKT701", "");
            x = x.Replace("K89K", "");
            x = x.Replace("Y45Y", "");
            x = x.Replace("FP1N", "");
            x = x.Replace("HVvJ", "");
            x = x.Replace("Y", "");
            if (x.Equals("")) return true;
            else return false;
        }
        public static void AutoEncrypt()
        {
            string saveFileText = "";
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                saveFileText += Properties.Settings.Default[currentProperty.Name].ToString() + "\n";
            }
            Encrypt(ref saveFileText);
            File.Delete(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt");
            File.AppendAllText(@"h:\comp 2\projects\final_project2_solution\final_project2\textfile1.txt", saveFileText);
        }
    }
}
