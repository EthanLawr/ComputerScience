using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Per45_FirstProgram
{
    class Day1_Per45_FirstProgram
    {
        public static void KnuckleheadMethod()
        {
            //This is where we program original methods
            //outside the Main();  

            Console.WriteLine("\"Knucklehead\"");
            //KnuckleheadMethod(); This put us in an infinite loop
            
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 60);//This changes the 
            #region Mr. Lynch ASCII Art
            Console.WriteLine(@"
$$\      $$\                 $$\                                    $$\       
$$$\    $$$ |                $$ |                                   $$ |
$$$$\  $$$$ | $$$$$$\        $$ |     $$\   $$\ $$$$$$$\   $$$$$$$\ $$$$$$$\  
$$\$$\$$ $$ |$$  __$$\       $$ |     $$ |  $$ |$$  __$$\ $$  _____|$$ __ $$\ 
$$ \$$$  $$ |$$ |  \__|      $$ |     $$ |  $$ |$$ |  $$ |$$ /      $$ |  $$ |
$$ |\$  /$$ |$$ |            $$ |     $$ |  $$ |$$ |  $$ |$$ |      $$ |  $$ |
$$ | \_ /$$ |$$ |$$\         $$$$$$$$\\$$$$$$$ |$$ |  $$ |\$$$$$$$\ $$ |  $$ |
\__|     \__|\__|\__|        \________|\____$$ |\__|  \__| \_______|\__|  \__|
                                      $$\   $$ |                              
                                      \$$$$$$  |                              
                                       \______/                    ");
            #endregion
            #region Header
            //Let's create a header for our toolbox
            Console.WriteLine("Author: Mr. Lynch \t\t\t Title: First Program");
            // \t is the escape squence for tab over
            Console.WriteLine("\n\t\t\tDate: 9/28/17");
            Console.WriteLine("\nPurpose: The purpose of this program"
                + " is meant to teach you knuckleheads\n the basics "
                + "of computer programming in C#");
            // \n is used to create a new line

            Console.WriteLine("\n********************************************"
                + "*********************\n");
            #endregion

            KnuckleheadMethod();
            Console.WriteLine(""); //Empty string
            //It does the same thing as \n
            Console.WriteLine("This is our first program, yeah!");

            Console.WriteLine("");
            Console.WriteLine("hello world");
            Console.WriteLine("\n\n\n\a\a");
            /*Snippets
            This is a block comment or multiline comment
            
            cw-tab-tab  = Console.WriteLine();
            #region-tab-tab = opens up a region to be minimized

            */
            KnuckleheadMethod();
            KnuckleheadMethod();

            #region End Program
            //This is how we end the program
            //
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\aPlease hit ENTER to end program...");
            // \a give a single beep

            //This Console.Read(); should be the last line in Main();
            Console.Read();//You need to hit the ENTER key to end
            #endregion
            
        }

    }
}
