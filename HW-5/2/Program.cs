// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int OddPositionSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result += array[i];
    }
    return result;
}

int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-999, 1000);

System.Console.WriteLine($"Сумма элементов на нечетных позициях массива: {OddPositionSum(array)}");