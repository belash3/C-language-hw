// ** Задача ДОП по желанию ** . 
// Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]

int[] Negafibonacci(int k)
{
    int[] result = new int[k * 2 + 1];
    result[result.Length / 2] = 0;
    result[result.Length / 2 + 1] = 1;
    result[result.Length / 2 - 1] = 1;

    for (int i = 2; i <= k; i++)
    {
        result[result.Length / 2 + i] = result[i + result.Length / 2 - 1] + result[i + result.Length / 2 - 2];
        result[result.Length / 2 - i] = (result[i + result.Length / 2 - 1] + result[i + result.Length / 2 - 2]);
        if (i % 2 == 0)
            result[result.Length / 2 - i] *= -1;
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(Negafibonacci(num));