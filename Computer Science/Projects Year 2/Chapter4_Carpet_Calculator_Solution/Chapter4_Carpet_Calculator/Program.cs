using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Carpet_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations berber = new Calculations(17.95);
            double roomWidth, roomLength;
            roomLength = GetDimension("Length");
            roomWidth = GetDimension("Width");
            berber.setNoOfSquareYards(roomLength, roomWidth);
            Console.Write(berber.ToString());
            Console.ReadLine();
        }
        static double GetDimension(string side)
        {
            string inputValue;
            int feet, inches;
            Console.Write("Enter the {0} in feet: ", side);
            inputValue = Console.ReadLine();
            feet = int.Parse(inputValue);
            Console.Write("Enter the {0} in inches: ", side);
            inputValue = Console.ReadLine();
            inches = int.Parse(inputValue);
            return (feet + (double)inches / 12);
        }
    }
}
