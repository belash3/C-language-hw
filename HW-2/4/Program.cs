// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 1,45 -> 1,5
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine( "Введите положительное число: " );
double enteredNumber = Convert.ToDouble( System.Console.ReadLine() );
decimal num = (decimal)enteredNumber;
int position = 0; // количество знаков после запятой
int numberOfDigits = 0; // разрядность числа


if (num > 1)
{
    if (num % 1 != 0) // вычисляем количество знаков после запятой
    {
        while (num % 1 != 0)
        {
            num *= 10;
            position++;
        }
    }

    while (num > 1) // вычисляем разрядность числа
    {
        num /= 10;
        numberOfDigits++;
    }
}
else if (num < 1)
{
    while (num % 1 != 0) // вычисляем разрядность числа
    {
        num *= 10;
        numberOfDigits++;
    }
    position = numberOfDigits;
    numberOfDigits++;


}
if ( numberOfDigits == 0)
    numberOfDigits ++;
// System.Console.WriteLine($"Количество знаков после запятой {position}");
// System.Console.WriteLine($"Разрядность числа {numberOfDigits}");

if (numberOfDigits == 1)
{
    System.Console.WriteLine("В этом числе только 1 цифра");
}
else if (numberOfDigits > 1)
{
    if (enteredNumber > 10)
    {
        decimal head = Math.Floor(num * 10); // получаем первую цифру числа
        while (num < 10)
        {
            num *= 10;
            // System.Console.WriteLine(num);
        }
        decimal tail = num % 1;
        // System.Console.WriteLine(tail);

        num = head + tail;
        // System.Console.WriteLine(num);

        while (num % 1 != 0)
        {
            num *= 10;
        }
        for (int i = position; i > 0; i--)
        {
            num /= 10;
        }

    }
    else if (enteredNumber < 10 && enteredNumber > 1)
    {
        decimal head = Math.Floor(num * 10);
        while (num < 10)
        {
            num *= 10;
            // System.Console.WriteLine(num);
        }
        decimal tail = num % 1;
        // System.Console.WriteLine(tail);

        num = head + tail;
        // System.Console.WriteLine(num);

    }
        else if (enteredNumber < 1)
    {
        
        // System.Console.WriteLine(num);
        decimal head = 0;

        for ( int i = position; i > 0; i -- ) 
        {
            num /= 10;
        }
        num *= 10;
        decimal tail = num % 1;
        // System.Console.WriteLine(tail);

        num = head + tail;

        // System.Console.WriteLine(num);

    }
            double result = Convert.ToDouble(num);
        System.Console.WriteLine($"Результат: {result}");
}