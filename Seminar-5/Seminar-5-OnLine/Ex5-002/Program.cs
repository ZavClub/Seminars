//Написать программу, которая определяет сумму отрицательных элементов в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Input a {i + 1} element");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
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
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(length, min, max);

ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Сумма отрицательных чисел равна " + result);