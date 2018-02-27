using System;
using System.Threading;

namespace Ch3_LargeBooleanProgram
{
    class LargeBooleanProgram
    {
        static void Main(string[] args)
        {
            ConsoleSize(); //Adjusts the size of the console
            Header(); //Header

            #region Variables
            int integerOne = 100, integerTwo = 97, integerThree = 32, integerFour = 5,
                integerFive = 63;
            //Declared integers

            bool intOneTwo = integerOne == integerTwo,          //int1 == int2
                 intTwoThree = integerTwo == integerThree,      //int2 == int3
                 intThreeFour = integerThree == integerFour,    //int3 == int4
                 intFourFive = integerFour == integerFive,      //int4 == int5
                 intFiveOne = integerFive == integerOne;        //int5 == int1
            //Seeing if any of the declared integers are equal to each other

            bool lessOneTwo = integerOne < integerTwo,          //int1 < int2
                 lessTwoThree = integerTwo < integerThree,      //int2 < int3
                 lessThreeFour = integerThree < integerFour,    //int3 < int4
                 lessFourFive = integerFour < integerFive,      //int4 < int5
                 lessFiveOne = integerFive < integerOne;        //int5 < int1
            //Seeing if any of the declared integers are less than others

            bool boolFalse = false, boolTrue = true;
            //For if any of the later declared integers are equal to 1, 10, or 100
            #endregion

            FormattingTheProgram(); //Styling and formatting

            #region Equal Integers Display
            Console.WriteLine("{0}\t=\t{1}\t\tis\t{2}", integerOne, integerTwo, 
                intOneTwo);   
            Console.WriteLine("{0}\t=\t{1}\t\tis\t{2}", integerTwo, integerThree, 
                intTwoThree); 
            Console.WriteLine("{0}\t=\t{1}\t\tis\t{2}", integerThree, integerFour, 
                intThreeFour);
            Console.WriteLine("{0}\t=\t{1}\t\tis\t{2}", integerFour, integerFive, 
                intFourFive); 
            Console.WriteLine("{0}\t=\t{1}\t\tis\t{2}", integerFive, integerOne, 
                intFiveOne); 
            Console.WriteLine("\n");    //Spacer
            /*  integerOne   == integerTwo
                integerTwo   == integerThree
                integerThree == integerFour
                integerFour  == integerFive
                integerFive  == integerOne   */
            #endregion

            #region Less Than Integers Display
            Console.WriteLine("{0}\t<\t{1}\t\tis\t{2}", integerOne, integerTwo, 
                lessOneTwo);   
            Console.WriteLine("{0}\t<\t{1}\t\tis\t{2}", integerTwo, integerThree, 
                lessTwoThree); 
            Console.WriteLine("{0}\t<\t{1}\t\tis\t{2}", integerThree, integerFour, 
                lessThreeFour);
            Console.WriteLine("{0}\t<\t{1}\t\tis\t{2}", integerFour, integerFive, 
                lessFourFive); 
            Console.WriteLine("{0}\t<\t{1}\t\tis\t{2}", integerFive, integerOne, 
                lessFiveOne);
            Console.WriteLine("\n");    //Spacer
            /*  is integerOne   <  integerTwo
                is integerTwo   <  integerThree
                is integerThree <  integerFour
                is integerFour  <  integerFive
                is integerFive  <  integerOne   */
            #endregion

            #region Equal to 1, 10, or 100
            #region IntegerOne
            if (integerOne == 1)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerOne, 
                    boolTrue);
            }   //Is IntegerOne equal to 1?
            else if (integerOne == 10)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerOne, 
                    boolTrue);
            }   //Is IntegerOne equal to 10?
            else if (integerOne == 100)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerOne, 
                    boolTrue);
            }   //Is IntegerOne equal to 100?
            else
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerOne, 
                    boolFalse);
                //Is IntegerOne not equal to 1, 10, or 100?
            }
            #endregion

            #region IntegerTwo
            if (integerTwo == 1)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerTwo, 
                    boolTrue);
            }   //Is IntegerTwo equal to 1?
            else if (integerTwo == 10)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerTwo, 
                    boolTrue);
            }   //Is IntegerTwo equal to 10?
            else if (integerTwo == 100)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerTwo, 
                    boolTrue);
            }   //Is IntegerTwo equal to 100?
            else
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerTwo, 
                    boolFalse);
                //Is IntegerTwo not equal to 1, 10, or 100?
            }
            #endregion

            #region IntegerThree
            if (integerThree == 1)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerThree, 
                    boolTrue);
            }   //Is IntegerThree equal to 1?
            else if (integerThree == 10)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerThree, 
                    boolTrue);
            }   //Is IntegerThree equal to 10?
            else if (integerThree == 100)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerThree, 
                    boolTrue);
            }   //Is IntegerThree equal to 100?
            else
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerThree, 
                    boolFalse); //Is IntegerThree not equal to 1, 10, or 100?
            }
            #endregion

            #region IntegerFour
            if (integerFour == 1)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFour, 
                    boolTrue);
            }   //Is IntegerFour equal to 1?
            else if (integerFour == 10)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFour, 
                    boolTrue);
            }   //Is IntegerFour equal to 10?
            else if (integerFour == 100)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFour, 
                    boolTrue);
            }   //Is IntegerFour equal to 100?
            else
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFour, 
                    boolFalse);
                //Is IntegerFour not equal to 1, 10, or 100?
            }
            #endregion

            #region IntegerFive
            if (integerFive == 1)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFive, 
                    boolTrue);
            }   //Is IntegerFive equal to 1?
            else if (integerFive == 10)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFive, 
                    boolTrue);
            }   //Is IntegerFive equal to 10?
            else if (integerFive == 100)
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFive, 
                    boolTrue);
            }   //Is IntegerFive equal to 100?
            else
            {
                Console.WriteLine("{0}\t=\t1, 10, or 100\tis\t{1}", integerFive, 
                    boolFalse);
                //Is IntegerFive not equal to 1, 10, or 100?
            }
            #endregion
            /*  is integerOne   =  1, 10, or 100
                is integerTwo   =  1, 10, or 100
                is integerThree =  1, 10, or 100
                is integerFour  =  1, 10, or 100
                is integerFive  =  1, 10, or 100    */
            #endregion

            Footer(); //Footer
            Console.ReadLine();
        }
        public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create a program that uses boolean "
                + "variables";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************\n\n";
            //Ends the header
            Console.WriteLine(name); //Writes my name
            Thread.Sleep(50); //Sustains my name
            Console.Clear(); //Clears my name
            Thread.Sleep(70); //"Loading" time
            Console.WriteLine(name + date);
            //Writes my name and the date w/ the time
            Thread.Sleep(70); //Sustains my name and the date w/ the time
            Console.Clear(); //Clears my name and the date w/ the time
            Thread.Sleep(90); //"Loading" time
            Console.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Console.Clear(); //Clears my name, the date w/ the time, and the period
            Thread.Sleep(110); //"Loading" Time
            Console.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            Thread.Sleep(130);
            Console.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Console.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(150); //"Loading" Time
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
        }
        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
        }
        public static void ConsoleSize()
        {
            int origWidth = Console.WindowWidth, origHeight = Console.WindowHeight;
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight*2);
        }
        public static void FormattingTheProgram()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Style Color to go with the Header and Footer

            Console.WriteLine("Num1\tOpt\tNum2\t\tis\tResult"); //Titles of Collumns
            Console.WriteLine("----\t---\t----\t\t--\t------"); //Seperator
        }
    }
}