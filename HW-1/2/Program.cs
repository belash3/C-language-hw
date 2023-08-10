// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine( "Введите первое из трех целых чисел для сравнения" );
int num1 = Convert.ToInt32( System.Console.ReadLine() );
System.Console.WriteLine( "Введите второе из трех целых чисел для сравнения" );
int num2 = Convert.ToInt32( System.Console.ReadLine() );
System.Console.WriteLine( "Введите третье из трех целых чисел для сравнения" );
int num3 = Convert.ToInt32( System.Console.ReadLine() );
int max = num1;
if (num2>max) 
{
    max = num2;
}
if (num3>max)
{
    max = num3;
}
    System.Console.WriteLine($"Максимальное число {max}");

