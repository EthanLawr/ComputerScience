using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Exercise1
{
    class Ch4_Exercise1
    {
        static void Main(string[] args)
        {
            int origWidth = Console.WindowWidth, origHeight = Console.WindowHeight;
            Console.SetWindowSize(origWidth, origHeight*2);

            HeaderFooter.Header(); //Header

            Colors.MagentaFont(); //Magenta Font
            Statement("Ethan", $"{DateTime.Now}", "1"); //Void method
            HitAnyKeyToContinue("knucklehead");
            HitAnyKeyToContinue("super knucklehead");
            HitAnyKeyToContinue("super duper knucklehead");

            HeaderFooter.Footer("ANY KEY"); //Footer 
        }
        public static void Statement(string x, string y, string z)
        {
            Console.WriteLine("Author: {0}", x);
            Console.WriteLine("Date: {0}", y);
            Console.WriteLine("Day: {0} ", z);
        }
        public static void HitAnyKeyToContinue(string x)
        {
            Console.WriteLine("\n\nPlease hit ANY key to continue . . . ");
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
