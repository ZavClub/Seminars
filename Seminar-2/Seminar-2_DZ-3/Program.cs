// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*  6 -> да
    7 -> да
    1 -> нет */

bool dayWeak(int day)
{
    if (day == 6 || day == 7)
        return true;
    else
        return false;
}

Console.Clear();
Console.WriteLine("Программа проверяет, является ли день недели выходным");
Console.Write("Введите число, обозначающий день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
    Console.WriteLine("Вы ввели не верный день");
else
    if (dayWeak(number) == true)
        Console.WriteLine("Да, это выходной");
    else
        Console.WriteLine("Нет, это рабочий день");
