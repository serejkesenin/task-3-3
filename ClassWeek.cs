using System;
public sealed class Weeks_Day : IPrint
{
 private string[] mass = {"Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday"};
 public void PrintMass()
{
    Console.WriteLine(" ");
    int n = mass.Length;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(mass[i]);
    }
}
}
