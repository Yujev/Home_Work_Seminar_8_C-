/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
 суммой элементов: 1 строка 
 */
Console.Clear();
Console.WriteLine();
Console.Write("Введи количество строк: \n");
int rows = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введи количество столбцов: \n");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] MyArray = GetArray(rows, columns, 0, 10);
Console.WriteLine("Твой массив: ");
Console.WriteLine();
PrintArray(MyArray);

Console.WriteLine();
Console.WriteLine($" {GetRowNumber(MyArray)}-я строка с наименьшей суммой элементов. (Нумерация начинается с нуля).");
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
int GetRowNumber(int[,] MyArray)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < MyArray.GetLength(1); i++)
    {
        minsum = minsum + MyArray[0, i];
    }

    for (int i = 1; i < MyArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            sum = sum + MyArray[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}


