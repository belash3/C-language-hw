// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetNumbersArray(string str)
{
    int[] result = str!.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(e => Convert.ToInt32(e)).ToArray();
    return result;
}

int IsPositiveCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) result++;
    return result;
}


System.Console.WriteLine("Введите числа через пробел:");
int[] numbers = GetNumbersArray(Console.ReadLine());
System.Console.WriteLine($"Количество положительных чисел: {IsPositiveCount(numbers)}.");
