using System;
using task_3_3;
class Program
{
 static void Main()
 {
     Massive[] mass = new Massive[3];
     mass[0] = new Odnomerniy(2, false);
     mass[1] = new Dvumerniy(3,3,false);
     mass[2] = new Stupenchatiy(3, false);
    //  for (int i = 0; i < 3; i++)
    //  {
    //      mass[i].PrintMass();
    //      mass[i].Average();
    //  }
   
    
     Weeks_Day masss = new Weeks_Day();
  ///   masss.PrintMass();

    IPrint[] prints = new IPrint [] {mass[0],mass[1],mass[2],masss};
    foreach(var printer in prints){
        printer.PrintMass();
        Console.WriteLine(" ");
    }
     IBase[] bases = new IBase [] {mass[0],mass[1],mass[2]};
    foreach(var base1 in bases){
        base1.Average();
    }

     ((IOdn)mass[0]).GetMassWoDubs();
    ((IDvum)mass[1]).Print_snake();
     ((IStup)mass[2]).EditArray();

 }
}
