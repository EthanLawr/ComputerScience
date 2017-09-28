using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Need to Add this to your program for file access

namespace WorkingWithFiles
{
    class WorkingWithFiles
    {
        static void Main(string[] args)
        {
            string fileName = "dlynch1 - BowTieWeddingPicture.jpg"; //must store in bin\Debug folder
            //within your solution file.

            if (File.Exists(fileName))
            {
                Console.WriteLine("FileName: {0}",fileName);
                Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName));
                Console.WriteLine("Created: {0}", File.GetCreationTime(fileName));
                Console.WriteLine("Last Edited: {0}",File.GetLastWriteTime(fileName));
                Console.WriteLine("\n\n\n\n");
            }
            else
            {
                Console.WriteLine("{0} not found - using current directory:", fileName);
            }

            //Writing to a File
            // Get the directories currently in your H drive.
            DirectoryInfo[] hDirs = new DirectoryInfo(@"H:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("HDriveDirsNew.txt"))
            {
                foreach (DirectoryInfo dir in hDirs)
                {
                    sw.WriteLine(dir.Name);
                    //This writes all the the directories in my H:Drive to 
                    //a .txt file saved as HDriveDirs.txt in my bin\Debug folder 

                }
            }


            //Reading in a file
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Knucklehead.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);//Goes through and writes each line in the .txt file
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            Console.Read();
        }
    }
}
