// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int[] readArray(int num)
{
    int[] array = new int[num.ToString().Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num % 10;
        num /= 10;
    }

    Array.Reverse(array);
    return array;
}

void sumArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    Console.WriteLine(sum);
}

Console.Clear();
Console.WriteLine("Программа выдаёт сумму чисел в ведённом числе");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = readArray(number);
sumArray(newArray);