//Task_1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Задайте {i + 1} элемент из {size}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GreaterThanZero(int[] array)
{
    int count = 0;
    int zero = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > zero)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size);

ShowArray(newArray);

Console.Write("Количество чисел больше нуля: " + GreaterThanZero(newArray));
*/
//Task_2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Введите значение точки k1 в уравнении y = k1 * x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки b1 в уравнении y = k1 * x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки k2 в уравнении y = k2 * x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение точки b2 в уравнении y = k2 * x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x=(b2-b1)/(k1-k2);
double y=k1 * x + b1;

Console.Write($"Точка пересечения двух прямых: {x} {y}");
*/