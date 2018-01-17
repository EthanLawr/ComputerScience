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
            HeaderFooter.Header(); //Header
            Colors.MagentaFont(); //Magenta Font
            Statement("Ethan", $"{DateTime.Now}", "1"); //Void method
            Console.WriteLine("\n\n"); // Spacing!
            HeaderFooter.Footer(); //Footer 
        }
        public static void Statement(string x, string y, string z)
        {
            Console.WriteLine("Author: {0}", x);
            Console.WriteLine("Date: {0}", y);
            Console.WriteLine("Day: {0} ", z);
        }
    }
}
