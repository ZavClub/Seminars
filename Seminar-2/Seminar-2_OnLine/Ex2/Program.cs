// Работа на лекции
// Задача. Удалить среднюю цифру из числа

/* int CutNumber(int num)
{
    int sot = num / 10;
    int ed = num % 10;
    int result = sot * 10 + ed;

    return result;
}  */

// Решение с вводом числа с клавиатуры
/* Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber(number)); */

// Решение с рандомным вводом данных
/* int randNum = new Random().Next(100, 1000);
int newNumber = CutNumber(randNum);
Console.WriteLine($"Число переделано из {randNum} в {newNumber}"); */



//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/* int CutNumber(int num)
{
    int des = num / 10;
    int ed = num % 10;
    if (des > ed) return des;
    return ed;
}
Console.Clear();
int randNum = new Random().Next(10, 100);
int newNumber = CutNumber(randNum);
Console.WriteLine($"Сгенерированное число: {randNum} Наибольшее число: {newNumber}"); */

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

//Console.WriteLine(KratNum(number1, number2));

//Задача 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/* bool Control(int num1, int num2)
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
    Console.WriteLine("Нет, не является"); */
