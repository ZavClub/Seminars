// Работа на лекции

//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int CutNumber(int num)
{
    int des = num / 10;
    int ed = num % 10;
    if (des > ed) return des;
    return ed;
}
Console.Clear();
int randNum = new Random().Next(10, 100);
int newNumber = CutNumber(randNum);
Console.WriteLine($"Сгенерированное число: {randNum} Наибольшее число: {newNumber}");
