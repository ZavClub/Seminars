// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumNumOfNegativesPos(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        //if (array[i] < 0) 
        sum = sum + array[i];
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

int result = SumNumOfNegativesPos(newArray);
Console.WriteLine("Сумма чисел стоящих на нечётных позициях равна: " + result);