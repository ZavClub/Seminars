// Работа на лекции

//Задача 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Control(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
        return true;
    else
        return false;
}

Console.Clear();
Console.WriteLine("Проверка, является ли одно число квадратом другого");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (Control(number1, number2) == true)
    Console.WriteLine("Да, является");
else
    Console.WriteLine("Нет, не является");
