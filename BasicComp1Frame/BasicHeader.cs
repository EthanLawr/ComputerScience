using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
        string name = "Ethan Lawrence";
        string date = "\t"+DateTime.Now;
        string period = "\tPeriod 4,5,6";
        string teacher = "\tMr. Lynch";
        string endheader = "\n********************************************************************************";
        Console.WriteLine(name);
        Thread.Sleep(50); 
        Console.Clear();
        Thread.Sleep(70);
        Console.WriteLine(name+date);
        Thread.Sleep(70);
        Console.Clear();
        Thread.Sleep(90);
        Console.WriteLine(name+date+period);
        Thread.Sleep(90);
        Console.Clear();
        Thread.Sleep(110);
        Console.WriteLine(name+date+period+teacher);
        Thread.Sleep(110);
        Console.Clear();
        Thread.Sleep(130);
        Console.WriteLine(name+date+period+teacher+endheader);
        Thread.Sleep(130);
        Console.ResetColor();
        Console.ReadKey();
  }
}
