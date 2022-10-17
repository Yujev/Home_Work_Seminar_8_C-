/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();
Console.WriteLine();
Console.WriteLine("Введи пожалуйста размер массива через пробел: ");
string[] Numbers = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] MyArray = GetArray(new int[] { int.Parse(Numbers[0]), int.Parse(Numbers[1]), int.Parse(Numbers[2]), }, 10, 100);
Console.WriteLine();
Console.WriteLine("Твой массив с индексами будет такой: ");
PrintArray(MyArray);

int[,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int NewElement = new Random().Next(min, max + 1);
                if (FindElement(result, NewElement)) continue;
                result[i, j, k] = NewElement;
                k++;
            }
        }
    }
    return result;
}


        bool FindElement(int[,,] MyArray, int el)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int k = 0; k < MyArray.GetLength(2); k++)
            {
                if (MyArray[i, j, k] == el) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int k = 0; k < MyArray.GetLength(2); k++)
            {
                Console.Write($"{MyArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine(); 