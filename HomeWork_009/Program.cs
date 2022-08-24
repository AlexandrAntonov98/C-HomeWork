//Task_1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void AllNaturalNums(int m, int n)
{
    if(m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if(m != n) AllNaturalNums(m, n-1);
    Console.Write(n + " ");
}
Console.Write("Введите первое натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
AllNaturalNums(num1, num2);
*/
//Task_2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumAllNaturalNums(int m, int n, int sum)
{
    if(m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    
        Console.WriteLine($"Сумма натуральных чисел в промежутке от m до n: {sum}");
        return;
    }
    sum = sum + (m++);
    SumAllNaturalNums(m,n,sum);

    }

Console.Write("Введите первое натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumAllNaturalNums(num1, num2, 0);
*/
//Task_3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int FunctionAkkerman(int m, int n)
{
    if( m == 0 ) return n+1;
    else if(m != 0 && n == 0) return FunctionAkkerman(m-1,1);
    else 
    return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));
}

Console.WriteLine("Введите первое значение: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionAkkerman(num1, num2));
Console.WriteLine();
*/




