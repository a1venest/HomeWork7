int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetNumberValue(minValue, maxValue);
        }
    }
}

void PositionOnArray(int[,] arr)
{
    int mPosition = GetNumberFromConsole("Введите размер m позиции в массиве.");
    int nPosition = GetNumberFromConsole("Введите размер n позиции в массиве.");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == mPosition - 1 && j == nPosition - 1) Console.WriteLine($"На позиции {mPosition} {nPosition} находится {arr[i, j]}.");
        }
    }
    if (arr.GetLength(0) < mPosition || arr.GetLength(1) < nPosition) Console.WriteLine($"Такой позиции {mPosition} {nPosition} в массиве нет. ");
}

void NumberOnArray(int[,] arr)
{
    int numberOnArray = GetNumberFromConsole("Введите число, которое необходимо найти в массиве.");
    bool found = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == numberOnArray)
            {
                found = true;
                Console.WriteLine($"Данное число {numberOnArray} находится на позиции {i},{j}.");
            }
        }
    }
    if (found == false)
        Console.WriteLine($"Числа {numberOnArray} в данном массиве нет.");
}

void PrintArray(int[,] arr)
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

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
int[,] array = InitializateArray(m, n);
int maxValue = GetNumberFromConsole("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsole("Введите минимальное допустимое число в массиве:");
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
NumberOnArray(array);
Console.WriteLine();
PositionOnArray(array);

