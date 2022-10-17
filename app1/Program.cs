// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberFromConsoleTwo(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double GetNumberValue(int minValue, int maxValue)
{
    return Convert.ToDouble(new Random().Next(minValue, maxValue + 1) / 10.0);
}

void FillArray(double[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetNumberValue(minValue, maxValue);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] InitializateArray(int m, int n)
{
    return new double[m, n];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
double[,] array = InitializateArray(m, n);
int maxValue = GetNumberFromConsoleTwo("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsoleTwo("Введите минимальное допустимое число в массиве:");
FillArray(array, minValue, maxValue);
PrintArray(array);