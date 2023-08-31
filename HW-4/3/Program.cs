// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// случайных целых чисел от 1 до 50 и выводит их на экран.

int[] CreateRndArray(int length, int rndMin, int rndMax)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(rndMin, rndMax);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}.");
}

PrintArray(CreateRndArray(8, 0, 50));