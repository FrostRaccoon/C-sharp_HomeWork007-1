/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

var arr = Generate2DArray(4, 4);
Print2DArray(arr);
System.Console.WriteLine();
Sum(arr);

void Sum(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double result = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            result = result + arr[i, j];
        }
        result = result / arr.GetLength(0);
        System.Console.Write(result + "; ");
    }
    Console.WriteLine();
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}