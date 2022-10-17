/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */ 


Console.WriteLine();
Console.WriteLine("Твой массив: ");
Console.WriteLine();
int m = 4;
int n = 4;
int range = new Random().Next(10, 99);

int[,] MyArray = new int[m, n];
CreateArray(MyArray);
WriteArray(MyArray);

Console.WriteLine($"\nОтсортированный по убыванию массив: ");
Console.WriteLine();
OrderArrayLines(MyArray);
WriteArray(MyArray);
Console.WriteLine();

void OrderArrayLines(int[,] MyArray)
{
  for (int i = 0; i < MyArray.GetLength(0); i++)
  {
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
      for (int k = 0; k < MyArray.GetLength(1) - 1; k++)
      {
        if (MyArray[i, k] < MyArray[i, k + 1])
        {
          int count = MyArray[i, k + 1];
          MyArray[i, k + 1] = MyArray[i, k];
          MyArray[i, k] = count;
        }
      }
    }
  }
}

void CreateArray(int[,] MyArray)
{
  for (int i = 0; i < MyArray.GetLength(0); i++)
  {
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
      MyArray[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] MyArray)
{
  for (int i = 0; i < MyArray.GetLength(0); i++)
  {
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
      Console.Write(MyArray[i, j] + " ");
    }
    Console.WriteLine();
  }
}
