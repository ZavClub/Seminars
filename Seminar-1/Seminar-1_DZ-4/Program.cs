// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Вывод чётных чисел, до введённого");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int cur = 2;

if (cur > num) Console.Write("Вы ввели неверное число");

while (cur <= num)
{
    Console.Write($"{cur}");
    cur += 2;
    
    if (cur <= num) Console.Write(", ");   
}    
