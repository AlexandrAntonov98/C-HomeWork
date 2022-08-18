//Task_1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] nArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(nArray);
*/

//Task_2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PositionNumberArray(int[,] array)
{
    
    Console.Write("Введите строку позиции элемента: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец позиции элемента: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if(i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.Write("Элемент: " + array[i,j]);
    }
    else Console.Write("Такого элемента нет.");
}

Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] nArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(nArray);
PositionNumberArray(nArray);
*/

//Task_3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] nArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(nArray);
Console.WriteLine();
for(int j = 0; j < nArray.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i < nArray.GetLength(0); i++)
    {
        sum = sum + nArray[i,j];
    }
    Console.Write($"{sum / nArray.GetLength(0)}; ");
}
Console.ReadLine();
*/