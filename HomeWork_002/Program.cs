// Task_1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int ShowSecondNumber(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
int num = ShowSecondNumber(958);
Console.WriteLine($"Вторая цифра из трехзначного числа: {num}");
*/
// Task_2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ShowThirdNumber(int num)
{
    int mult = 999;
    int minusZero = 10; 
    while(num >= mult)
    {
        num = num / minusZero;

    }
    int num1 = num % 10;
    if(num / 100 == 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else Console.WriteLine(num1); 
}

    ShowThirdNumber(13);
*/
// Task_3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*void IsWeekEnd(int num)
int IsWeekEnd(int num)
{
    Console.Write($"Введите цифру, обозначающую день недели (1, 2, 3, 4, 5, 6, 7): {num} ");
    Console.ReadLine();
    // решил добавить интерактива в консоль, по сути ничего не решает, просто тестил свои навыки.
    if (num >= 6)
    {
        Console.Write("Выходной день");
    }
    else Console.Write("Будний день");
    return num;
}

IsWeekEnd(3);
*/
