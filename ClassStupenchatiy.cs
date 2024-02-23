using System;
public sealed class Stupenchatiy : Massive, IStup
{
     private int[][] mass;
     public Stupenchatiy(int m, bool choice)
  {
       mass = new int[m][];
      if (choice)
      {
          GetMass_user();
      }
      else
      {
          GetMass();
      }
  }
 public override void GetMass()
{
 int n = mass.GetLength(0);
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        int len = random.Next(0, 10);
        mass[i] = new int[len];
        for (int j = 0; j < len; j++)
        {
            int value = random.Next(0, 10);
            mass[i][j] = value;
        }
    }
} 

    public override void  GetMass_user()
{
    Console.WriteLine("Вы создаете ступенчатый массив  ");
    int n = mass.GetLength(0);
  for (int i = 0; i<n;i++)
  {
      Console.Write($"Введите длину {i+1} строки: ");
      int len = Convert.ToInt32(Console.ReadLine());
      mass[i] = new int[len];
      for (int j = 0; j < len; j++)
      {
          Console.Write($"Элемент [{i},{j}]: ");
          mass[i][j] = Convert.ToInt32(Console.ReadLine());
      }
  }
}
 public override void PrintMass()
{
     Console.WriteLine(" ");
     int c = 0;
     for (int i = 0; i<mass.Length;i++)
     {
         foreach(int el in mass[i])
         {
             if (c != (mass[i].Length - 1))
             {
                 Console.Write($"{el}" + " ");
                 c++;
             }
             else
             {
                 Console.Write($"{el}" + "\n");
                 c = 0;
             }
         }
     }
     Console.WriteLine(" ");
}
 public override void Average()
{
     int sum = 0;
     int n = 0;
     foreach(int[] el in mass)
     {
         foreach(int i in el)
         {
             sum += i;
             n+=1;
         }
     }
    Console.WriteLine($"Среднее значение списка: {sum / n}");
}

  public void EditArray()
{
  for (int i = 0; i<mass.Length;i++)
  {
      for (int j = 0; j < mass[i].Length; j++)
      {
          if (mass[i][j] %2 == 0)
          {
              mass[i][j] = i*j;

          }
      }
  }
}
}

