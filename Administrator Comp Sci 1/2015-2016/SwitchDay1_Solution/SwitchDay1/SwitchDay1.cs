using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDay1
{
    class SwitchDay1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "yes":
                    Console.WriteLine("Thanks for wanting to continue . . . ");
                    break;
                case "YES":
                case "Yes":
                case "y":
                case "Y":
                    Console.WriteLine("Thanks for continuing . . . ");
                    break;
                default:
                    Console.WriteLine("Why?");
                    break;
            }

            Console.Read();
        }
    }
}
