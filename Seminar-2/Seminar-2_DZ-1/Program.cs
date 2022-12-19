// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*  456 -> 5
    782 -> 8
    918 -> 1 */

int CutNumber(int num)
{
    int des = num / 10 % 10;
    return des;
}

Console.Clear();
Console.WriteLine("Вывод второй цифры числа");
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
    Console.WriteLine($"Средняя цифра числа: {CutNumber(num)}");
else
    Console.WriteLine("Вы ввели неправильное число, запустите программу снова");