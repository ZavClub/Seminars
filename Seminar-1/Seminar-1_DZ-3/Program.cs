// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Проверка, является ли число чётным");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число не чётное");
