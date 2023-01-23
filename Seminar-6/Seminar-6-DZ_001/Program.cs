// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3   Без массива

int sumNum()
{
    int sum = 0;
    string? temp = " ";
    //int tmp = 0;
    string? keyWord = "";
    while(temp != keyWord)
    {
        temp = Console.ReadLine();
        if (temp != keyWord)
        {
            //tmp = int.Parse(temp);
            bool result = int.TryParse(temp, out var tmp2);
            if (tmp2 > 0) sum++;
        }
    }
    return sum;
}

//Console.Clear();
Console.WriteLine("Считаем количество введённых чисел, больше нуля. По окончании нажмите Enter 2 раза");
int sum = sumNum();
Console.WriteLine($"Вы ввели {sum} чисел больше нуля");