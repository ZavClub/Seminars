// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*void GetDiapazone(int quadrat)
{
    if (quadrat == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadrat == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadrat == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quadrat == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Неверный ввод");
}

Console.WriteLine("Введите номер четверти: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);*/

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*int GetDep(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return 0;
}

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

GetDep (x, y);
if (GetDep (x, y) == 0) Console.WriteLine("Введены неверные координаты");
else Console.WriteLine ($"Это четверть: {GetDep (x, y)}");*/


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*void Quard (int num)
{
int cur = 1;
    while (cur <= num)
    {
        Console.Write($"{Math.Pow(cur, 2)}, ");
        cur++;
    }
}

Console.Write("Введите Число: ");
int x = Convert.ToInt32(Console.ReadLine());

Quard(x);*/


// Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


/* void Distance(double ax, double ay, double bx, double by)
{
    Console.Write($"Расстояние между точками = {Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2))}");
}

Console.Write("Введите координату ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату by: ");
int by = Convert.ToInt32(Console.ReadLine());

Distance(ax, ay, bx, by); */