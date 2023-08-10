// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

System.Console.WriteLine( "Введите число и получите количество цифр в нем" );
double num = Convert.ToDouble( System.Console.ReadLine() );
int result = 0;

if (num == 0) {
    result ++;
}

else if (num > 1)
{
    while (num % 1 != 0)
    {
        num = num * 10;
    }
    while (num >= 1)
    {
        num = num / 10;
        result++;
    }
}
else if (num < 1)
{
    while (num % 10 != 0)
    {
        num = num * 10;
        result++;
    }
    // while (num > 1)
    // {
    //     num = num / 10;
    //     result++;
    // }
}


System.Console.WriteLine($"Количество цифр равно: {result}");