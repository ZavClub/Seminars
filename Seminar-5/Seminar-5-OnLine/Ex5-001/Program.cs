//Написать программу, которая формирует массив из введённых чисел

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input a {i + 1} element");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);

ShowArray(newArray);