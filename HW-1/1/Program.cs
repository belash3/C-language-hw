// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine( "Введите первое из двух целых чисел для сравнения" );
int num1 = Convert.ToInt32( System.Console.ReadLine() );
System.Console.WriteLine( "Введите второе из двух целых чисел для сравнения" );
int num2 = Convert.ToInt32( System.Console.ReadLine() );

if (num1>num2)
{
    System.Console.WriteLine($"Первое число больше второго, и это {num1}");
}
else 
{
    System.Console.WriteLine($"Второе число больше первого, и это {num2}");
}