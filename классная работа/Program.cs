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