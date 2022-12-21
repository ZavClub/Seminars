// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/* Первое решение

Console.Clear();

Console.WriteLine("Сравнение чисел. Какое из трёх чисел больше.");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) max = num2;
if (max < num3) max = num3;

Console.WriteLine($"Максимальное число {max}");
*/
// Второе решение

Console.Clear();
Console.WriteLine("Сравнение чисел. Какое из трёх чисел больше.");
Console.WriteLine("Введите 3 числа через пробел или запятую.");

string? text = Console.ReadLine();
string[] words = text.Split(' ', ',');

int num1 = Convert.ToInt32(words[0]);
int num2 = Convert.ToInt32(words[1]);
int num3 = Convert.ToInt32(words[2]);

int max = num1;

if (max < num2)
    max = num2;
if (max < num3)
    max = num3;

Console.WriteLine($"Максимальное число {max}");
