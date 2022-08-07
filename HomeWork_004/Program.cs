// Task_1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int DegreeOfNumber(int numA, int numB)
{
    int degree = 1;
    int sumDegree = 1;
    int sum = numA;
    while(degree < numB)
    {
        degree++;
    }
    while(sumDegree < degree)
    {
        sum = sum * numA;
        sumDegree++;
    }
    return sum;
}
Console.Write("Введите натуральное число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int degree = DegreeOfNumber(numA, numB);
Console.Write($"Число {numA} в степени {numB}: {degree}");
*/
// Task_2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int SumDigitsNumber(int num)
{
    int composition = 10;
    int chars = 0;
    int digitsNumbers = 0;
    while(num > 0)
    {
        chars = num % composition;
        digitsNumbers = digitsNumbers + chars;
        num = num / composition;
    }
    return digitsNumbers;
}
Console.Write("Введите натуральное число: ");
int bum = Convert.ToInt32(Console.ReadLine());
int digitsNum = SumDigitsNumber(bum);
Console.Write($"Сумма цифр в числе: {digitsNum}");
*/
//Task_3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*void ArrayEightNum()
{
    int[] newArray = new int[8];
    int i = 0;
    int alph = 1;
    while(i < 8)
    {
        Console.Write($"Введите {alph} натуральное число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        i++;
        alph++;
    }
    Console.Write("Массив из 8 элементов: ");
    for(i = 0; i < 8; i++)
    {
        Console.Write(newArray[i] + " ");
    }
}

ArrayEightNum();
*/

