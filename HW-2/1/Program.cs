// Напишите программу, которая принимает на вход трёхзначное число и на выходе
//  показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine( "Введите трехзначное число" );
int num = Convert.ToInt32( System.Console.ReadLine() );
num = ( num / 10 ) % 10;
System.Console.WriteLine(num);