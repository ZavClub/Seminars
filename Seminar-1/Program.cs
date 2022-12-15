// Семинар 1

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

/*
Console.Clear();

Console.WriteLine("Проверка чисел. Является ли первое, квадратом второго");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int quad;

quad = a * a;

if (quad == b)
    Console.Write("Да, является");
else 
    Console.Write("Нет, не является");
*/


// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Clear();

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int cur = -num;

while (cur <= num)
{
    Console.Write($"{cur}, ");
    cur++;
}
*/

// Задача 3. 

/*
Console.Clear();

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите делитель: ");
int del = Convert.ToInt32(Console.ReadLine());

Console.Write($"{(num / del) % del}");
*/