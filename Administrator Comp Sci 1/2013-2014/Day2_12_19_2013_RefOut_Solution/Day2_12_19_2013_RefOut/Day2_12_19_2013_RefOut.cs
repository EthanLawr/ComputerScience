using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_12_19_2013_RefOut
{
    class Day2_12_19_2013_RefOut
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWorking with Ref and Out parameters\n");
            double doorknob = 4.1;
            double cheese;

            //This is nothing new
            Console.WriteLine("\nThe original value is {0}",doorknob);
            TestDefault(doorknob);
            Console.WriteLine("\nUpon return from TestDefault the"
                + " value is {0}",doorknob);

            //Working with ref parameter
            Console.WriteLine("\n\nThe original value is {0}",doorknob);
            TestRef(ref doorknob);
            Console.WriteLine("\nUpon return from TestRef the"
                + " value is {0}",doorknob);

            //Working with the out parameter
            Console.WriteLine("\n\nThe original value is not initialized");
            TestOut(out cheese);
            Console.WriteLine("\nUpon return from TestOut the"
                + " value is {0}",cheese);

            Console.Read();
        }
        public static void TestDefault(double x)
        {
            x = 35.8;
            Console.WriteLine("\nIn TestDefault, the value is {0}",x);
        }
        public static void TestRef(ref double y)
        {
            Console.WriteLine("\nBefore we change the value is {0}",y);
            y = 25.047837;
            Console.WriteLine("\nIn TestRef, the value is {0}",y);
        }
        public static void TestOut(out double z)
        {
            z = 3.1415;
            Console.WriteLine("\nIn TestOut, the value is {0}",z);
        }

    }
}
