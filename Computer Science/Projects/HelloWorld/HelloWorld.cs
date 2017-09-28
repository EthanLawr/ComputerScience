using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Red
            Console.WriteLine("Ethan Lawrence"
                + "\t" + DateTime.Now
                + "\tPeriod 4,5,6"
                + "\tMr. Lynch"
                + "\n********************************************************************************");
            Console.ResetColor(); //Color Reset of the text
            Console.ForegroundColor = ConsoleColor.Magenta; //Color Set to Magenta
            Console.WriteLine("\"Hello\" World"); //Header
            Console.ResetColor(); //Color Reset
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Red
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            Console.ReadKey(); //Lets the Command Console stay until a key is pressed 
        }
    }
};
