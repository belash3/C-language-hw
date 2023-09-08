// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 1000);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] ShuffleArray(int[,] array)
{
    int iterations = 0;
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int buff = array[array.GetLength(0) / 2 - i + 1, j];
            array[array.GetLength(0) / 2 - i + 1, j] = array[i, j];
            array[i, j] = buff;
            iterations++;
        }
    }
    System.Console.WriteLine($"Итераций выполнено: {iterations}");
    return array;
}

System.Console.WriteLine("Введите размерность массива m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите размерность массива n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
array = FillArray(array);
PrintArray(array);
ShuffleArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Итераций по условию, не более: {m * n / 2}");
System.Console.WriteLine();
PrintArray(array);

// Не доработал до конца, работает нормально только с четным количеством строк((

