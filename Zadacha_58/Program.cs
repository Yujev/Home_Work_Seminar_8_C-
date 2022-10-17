/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/

Console.WriteLine();
Console.Clear();
Console.Write("Введи количество строк 1-го массива:   \n");
            int rowsA = int.Parse(Console.ReadLine()!);
            Console.Write("Введи количество столбцов 1-го массива:  \n");

    int columnsA = int.Parse(Console.ReadLine()!);
    Console.Write("Введи количество строк 2-го массива:  \n");

          int rowsB = int.Parse(Console.ReadLine()!);
    Console.Write("Введи количество столбцов 2-го массива:  \n");

    int columnsB = int.Parse(Console.ReadLine()!);
if (columnsA != rowsB)
{
  Console.WriteLine("Из этого ничего не выйдет!");
  return;
}
    int[,] A = GetArray(rowsA, columnsA, 0, 10);
    int[,] B = GetArray(rowsB, columnsB, 0, 10);
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
    Console.WriteLine();
    PrintArray(GetMultiplicationMatrix(A,B));
    Console.WriteLine();

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return result;
    }

    void PrintArray(int[,] MyArray)
    {
     for (int i = 0; i < MyArray.GetLength(0); i++)
     {
       for (int j = 0; j < MyArray.GetLength(1); j++)
       {
         Console.Write($"{MyArray[i, j]} ");
       }
       Console.WriteLine();
     }
    }

    int [,] GetMultiplicationMatrix(int[,] ArrayA, int[,] ArrayB)
    {
      int[,] ArrayC = new int[ArrayA.GetLength(0), ArrayB.GetLength(1)];
      for (int i = 0; i < ArrayA.GetLength(0); i++)
      {
        for (int j = 0; j < ArrayB.GetLength(1); j++)
        {
          for (int k = 0; k < ArrayA.GetLength(1); k++)
          {
            ArrayC[i, j] += ArrayA[i, k] * ArrayB[k, j];
          }
        }
      }
      return ArrayC;
    }
