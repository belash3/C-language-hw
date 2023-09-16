// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInRange(int m, int n)
{
    if (m == n)
        return m;
    return m + SumNumbersInRange(m + 1, n);
}

System.Console.WriteLine("Введите нижнюю границу M");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите верхнюю границу N");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNumbersInRange(min, max));