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

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


//Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
       result = result * a; 
    }
    Console.WriteLine(result);
}
//Функция ввода
 int ReadInt(string message)
 {
    Console.WriteLine(message);
    return
    Convert.ToInt32(Console.ReadLine()!);
 }*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

//Функция ввода
 int ReadInt(string message)
 {
    Console.WriteLine(message);
    return
    Convert.ToInt32(Console.ReadLine()!);
 }

 //Функция подсчета цифр в числе
 int NumberLen(int a)
 {
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
 }

 //Функция вывода суммы цифр в числе
 void SumNumbers(int n, int len)
 {
    int sum = 0;
    for (int i = 1; i<= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    */

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
/*int lenArray = ReadInt("Введите длину массива:");
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

//Функция ввода
 int ReadInt(string message)
 {
    Console.WriteLine(message);
    return
    Convert.ToInt32(Console.ReadLine()!);
 }*/

 //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 /*int[] startArray = GetArray(6, 100, 999);
 Console.WriteLine(String.Join(" ", startArray));
 Console.WriteLine($"Количество четных элементов в массиве = {PositivCount(startArray)}");
 
 int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int PositivCount(int[] array)
{
int count = 0;
    foreach (int el in startArray)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
/*int[] startArray = GetArray(6, 0, 999);
 Console.WriteLine(String.Join(" ", startArray));
 Console.WriteLine($"Сумма элементов с нечетными индексами = {GetSum(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSum (int[] array)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*int[] startArray = GetArray(5, 0, 5);
 Console.WriteLine(String.Join(" ", startArray));
 
 Console.WriteLine(String.Join(" ", ResultArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ResultArray (int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
/*Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов > 0: {count}");*/

//Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
/*int[] array = GetArray(6, 0, 100);
Console.WriteLine(String.Join(", ", array));
Array.Sort(array);
Console.WriteLine(String.Join(", ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

// -------------Метод----------------------------
double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().NextDouble()*(max - min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++){
            Console.Write($"{inArray[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}*/

//Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.Write("Введите значение элемента:");
int element = int.Parse(Console.ReadLine()!);
if (FindElement(array, element))
{
    Console.WriteLine("Элемент найден");
}
else
{
    Console.WriteLine("Элемент не найден");
}

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == el) return true;
        }
        return false;
    }
}*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColums = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join(", ",averageColums)}");

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetResultArray(int[,] array)
{
      double[] result = new double[array.GetLength(1)];
      for (int i = 0; i < array.GetLength(1); i++)
      {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum +=array[i,j];
        }
        result[i] = Math.Round(sum/array.GetLength(0), 2);
      }
      return result;
}*/

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        { 
            for(int t = j + 1; t < array.GetLength(1); t++)
            {
                if(array[i, t] > array[j, t])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for(int i = 0, i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }
    for(int i = 0, i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0, j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine()!);
if(columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя");
    return;
}
int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(MultiplicationMatrix(A,B));

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
        for(int j = 0; j < arrayB.GetLength(1); j++)
        {
            for(int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i,j] += arrayA[i,k] * arrayB[k,j];           
            }
        }
    }
    return arrayC;
}*/

//Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));


// ------Метод------------------------
string PrintNumbers(int end, int start)
{
    if (end == start) return end.ToString();
    return (end + " " + PrintNumbers(end - 1, start));
}*/

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);


//----------метод---------
 void GapNumberSum(int M, int N, int sum)
 {
    if(M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
 }
 GapNumberSum(M,  N, 0);*/

 //Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 /*int m = InputNumber("Введите число m: ");
 int n = InputNumber("Введите число n: ");
 int functionAkkerman = Ack(m, n);
 Console.Write($"Функция Аккермана = {functionAkkerman} ");

//----------метод---------
int Ack(int m, int n)
{
    if(m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine()!);
    return output;
}*/











