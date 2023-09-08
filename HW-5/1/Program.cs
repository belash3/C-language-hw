// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNumbersCount(int[] array)
{
    int result = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
            result++;
    }
    return result;
}

int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

System.Console.WriteLine($"Количество четных элементов в массиве: {EvenNumbersCount(array)}");