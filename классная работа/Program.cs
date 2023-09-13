// // See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// double Distance(double x1, double x2, double y1, double y2)
// {
//     double result = 0;
//     result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))
//     return result;

// }

// System.Console.WriteLine("Введите первую координату точки X");
// double x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату точки X");
// double x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите первую координату точки Y");
// double y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату точки Y");
// double y2 = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine(Distance(x1, x2, y1, y2));


// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// // от 1 до N.

// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

// string Sqare(int num)
// {
//     string result = "";
//     for (int i = 1; i < num; i++)
//     {
//         result += $"{i * i}, ";
//     }
//     result += $"{num * num}.";
//     return result;
// }

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Sqare(num));

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
//  произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Сomposition(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Произведение чисел от 1 до n равно: {Сomposition(n)}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] CreateArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Random rnd = new Random();
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }

// PrintArray(CreateArray());

// bool IsPalindrome(int number)
// {
//     // Введите свое решение ниже
//     bool result = false;
//     int temp = number;
//     int reversed = 0;
//     if (((int)Math.Abs(number)).ToString().Length == 5)
//     {
//         while (temp > 0)
//         {
//             reversed = reversed * 10 + temp % 10;
//             temp /= 10;
//         }

//     }
//     else 
//     {
//         System.Console.WriteLine("Число не пятизначное");
//     }
//     result = number == reversed;
//     return result;

// }
// System.Console.WriteLine(IsPalindrome(123222));

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void Ineverse(int[] array)
// {
//     for(int i = 0; i < array.Length; i++ )
//     {
//         array[i] = -array[i];
//     }
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// Ineverse(array);
// PrintArray(array);



// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100,100);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int FindNumbers(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]<=99 && array[i]>=10)
//         {
//             result++;
//         }
//     }
//     return result;
// }

// int[] array = new int[15];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(FindNumbers(array));


// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон
// 10:21

// bool Triangle(int a, int b, int c)
// {
//     bool result = false;
//     if(a<(b+c) && b<(a+c) && c<(a+b))
//         result = true;
//     // int perimeter = a + b + c;
//     // System.Console.WriteLine($"Периметр треугольника равен: {perimeter}");
//     // if((a*a) == (b*b)+(c*c) || (b*b) == (a*a) + (c*c) || (c*c) == (b*b) + (a*a))
//     // {
//     //     System.Console.WriteLine("Треугольник является прямоугольным");
//     // }
//     return result;

// }

// System.Console.WriteLine("Введите сторону треугольника a");
// int a = Convert.ToInt32(Console.ReadLine() );
// System.Console.WriteLine("Введите сторону треугольника b");
// int b = Convert.ToInt32(Console.ReadLine() );
// System.Console.WriteLine("Введите сторону треугольника c");
// int c = Convert.ToInt32(Console.ReadLine() );
// System.Console.WriteLine(Triangle(a, b, c));




// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string Binare(int number)
// {
//     string result = "";
//     while(number > 0)
//     {
//         result =  (number % 2) + result;
//         number /= 2;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine() );
// System.Console.WriteLine(Binare(num));

// 5. Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
    
//     *Пример:*
    
//     - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]


int[] Fibonacci(int n)
{
    int[] result = new int[n*2-1];
    result[result.Length/2] = 0;
    result[result.Length/2+1] = 1;
    result[result.Length/2-1] = 1;

        for (int i = 2; i < n; i++)
        {
            result[result.Length/2+i] = result[i+result.Length/2-1] + result[i+result.Length/2-2];
            result[result.Length/2-i] = -(result[i+result.Length/2-1] + result[i+result.Length/2-2]);
        }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
