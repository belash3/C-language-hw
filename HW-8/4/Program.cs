// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int newValue = rnd.Next(10, 20);
                while (IsRepeat(array, newValue)) newValue = rnd.Next(10, 20);
                array[i, j, k] = newValue;
            }
        }
    }
}

bool IsRepeat(int[,,] array, int newValue)
{
    bool isRepeat = false;
    foreach (int item in array)
    {
        if (newValue == item) isRepeat = true;
    }
    return isRepeat;
}


void PrintArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}

int[,,] cube = new int[2, 2, 2];
FillArray(cube);
PrintArray(cube);