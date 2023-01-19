// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. Каждое число меньше суммы двух других.



bool checkTriangle(int a, int b, int c)
{
    bool result = false;
    if (a + b > c && b + c > a && c + a > b)
        result = true;

    return result;
}


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(checkTriangle(num1, num2, num3));
