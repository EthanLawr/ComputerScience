//Anything in green is a comment
//This is where our header goes
//
//
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgramDay1
{
    class FirstProgramDay1   //This is our class file
    {
        static void Main(string[] args)
        {
            #region ConsoleHeader
            Console.SetWindowSize(80, 50);
            Console.Title = "First Progam";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: First Program\tAuthor: Mr. Lynch");
            Console.WriteLine("\nDate: 9/29/2015");
            Console.WriteLine("\nThis program is meant to . . .");
            Console.WriteLine("*******************************************"
                +"****");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #endregion

            int variable2 = 4;
            variable2 = variable2 + 3;
            Console.WriteLine("to start the value is {0}",++variable2);
            Console.WriteLine("Now the value is {0}",variable2*2);


            //patorjk.com is the website for "text to ascii" characters        
            Console.WriteLine(@" 
 ▄█       ▄██   ▄   ███▄▄▄▄    ▄████████    ▄█    █▄    
███       ███   ██▄ ███▀▀▀██▄ ███    ███   ███    ███   
███       ███▄▄▄███ ███   ███ ███    █▀    ███    ███   
███       ▀▀▀▀▀▀███ ███   ███ ███         ▄███▄▄▄▄███▄▄ 
███       ▄██   ███ ███   ███ ███        ▀▀███▀▀▀▀███▀  
███       ███   ███ ███   ███ ███    █▄    ███    ███   
███▌    ▄ ███   ███ ███   ███ ███    ███   ███    ███   
█████▄▄██  ▀█████▀   ▀█   █▀  ████████▀    ███    █▀    
▀                                                     ");
            Console.WriteLine("");
            Console.WriteLine("Dan");
            Console.WriteLine("Lynch");

            Console.WriteLine("\n\nHello\tWorld . . .\a\a");
            Console.Beep();

            #region End Program
            //Wait for use to acknowledge results
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPlease hit ENTER to end program . . .");
            Console.Read();
            #endregion


        }

    }
}
