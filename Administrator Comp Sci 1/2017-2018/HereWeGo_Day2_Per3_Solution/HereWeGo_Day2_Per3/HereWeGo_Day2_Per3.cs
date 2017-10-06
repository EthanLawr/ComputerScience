using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HereWeGo_Day2_Per3
{
    class HereWeGo_Day2_Per3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
$$\      $$\                 $$\                                    $$\       
$$$\    $$$ |                $$ |                                   $$ |
$$$$\  $$$$ | $$$$$$\        $$ |     $$\   $$\ $$$$$$$\   $$$$$$$\ $$$$$$$\  
$$\$$\$$ $$ |$$  __$$\       $$ |     $$ |  $$ |$$  __$$\ $$  _____|$$ __ $$\ 
$$ \$$$  $$ |$$ |  \__|      $$ |     $$ |  $$ |$$ |  $$ |$$ /      $$ |  $$ |
$$ |\$  /$$ |$$ |            $$ |     $$ |  $$ |$$ |  $$ |$$ |      $$ |  $$ |
$$ | \_ / $$|$$ |$$\         $$$$$$$$\\$$$$$$$ |$$ |  $$ |\$$$$$$$\ $$ |  $$ |
\__|     \__|\__|\__|        \________|\____$$ |\__|  \__| \_______|\__|  \__|
                                      $$\   $$ |                              
                                      \$$$$$$  |                              
                                       \______/                    ");

            #region Header
            //This #region creates a section of code to be minimized
            NewMethod();
            //Create a header
            Console.WriteLine("Author: Mr. Lynch \t\t\tTitle: First Program");
            // \t tabs over\
            Console.WriteLine(""); //This is an empty string
            Console.WriteLine("Date: 9/28/17");
            Console.WriteLine("\nPurpose: This program is meant "
                + "to show students \nsome of the basics in "
                + "programming");// \n creates a new line
            Console.WriteLine("****************************************"
                + "********************");
            Console.WriteLine("");
            // #endregion will end the minimized section
            #endregion

            /*
            Anything in 
            here is 
            a multiline or block comment

            */

            #region MyRegion
            //code snippet for setting up a region is #region-tab-tab
            //code snippet for Console.WriteLine(); is cw-tab-tab
            #endregion

            NewMethod();
            //This is our first comment
            Console.WriteLine("\n\n\nKnuckleheads, here we go!\a");
            NewMethod();
            //This is where we program the body of the project

            NewMethod();

            #region End Program
            //This is how we will end our program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please hit ENTER key to end program...");
            Console.Read();//Read(); only accepts the ENTER key
            #endregion
        }
        public static void NewMethod()
        {
            Console.WriteLine("Hit Enter to continue...\a");
            //NewMethod();  This will put you in an infinite loop
            Console.Read();
            //New methods happen outside the MAIN method
            //but inside the class file

        }
    }
}
