// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без использования POW!!!
// 3, 5-> 243(3⁵)
// 2, 4-> 16

double powNum(int a, int b)
{
    double sum = a;
    for (int i = 2; i <= b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Возведение числа А в степень В");
Console.Write("Введите число: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int num_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число А в степени В = {powNum(num_a, num_b)}");
//Console.WriteLine($"Число А в степени В POW = {Math.Pow(num_a, num_b)}");