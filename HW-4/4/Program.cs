// необязательная задача SORT Написать программу сортировки массива
// от большего к меньшему. Массив задается размерностью N с клавиатуры,
// далее заполняется случайными целыми числами от -100 до 100, выводится
// на экран. Сортируется, и затем опять выводится на экран.

int[] CreateRndArray(int length, int rndMin, int rndMax)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(rndMin, rndMax);
    }
    return array;
}

int[] SortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
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
    System.Console.WriteLine("");
}

System.Console.WriteLine("Введите длину массива случайных чисел от -100 до 100:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRndArray(length, -100, 100);
System.Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine("Отсортированный массив: ");
PrintArray(SortArray(array));