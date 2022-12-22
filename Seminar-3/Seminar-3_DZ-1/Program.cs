/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void CheckNum(int num)
{
    if ((num % 10 == num / 10000) && (num / 10 % 10 == num / 1000 % 10))
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число НЕ является палиндромом");
}

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckNum(num);
