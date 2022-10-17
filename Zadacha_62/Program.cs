/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


Console.WriteLine();
Console.Write($"Будь любезен, введи размер массива: \n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine( "Твой спиральный массив: ");
Console.WriteLine();
int[,] MyArray = new int[n, n];

int с = 1;
int i = 0;
int j = 0;

while (с <= MyArray.GetLength(0) * MyArray.GetLength(1))
{
    MyArray[i, j] = с;
    с++;
    if (i <= j + 1 && i + j < MyArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= MyArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > MyArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(MyArray);

void WriteArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            if (MyArray[i, j] / 10 <= 0)
                Console.Write($" {MyArray[i, j]} ");

            else Console.Write($"{MyArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();