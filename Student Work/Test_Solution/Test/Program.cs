using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue;
            if (File.Exists("S:\\Students\\Math\\Student Work\\Computer Science\\Test.txt"))
            {
                try
                {
                    StreamReader inFile = new StreamReader("S:\\Students\\Math\\Student Work\\Computer Science\\Test.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        Console.WriteLine(inValue);
                    }
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);

                }
            }
            else
            {
                Console.WriteLine("File Unavailable");
            
            
            }
            Console.ReadLine();
        }
    }
}
