// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

bool IsPalindrome(int number)
{
    int temp = number;
    int reversed = 0;
    while (temp > 0)
    {
        reversed = reversed * 10 + temp % 10;
        temp /= 10;
    }
    return number == reversed;
}

System.Console.WriteLine("Введите число и узнайте, является ли оно палиндромом:");
int num = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(num))
    System.Console.WriteLine("Число является палиндромом");
else
    System.Console.WriteLine("Число не является палиндромом");