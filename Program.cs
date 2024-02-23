// using System;
// class Program
// {
//  static void Main()
//  {
//      Massive[] mass = new Massive[3];
//      mass[0] = new Odnomerniy(2, true);
//      mass[1] = new Dvumerniy(3,3,true);
//      mass[2] = new Stupenchatiy(3, true);
//      for (int i = 0; i < 3; i++)
//      {
//          mass[i].GetMass();
//          mass[i].PrintMass();
//          mass[i].Average();
//      }
//      Weeks_Day masss = new Weeks_Day();
//      masss.PrintMass();
//  }
// }



// public abstract class Massive: IBase
// {
//   public abstract void GetMass();
//   public abstract void GetMass_user();

//   public abstract void PrintMass();

//   public abstract void Average();
// }


// interface IPrint
// {
//  void PrintMass();
// }


// interface IBase:IPrint
// {
//  void GetMass();
//  void GetMass_user();
//  void Average();
// }


// interface IOdn
// { 
//     void GetMassWoDubs();
// }


// public  class Odnomerniy : Massive, IOdn
// {
// private int[] mass;


//     public Odnomerniy(int N, bool choice)
//     {
//     mass = new int[N];
//     if (choice)
//     {
//         GetMass();
//     }
//     else
//     {
//         GetMass_user();
//     }
//     }

// public override void GetMass()
// {
//     Random random = new Random();
//      for (int i = 0; i < mass.Length; i++)
//      {
//          int val = random.Next(0,10);
//          mass[i] = val;
//      }
// }

// public override void GetMass_user()
// {
//     for (int i = 0; i < mass.Length; i++)
//        {
//            int x = int.Parse(Console.ReadLine());
//            mass[i] = x;
//         }
// }
//  public override void PrintMass()
// {
//     Console.WriteLine(" ");
//     int n = mass.Length;
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(mass[i] + " ");
//     }
// }



// public override void Average()
// {
//     int sum = 0;
//     foreach(int el in mass)
//  {
//      sum += el;
//  }
//     Console.WriteLine($"Среднее значение в массиве: {sum / mass.Length}");
//     Console.WriteLine(" ");
// }
//  public  void  GetMassWoDubs()
//  {
//    int newMassLength = mass.Length;
//    for(int i = 0; i < mass.Length; i++)
//    {
//    for(int j = i; j < mass.Length; j++)
//    {
//        if(mass[i] == mass[j] && i != j)
//        {
//            newMassLength--;
//            break;
//        }
//    }
//    }
//    Console.WriteLine("New array length = " + newMassLength + "\n");

//    int[] newMass = new int[newMassLength];
//    for(int i = 0; i < newMass.Length; i++)
//    {
//        newMass[i] = int.MinValue;
//    }
//    int c = 0;
//    for(int i = 0; i < mass.Length; i++)
//    {
//        if(!Ex(mass[i], newMass))
//        {
//            newMass[c] = mass[i];
//            c++;
//            //   Console.WriteLine("newMass[" + (c - 1) + "]= " + newMass[c] + " ");
//        }
//    }
//  }


//  public bool Ex(int val, int[] mass)
//  {
//    for(int i = 0; i < mass.Length; i++)
//    {
//        if(mass[i] == val)
//        {
//            return true;
//        }
//    }
//    return false;
//  }


// }



// interface IDvum
// {

//  void Print_snake();
// }


// public sealed class Dvumerniy : Massive, IDvum
// {
    
//   public int[,] mass;
//    public Dvumerniy(int m1, int m2, bool choice)
//    {
//       int[,] mass = new int[m1,m2];
//       if (choice)
//       {
//           GetMass_user();
//       }
//       else
//       {
//           GetMass();
//       }
//    }

//  public override void GetMass()
// {
//  int m1 = mass.GetLength(0);
//  int m2 = mass.GetLength(1);
//      Random random = new Random();
//      for (int i = 0; i < m1; i++)
//        {
//            for(int j =  0; j < m2; j++)
//            {
//                mass[i, j] =  random.Next(0,10);
//            }
//        }
// }

//  public override void GetMass_user()
// {
//      int m1 = mass.GetLength(0);
//      int m2 = mass.GetLength(1);
//       for (int i = 0; i < m1; i++)
//       {
//           for(int j =  0; j < m2; j++)
//           {
//               Console.Write($"Элемент [{i},{j}]: ");
//               mass[i, j] = Convert.ToInt32(Console.ReadLine());
//           }
//       }
// }

//  public override void PrintMass()
// {
//      int c = 0;
//      Console.WriteLine(" ");
//      foreach(int el in mass)
//          {
//              if (c != (mass.GetLength(0) - 1))
//              {
//                  Console.Write($"{el}" + " ");
//                  c++;
//              }
//              else
//              {
//                  Console.Write($"{el}" + "\n");
//                  c = 0;
//              }
//          }
//          Console.WriteLine(" ");
//      }
//  public override void Average()
// {
//      int sum = 0;
//      foreach(int el in mass)
//      {
//              sum += el;
//      }
//     Console.WriteLine($"Среднее значение списка: {sum / mass.Length}");
//     Console.WriteLine(" ");
// }
//     public void Print_snake()
// {
//     int m1 = mass.GetLength(0);
//     int m2 = mass.GetLength(1);
//   Console.WriteLine(" ");
//   for (int i = 0; i < m1; i++)
//   {
//           if (i%2 == 0)
//           {
//               for (int g = m2 - 1; g >= 0; g--)
//               {
//                   if (g==0)
//                   {Console.Write($"{mass[i,g]}" + "\n");}
//                   else
//                   {Console.Write($"{mass[i,g]}" + " ");}
//               }
//           }
//           else
//           {
//               for (int j = 0; j < m2; j++)
//               {
//                   if (j == m2 - 1)
//                   {Console.Write( $"{mass[i,j]}" + "\n");}
//                   else
//                   {Console.Write( $"{mass[i,j]}" + " ");}
//               }
//           }
// }
// }
// }
// interface IStup
// {
//  void EditArray();
// }


// public sealed class Stupenchatiy : Massive, IStup
// {
//      private int[][] mass;
//      public Stupenchatiy(int m, bool choice)
//   {
//       int[][] mass = new int[m][];
//       if (choice)
//       {
//           GetMass_user();
//       }
//       else
//       {
//           GetMass();
//       }
//   }
//  public override void GetMass()
// {
//  int n = mass.GetLength(0);
//     Random random = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         int len = random.Next(0, 10);
//         mass[i] = new int[len];
//         for (int j = 0; j < len; j++)
//         {
//             int value = random.Next(0, 10);
//             mass[i][j] = value;
//         }
//     }
// } 

//     public override void  GetMass_user()
// {
//     int n = mass.GetLength(0);
//   for (int i = 0; i<n;i++)
//   {
//       Console.Write($"Введите длину {i+1} строки: ");
//       int len = int.Parse(Console.ReadLine());
//       mass[i] = new int[len];
//       for (int j = 0; j < len; j++)
//       {
//           Console.Write($"Элемент [{i},{j}]: ");
//           mass[i][j] = Convert.ToInt32(Console.ReadLine());
//       }
//   }
// }
//  public override void PrintMass()
// {
//      Console.WriteLine(" ");
//      int c = 0;
//      for (int i = 0; i<mass.Length;i++)
//      {
//          foreach(int el in mass[i])
//          {
//              if (c != (mass[i].Length - 1))
//              {
//                  Console.Write($"{el}" + " ");
//                  c++;
//              }
//              else
//              {
//                  Console.Write($"{el}" + "\n");
//                  c = 0;
//              }
//          }
//      }
//      Console.WriteLine(" ");
// }
//  public override void Average()
// {
//      int sum = 0;
//      int n = 0;
//      foreach(int[] el in mass)
//      {
//          foreach(int i in el)
//          {
//              sum += i;
//              n+=1;
//          }
//      }
//     Console.WriteLine($"Среднее значение списка: {sum / n}");
// }

//   public void EditArray()
// {
//   for (int i = 0; i<mass.Length;i++)
//   {
//       for (int j = 0; j < mass[i].Length; j++)
//       {
//           if (mass[i][j] %2 == 0)
//           {
//               mass[i][j] = i*j;

//           }
//       }
//   }
// }
// }






// public sealed class Weeks_Day : IPrint
// {
//  private string[] mass = {"Пн","Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//  public void PrintMass()
// {
//     Console.WriteLine(" ");
//     int n = mass.Length;
//     for (int i = 0; i < n; i++)
//     {
//         Console.WriteLine(mass[i]);
//     }
// }
// }
