// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


int[] GenerateFibonaci(int length, int first_nimber, int second_number)
{
    int[] array = new int[length];
    array[0] = first_nimber;
    array[1] = second_number;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[] newArray = GenerateFibonaci(length, num1, num2);
ShowArray(newArray);