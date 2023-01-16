// Задать массив из n элементов, определить кол-во элементов, принадлежащих отрезку [a,b].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int CheckNum(int[] array, int min, int max)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= max && array[i] >= min) sum++;
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
Console.Write("Введите минимальное значение поиска: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение поиска: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);

ShowArray(newArray);

int result = CheckNum(newArray, minNum, maxNum);
Console.WriteLine($"Сумма чисел принадлежащих отрезку ({minNum}  {maxNum}) равна: " + result);

// Random. NextDouble() Для задачи 3
