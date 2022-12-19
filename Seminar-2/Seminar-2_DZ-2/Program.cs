//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*  645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */

int CutNumber(int num)
{
    int tmp;
    while (num > 99)
    {
        tmp = num / 100;
        if (tmp > 0 && tmp < 10)
        {
            num = num % 10;
            return num;
        }
        else
        {
            num = num / 10;
        }
    }
    return 0;
}

Console.Clear();
Console.WriteLine("Программа выводит третью цифру числа");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
    Console.WriteLine($"Число: {CutNumber(number)}");
else 
    Console.WriteLine("В числе нет третьей цифры");
