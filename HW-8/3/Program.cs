// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(2, 5);
}

void PrintArray(string message, int[,] array)
{
    System.Console.WriteLine(message);
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] matrixMultiply(int[,] matr1, int[,] matr2)
{
    int length = matr1.GetLength(0);
    int[,] result = new int[length, length];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                result[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return result;
}

System.Console.WriteLine("Введите количество строк и столбцов:");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];

FillArray(matrix1);
FillArray(matrix2);
PrintArray("Матрица 1: ", matrix1);
PrintArray("Матрица 2: ", matrix2);
PrintArray("Результирующая матрица: ", matrixMultiply(matrix1, matrix2));