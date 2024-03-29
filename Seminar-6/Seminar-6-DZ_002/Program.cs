﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

double x = 0;
double y = 0;

double intersectionPoint(double b1, double k1, double b2, double k2)
{
    x = -(b1 - b2) / (k1 - k2);
    y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    return 0;
}

Console.Clear();
Console.Write("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

intersectionPoint(b1, k1, b2, k2);

Console.WriteLine($"Пересечение в точке: ({x};{y})");