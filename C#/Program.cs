/*
/*Console.WriteLine("Задача 1: напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите трехзначное число: ");
int number = new Random().Next(100,1000);
int secondNumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {number} -> {secondNumber}");*/

/*Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if(num < 100)
{
    Console.WriteLine($"Третьей цифры нет!");
}
if(num >= 100 && num <= 999){
    int thirdNum = num % 10;
    Console.WriteLine($"Третья цифра в числе {num} -> {thirdNum}");
}
if(num >= 1000 && num <= 9999){
    int thirdNum = (num % 100) / 10;
    Console.WriteLine($"Третья цифра в числе {num} -> {thirdNum}");
}
if(num >= 10000 && num <= 99999){
    int thirdNum = (num % 1000) / 100;
    Console.WriteLine($"Третья цифра в числе {num} -> {thirdNum}");
}
if(num > 100000){
    Console.WriteLine($"Неверное число");
}*/

/*Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if((num > 7) || (num < 1))
{
    Console.WriteLine("Невыходной");
    return;
}
if((num > 5))
{
    Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет"); 
}*/

/*Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.Write("Введите координату x точки 1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки 1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x точки 2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки 2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки 3: ");
int za = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки 3: ");
int zb = int.Parse(Console.ReadLine()!);
double R = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {R:f2}");*/

/*Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}*/

/*Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}*/
