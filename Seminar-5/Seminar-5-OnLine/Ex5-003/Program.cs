// Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int ChangeNum(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return temp;
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

int result = ChangeNum(newArray);
ShowArray(newArray);
