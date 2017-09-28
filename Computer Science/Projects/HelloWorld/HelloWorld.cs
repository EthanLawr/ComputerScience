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
            Console.BackgroundColor = ConsoleColor.Magenta; //Color Set To Magenta
            Console.WriteLine("\"hello\" kek"); //Header
            Console.ResetColor(); //Color Reset
            Console.BackgroundColor = ConsoleColor.Red; //Color Set To Res
            Console.WriteLine("Press ENTER"); //Footer
            Console.ResetColor(); //Color Reset
            Console.Read(); //Lets the Command Console Stay
        }
    }
};
