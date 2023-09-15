// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MinRowNumber(int[,] array)
{
    int[] sumsArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumsArray[i] = sum;
    }

    int minRowNumber = 1;
    int minSum = sumsArray[0];

    for (int i = 0; i < sumsArray.Length; i++)
    {
        if (sumsArray[i] < minSum)
        {
            minRowNumber = i + 1;
            minSum = sumsArray[i];
        }
    }

    System.Console.WriteLine($"Строка {minRowNumber}");
}

System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
MinRowNumber(array);