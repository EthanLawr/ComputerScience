using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_IntroPractice
{
    class Day1_IntroPractice
    {

        static void Main(string[] args)
        {
            Console.WriteLine(@"
.____                          .__     
|    |    ___.__. ____    ____ |  |__
|    |   <   |  |/    \ /  ___\|     \ 
|    | ___\___  |   |  \\  |___Y  |  |
| _______ \/ ___| ___   |\___  >__|  |
         \/\/         \/     \/    \/ ");      

            #region Header
            //This is my header
            Console.WriteLine("Title: <insert here>\t\tAuthor: Lynch\n");
            Console.WriteLine("Date: <insert here>\n");
            Console.WriteLine("Purpose: <insert here>\n");
            Console.WriteLine("***********************************************\n\n\n");
            #endregion

            Console.Write("\"Lynch\""); //I wanted a " to show

            Console.WriteLine("Hello\\ World . . . "); //escape sequence 
            Console.WriteLine(""); //for a single backslash \
            Console.WriteLine("");

            //Comments are in green
            Console.WriteLine("Comp \tSci \nis \afun!");

            Console.WriteLine("");

            #region End PRogram
            //End program
            Console.WriteLine("Please hit ENTER to end program");
            Console.Read();
            #endregion


        }
        
    }
}
