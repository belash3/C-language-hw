// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double MaxElement(double[] array)
{
    double max = array[0];
    foreach (double number in array)
    {
        if (number > max)
            max = number;
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    foreach (double number in array)
    {
        if (number < min)
            min = number;
    }
    return min;
}

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round((new Random().NextDouble() * 1000), 2); //Создаем случайное вещественное число и округляем до 2 знаков после запятой.

System.Console.WriteLine($"Максималное число массива: {MaxElement(array)}");
System.Console.WriteLine($"Минимальное число массива: {MinElement(array)}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Math.Round(MaxElement(array) - MinElement(array), 2)}");
