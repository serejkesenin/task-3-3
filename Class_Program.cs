using System;
class Program
{
 static void Main()
 {
     Massive[] mass = new Massive[3];
     mass[0] = new Odnomerniy(2, true);
     mass[1] = new Dvumerniy(3,3,true);
     mass[2] = new Stupenchatiy(3, true);
     for (int i = 0; i < 3; i++)
     {
         mass[i].PrintMass();
         mass[i].Average();
     }
    ((IOdn)mass[0]).GetMassWoDubs();
    ((IDvum)mass[1]).Print_snake();
     ((IStup)mass[2]).EditArray();

     Weeks_Day masss = new Weeks_Day();
     masss.PrintMass();
 }
}
