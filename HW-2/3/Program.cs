// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели от 1 до 7");
int day = Convert.ToInt32( Console.ReadLine() );

if (day < 1 || day > 7) 
{
    System.Console.WriteLine("Такого дня недели нет. Введите число от 1 до 7.");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("Будний день");
}