// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine( "Введите целое число и получите его 3-ю цифру" );
int num = Convert.ToInt32( System.Console.ReadLine() );

if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 1000) 
    {
        num /= 10;
    }
    num = num % 10;
    System.Console.WriteLine(num);
}