// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

int[][] CreateCoordArray(int size) // Создаем массив массивов координат для каждой точки
{
    int[][] array = new int[2][];
    array[0] = new int[size];
    array[1] = new int[size];

    for (int a = 0; a < 2; a++)
    {
        for (int i = 0; i < size; i++)
        {
            System.Console.WriteLine($"Введите {i + 1}-ю координату точки {a + 1}: ");
            array[a][i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

double Distance(int[][] array)
{
    double temp = 0;
    for (int i = 0; i < array[0].Length; i++)
    {
        temp += Math.Pow(array[1][i] - array[0][i], 2);
    }
    return Math.Sqrt(temp);
}

System.Console.WriteLine($"Введите размерность пространства для поиска расстояния между 2 точками");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Расстояние между 2 точками в {n}-мерном пространстве равно: {Distance(CreateCoordArray(n))}.");