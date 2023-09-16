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


// int[] Fibonacci(int n)
// {
//     int[] result = new int[n*2-1];
//     result[result.Length/2] = 0;
//     result[result.Length/2+1] = 1;
//     result[result.Length/2-1] = 1;

//         for (int i = 2; i < n; i++)
//         {
//             result[result.Length/2+i] = result[i+result.Length/2-1] + result[i+result.Length/2-2];
//             result[result.Length/2-i] = -(result[i+result.Length/2-1] + result[i+result.Length/2-2]);
//         }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Введите число N");
// int num = Convert.ToInt32(Console.ReadLine() );
// PrintArray(Fibonacci(num));


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = i+j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i,j],3}    ");
//         System.Console.WriteLine();
//         }
// }


// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);


// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// void Exponent(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < array.GetLength(1); j += 2)
//             array[i, j] *= array[i, j];

//     }
// }


// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// Exponent(array);
// PrintArray(array);

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// int SumOfStraightDiagonal(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result += array[i, i];
//     }
//     return result;
// }

// int SumOfReverseDiagonal(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result += array[array.GetLength(0) - 1 - i , i];
//     }

//     return result;
// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(SumOfStraightDiagonal(array));
// System.Console.WriteLine(SumOfReverseDiagonal(array));

// **Задача HARD SORT.**

// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 100);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3} ");
//         System.Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//     int[] tempArray = new int[array.GetLength(0) * array.GetLength(1)];
//     int index = 0;

//     foreach (int number in array)
//     {
//         tempArray[index] = number;
//         index++;
//     }


//     int temp;
//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         for (int j = 0; j < tempArray.Length - 1 - i; j++)
//         {
//             if (tempArray[j] > tempArray[j + 1])
//             {
//                 temp = tempArray[j];
//                 tempArray[j] = tempArray[j + 1];
//                 tempArray[j + 1] = temp;
//             }
//         }
//     }

//     index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = tempArray[index];
//             index ++;
//         }
//     }

// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// SortArray(array);
// System.Console.WriteLine();
// PrintArray(array);


// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(10, 100);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// void ReverseRows(int[,] array)
// {
//     int [] buffRow = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         buffRow[i] = array[0, i];
//         array[0, i] = array[array.GetLength(0)-1, i];
//         array[array.GetLength(0)-1, i] = buffRow[i];
//     }
// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int[rows, cols];

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ReverseRows(array);
// PrintArray(array);



// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(10, 100);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// void ReverseRowsAndCols(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
//         }
//     }

// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int[rows, cols];

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ReverseRowsAndCols(array);
// PrintArray(array);


// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// в массиве случайные числа от 0 до 9
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}    ");
//         System.Console.WriteLine();
//     }
// }

// void CountDigits(int[,] array)
// {
//     int number = 0;
//     int result = 0;
//     while (number < 10)
//     {
//         foreach (int item in array)
//         {
//             if (item == number) result++;
//         }
//         if (result > 0)
//         {
//             System.Console.WriteLine($"Цифра {number} встречается {result} раз.");
//         }
//             result = 0;
//             number++;
//     }
// }


// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int[rows, cols];

// FillArray(array);
// PrintArray(array);
// CountDigits(array);


// Посчитать сумму всех чисел от 1 до N, где N вводит пользователь.

// int SummaCycle(int n)
// {
//     int sum = 0;
//     while (true)
//         {
//             // if (n == 0)
//             //     break;
//             sum = sum + n;
//             n = n - 1;
//         }
//     return sum;
// }

// int SummaRec(int n)
// {
//     if (n  == 0)
//         return 0;
//     return n + SummaRec(n - 1);
// }

// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SummaCycle(n));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



// string PrintNumbers(int n)
// {
//     if (n == 0)
//         return "";
//     return PrintNumbers(n - 1) + $"{n} ";

// }

// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(PrintNumbers(n));


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// string PrintNumbers(int m, int n)
// {
//     if (n < m)
//         return "";
//     return PrintNumbers(m, n - 1) + $"{n} ";
// }

// System.Console.WriteLine("Введите нижнюю границу M");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите верхнюю границу N");
// int max = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(PrintNumbers(min, max));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumDigits(int n)
// {
//     if (n == 0)
//         return 0;
//     return n % 10 + SumDigits(n / 10);
// }

// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма цифр числа равна: {SumDigits(n)}");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Sqare(int a, int b)
// {
//     if (b == 1)
//         return a;
//     return a * Sqare(a, b-1);
// }

// System.Console.WriteLine("Введите натуральное число ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите степень ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Sqare(a, b));


// int Fibonaci(int n)
// {
//     if (n == 1 || n == 2)
//         return n - 1;
//     return Fibonaci(n - 1) + Fibonaci(n - 2);
// }

// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Fibonaci(n));

