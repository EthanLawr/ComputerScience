using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuckleheadMethod
{
    class KnuckleheadMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Header\n\n");

            //double method
            double firstNum = DoubleMethod("your length");
            double secondNum = DoubleMethod("your width");
            double thirdNum = DoubleMethod("your height");

            //Volume of a box
            double volumeBox = firstNum * secondNum * thirdNum;

            //Void Display method
            DisplayMethod(firstNum, secondNum, thirdNum, volumeBox);

            Console.WriteLine("Please hit ENTER to exit");
            Console.Read();
        }
        public static void DisplayMethod(double x, double y, double z, double a)
        {
            Console.WriteLine("We're in the method now");
            Console.WriteLine("If your length is {0} ft. and width is {1} ft.,"
                +" and your height is {2} ft.",x,y,z);
            Console.WriteLine("Then your volume is {0} cubic feet",a );
        }
        public static double DoubleMethod(string x)
        {
            Console.WriteLine("Please enter {0}",x);
            string input = Console.ReadLine();
            double inputDouble = Convert.ToDouble(input);
            return inputDouble;
        }
    }
}
