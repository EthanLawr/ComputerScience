using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    
    /* Start of the header */
    Console.ForegroundColor = ConsoleColor.Cyan; //Sets the color to Cyan
        string name = "Ethan Lawrence"; 
        //Allows me to type my name in a shorter amount of time
        var date = "\t"+System.IO.File.GetLastWriteTime("Path.GetFileName(fileName)"); 
        //Gives the date and time of when the file was last saved
        string period = "\tPeriod 4,5,6"; 
        //Shows what periods the class is from
        string teacher = "\tMr. Lynch"; 
        //Shows my teacher's last name
        string endheader = "\n********************************************************************************"; 
        //Ends the header
        Console.WriteLine(name); //Writes my name
        Thread.Sleep(50); //Sustains my name
        Console.Clear(); //Clears my name
        Thread.Sleep(70); //"Loading" time
        Console.WriteLine(name+date); 
        //Writes my name and the date w/ the time
        Thread.Sleep(70); //Sustains my name and the date w/ the time
        Console.Clear(); //Clears my name and the date w/ the time
        Thread.Sleep(90); //"Loading" time
        Console.WriteLine(name+date+period); 
        //Writes my name, the date w/ the time, and the period
        Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
        Console.Clear(); //Clears my name, the date w/ the time, and the period
        Thread.Sleep(110); //"Loading" Time
        Console.WriteLine(name+date+period+teacher); 
        //Writes my name, the date w/ the time, period, and teacher name
        Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
        Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
        Thread.Sleep(130); //"Loading" Time
        Console.WriteLine(name+date+period+teacher+endheader); 
        //Writes my name, the date w/ the time, period, teacher name, and ends the header
        Thread.Sleep(130); //"Loading" Time
        Console.ResetColor(); //Resets the color for non header lines
        /* End of the header */
    
        Console.ReadKey(); //Lets the header be read
  }
}
