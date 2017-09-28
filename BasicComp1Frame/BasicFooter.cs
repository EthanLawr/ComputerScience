using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
class MainClass {
       static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Red
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            Console.ReadKey(); //Lets the Command Console stay until a key is pressed 
        }
};
