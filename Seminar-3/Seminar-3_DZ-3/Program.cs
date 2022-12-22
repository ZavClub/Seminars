/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void Quard (int num)
{
int cur = 1;
    while (cur <= num)
    {
        Console.Write($"{Math.Pow(cur, 3)}, ");
        cur++;
    }
}

Console.Clear();
Console.Write("Введите Число: ");
int x = Convert.ToInt32(Console.ReadLine());

Quard(x);