// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    int result = 0;
    while (num >= 1)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

System.Console.WriteLine("Введите целое число и получите сумму его цифр: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumOfDigits(num));