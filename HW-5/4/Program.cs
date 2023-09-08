// задача 40 - HARD необязательная. На вход программы подаются три целых положительных 
// числа. Определить , является ли это сторонами треугольника. Если да, то вывести всю 
// информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

bool TriangleIsPossible(int a, int b, int c)
{
    bool result = false;
    if (a < (b + c) && b < (a + c) && c < (a + b))
        result = true;
    return result;
}

void Perimeter(int a, int b, int c)
{
    int perimeter = a + b + c;
    System.Console.WriteLine($"Периметр равен {perimeter}.");
}

void Sqare(int a, int b, int c)
{
    int p = (a + b + c) / 2;
    double sqare = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    System.Console.WriteLine($"Площадь равна {sqare}.");
}

void Angles(int sideA, int sideB, int sideC)
{
    double a = Convert.ToDouble(sideA);
    double b = Convert.ToDouble(sideB);
    double c = Convert.ToDouble(sideC);

    double cosA = ((a * a) + (c * c) - (b * b)) / (2 * (a * c)); // Вычисляем косинус
    double angleA = Math.Acos(cosA) * 180 / Math.PI; // Вычисляем угол через арккосинус и переводим из радиан в градусы
    double cosB = (a * a + b * b - c * c) / (2 * a * b);
    double angleB = Math.Acos(cosB) * 180 / Math.PI;
    double cosC = (b * b + c * c - a * a) / (2 * c * b);
    double angleC = Math.Acos(cosC) * 180 / Math.PI;

    System.Console.WriteLine($"Угол A равен {angleA}");
    System.Console.WriteLine($"Угол B равен {angleB}");
    System.Console.WriteLine($"Угол C равен {angleC}");

    if (angleA == 90 || angleB == 90 || angleC == 90)
        System.Console.WriteLine("Треугольник является прямоугольным");
    else System.Console.WriteLine("Треугольник не является прямоугольным");
}

void Isosceles(int a, int b, int c)
{
    if (a == b || b == c || a == c)
        System.Console.WriteLine("Треугольник равнобедренный");
    else System.Console.WriteLine("Треугольник не равнобедренный");
}

void Equilateral(int a, int b, int c)
{
    if (a == b && b == c)
        System.Console.WriteLine("Треугольник равносторонний");
    else System.Console.WriteLine("Треугольник не равносторонний");
}

System.Console.WriteLine("Введите сторону треугольника a");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону треугольника b");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону треугольника c");
int c = Convert.ToInt32(Console.ReadLine());

if (TriangleIsPossible(a, b, c))
{
    Perimeter(a, b, c);
    Sqare(a, b, c);
    Angles(a, b, c);
    Isosceles(a, b, c);
    Equilateral(a, b, c);
}
else System.Console.WriteLine("Треугольник с такими сторонами невозможен.");