//Task_1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] ArrayDescendingOrder(int[,] array)
{
    int[,] newarray = array;
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0; j < newarray.GetLength(1); j++)
        {
            for(int n = 0; n < newarray.GetLength(1) - 1; n++)
            {
                if(newarray[i,n] < newarray[i,n + 1])
                {
                    int temp = newarray[i,n];
                    newarray[i,n] = newarray[i,n + 1];
                    newarray[i,n + 1] = temp;
                }
            }
        }
    }
    return newarray;
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
Show2dArray(ArrayDescendingOrder(nArray));
*/
//Task_2:  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int Sum(int[,] array, int i)
{
    int sum = array[i,0];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    return sum;
}

void MinRows(int[,] array)
{
    int rows1 = Sum(array, 0);
    int min = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int rows2 = Sum(array, i);
        if(rows1 > rows2)
        {
            rows1 = rows2;
            min = i + 1;
        }
    }
    Console.WriteLine(min);
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
MinRows(nArray);
*/
//Task_3: 
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

int[,] Product2Matrices(int[,] array1, int[,] array2)
{
    int[,] newArray = CreateRandom2dArray(m, n, min, max);
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = array1[i,j] * array2[i,j];
        }
    }
    return newArray;
}

int[,] array1 = CreateRandom2dArray(m,n,min,max);
Show2dArray(array1);
Console.WriteLine();

int[,] array2 = CreateRandom2dArray(m,n,min,max);
Show2dArray(array2);
Console.WriteLine();

Show2dArray(Product2Matrices(array1,array2));
*/
//Task_4: Заполните спирально массив 4 на 4.
/*
int n = 4;
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while(temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i,j] = temp;
    temp++;
    if(i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }

}

Show2dArray(spiralMatrix);

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
*/

