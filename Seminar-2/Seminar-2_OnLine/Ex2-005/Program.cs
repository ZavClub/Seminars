// Работа на лекции
// Задача. Удалить среднюю цифру из числа

int CutNumber(int num)
{
    int sot = num / 10;
    int ed = num % 10;
    int result = sot * 10 + ed;

    return result;
}  

// Решение с вводом числа с клавиатуры
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber(number)); 

// Решение с рандомным вводом данных
/* int randNum = new Random().Next(100, 1000);
int newNumber = CutNumber(randNum);
Console.WriteLine($"Число переделано из {randNum} в {newNumber}"); */
