// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[] array)
{
    System.Console.Write($"({array[0]}, {array[1]}) ");
    System.Console.WriteLine();
}


double[,] CreateCoordArray()
{
    double[,] array = new double[2, 2];

    for (int a = 0; a < 2; a++)
    {
        for (int i = 0; i < 2; i++)
        {
            System.Console.WriteLine($"Введите {i + 1}-ю координату прямой {a + 1}: ");
            array[a, i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}

double[] Intersection(double[,] arr)
{
    double[] result = new double[2];
    double x = -(arr[0, 0] - arr[0, 1]) / (arr[1, 0] - arr[1, 1]);
    double y = arr[1, 0] * x + arr[0, 0];
    result[0] = Math.Round(x, 2);
    result[1] = Math.Round(y, 2);
    return result;
}

System.Console.WriteLine("Введите координаты: ");
double[,] array = CreateCoordArray();
PrintArray(Intersection(array));
