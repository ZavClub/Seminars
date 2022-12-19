// Работа на лекции

// Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

bool kratNum(int num1, int num2)
{
    if (num2 % num1 == 0)
        return true;
    return false;
}

Console.Clear();
Console.WriteLine("Проверка, является ли второе число кратным первому");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (kratNum(number1, number2) == true)
    Console.WriteLine("Да, является");
else
    Console.WriteLine("Нет, не является");


