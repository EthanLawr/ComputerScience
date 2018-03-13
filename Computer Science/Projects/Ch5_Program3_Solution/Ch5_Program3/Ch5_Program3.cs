using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch5_Program3
{
    class Ch5_Program3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    TaskShortener.Header();
                    Thread tid1 = new Thread(new ThreadStart(Thread1));
                    Thread tid2 = new Thread(new ThreadStart(Thread2));

                    tid1.Start();
                    tid2.Start();
                    TaskShortener.TetrisSong();
                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }

            }
        }
        public static void Thread1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(string.Format("Thread1 {0}", i));
            }
        }

        public static void Thread2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(string.Format("Thread2 {0}", i));
            }
        }
    }
}
