//Task_1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int EvenNumbersArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write($"Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное трехзначное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное трехзначное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] nArray = CreateRandomArray(size, min, max);
ShowArray(nArray);
Console.WriteLine("Количество чётных чисел в массиве: " + EvenNumbersArray(nArray));
*/
//Task_2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int SumSecondsElements(int[] array)
{
    int count = 1;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(count % 2 == 0)
        {
            sum = sum + array[i];
        }
        count++;
    }
    return sum;
}

Console.Write($"Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] nArray = CreateRandomArray(size, min, max);
ShowArray(nArray);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SumSecondsElements(nArray));
*/
//Task_3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int DifferenceMaxMin(int[] array)
{
    int i = 0;
    int j = 0;
    int max = 0;
    int min = array[0];
    int diff = 0;
    
    while(i < array.Length)
    {
        if(array[i] > max) max = array[i];
        i++;
    }
    while(j < array.Length)
    {
        if(array[j] < min) min = array[j];
        j++;
    }
    diff = max - min;
    return diff;
}

Console.Write($"Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] nArray = CreateRandomArray(size, min, max);
ShowArray(nArray);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + DifferenceMaxMin(nArray));
*/













































