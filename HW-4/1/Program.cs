// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponent(int a, int x)
{
    if (x == 0)
        return 1;
    else
    {
        int result = a;
        for (int i = 1; i < x; i++)
        {
            result *= a;
        }
        return result;
    }
}

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень возведения числа: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Результат возведения числа {a} в степень {x} равен: {Exponent(a, x)}");