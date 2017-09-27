using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Day2
{
    class Switch_Day2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Yes":
                    Console.WriteLine("Thanks, let's continue");
                    break;
                case "yes":
                case "y":
                case "si":
                case "yEs":
                    Console.WriteLine("Let's giddy up");
                    break;

                default:
                    Console.WriteLine("Why don't you want to continue?");
                    break;
            }
            Console.Read();
        }
    }
}
