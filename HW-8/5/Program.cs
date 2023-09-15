// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralFillArray(int[,] array)
{
    int nextNumber = 1;
    int filledRowsUp = 0;
    int filledColsRight = 0;
    int filledRowsDown = 0;
    int filledColsLeft = 0;

    while (filledRowsUp < array.GetLength(0) / 2 + 1)
    {
        for (int j = filledColsLeft; j < array.GetLength(1) - filledColsRight; j++) // заполнение верхних строк
            array[filledRowsUp, j] = nextNumber++;

        filledRowsUp++;

        for (int i = filledRowsUp; i < array.GetLength(0) - filledRowsDown; i++) // заполнение правых столбцов
            array[i, array.GetLength(0) - 1 - filledRowsDown] = nextNumber++;

        filledColsRight++;

        for (int j = array.GetLength(1) - filledColsRight - 1; j >= filledColsLeft; j--) // заполнение нижних строк
            array[array.GetLength(1) - 1 - filledColsLeft, j] = nextNumber++;

        filledRowsDown++;

        for (int i = array.GetLength(1) - filledRowsDown - 1; i >= filledRowsUp; i--) // заполнение левых столбцов
            array[i, filledColsLeft] = nextNumber++;

        filledColsLeft++;
    }
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите размер массива по длине и ширине: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
SpiralFillArray(array);
PrintArray(array);
