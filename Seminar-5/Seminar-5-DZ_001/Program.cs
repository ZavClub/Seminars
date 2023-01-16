// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue = 100, int maxValue = 999)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int CheckPositiveNum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum += 1;
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

int[] newArray = CreateRandomArray(length);

ShowArray(newArray);

int result = CheckPositiveNum(newArray);
Console.WriteLine("Сумма положительных чисел равна " + result);