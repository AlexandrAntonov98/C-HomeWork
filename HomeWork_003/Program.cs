//Task_3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void NumberCubes(double num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(current * current * current + " ");
        current++;
    }
}
double check;
double number;
Console.Write("Введите целое положительное число: ");
check = Convert.ToInt32(Console.ReadLine());
if(check < 0) number = check * (-1);
else number = check;
NumberCubes(check);
*/
//Task_2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double Lenth(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenth = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    return lenth;
}
Console.Write("Введите координату Х точки А: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double zb = Convert.ToInt32(Console.ReadLine());

double lenth = Lenth(xa, ya, za, xb, yb, zb);
Console.Write($"Расстояние между точками А и В: {lenth} см");
*/
//Task_1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*void Palindrome(int[] collection)
{
    if(collection[0] == collection[4] && collection[1] == collection[3])
    {
        Console.WriteLine("Ура! Это число является палиндромом.");
    }
    else Console.WriteLine("Нет. Это не палиндром.");
}


int[] array = {6,4,3,4,6};
Palindrome(array);
*/
