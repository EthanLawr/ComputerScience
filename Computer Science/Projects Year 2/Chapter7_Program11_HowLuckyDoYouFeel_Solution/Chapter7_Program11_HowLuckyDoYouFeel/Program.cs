using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Program11_HowLuckyDoYouFeel
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            for (int f = 0; f < 10000; f++)
            {
                // User 1
                var numberList = Enumerable.Range(1, 100).ToList();
                Random r = new Random();
                List<int> UniqueRandoms = new List<int>();

                for (int i = 0; i < 9; ++i)
                {
                    int idx = r.Next(0, numberList.Count);
                    UniqueRandoms.Add(numberList[idx]);
                    numberList.RemoveAt(idx);
                }

                // User 2
                var numberList2 = Enumerable.Range(1, 100).ToList();
                List<int> UniqueRandoms2 = new List<int>();

                for (int i = 0; i < 9; ++i)
                {
                    int idx = r.Next(0, numberList2.Count);
                    UniqueRandoms2.Add(numberList2[idx]);
                    numberList2.RemoveAt(idx);
                }

                List<int> UniqueRandoms3 = new List<int>();
                Console.Write("Unique Randoms:");
                foreach (int x in UniqueRandoms)
                {
                    UniqueRandoms3.Add(x);
                    Console.Write(" {0:d}", x);
                }
                Console.WriteLine();

                List<int> UniqueRandoms4 = new List<int>();
                Console.Write("Unique Randoms:");
                foreach (int x in UniqueRandoms2)
                {
                    UniqueRandoms4.Add(x);
                    Console.Write(" {0:d}", x);
                }
                Console.WriteLine();
                if (UniqueRandoms3.Any(x => UniqueRandoms4.Any(y => x.Equals(y))) == true) h++;
            }
            Console.WriteLine("There is a {0}% chance of winning!", (double)h / 100.0);

            Console.ReadKey();
        }
    }
}
