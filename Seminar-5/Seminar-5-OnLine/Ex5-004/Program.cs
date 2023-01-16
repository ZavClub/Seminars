// Написать программу, определяющую, присутствует ли заданное число в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

bool CheckNum(int[] array, int index)
{
    bool temp = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == index)
        {
            temp = true;
        }
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
Console.Write("Введите число для поиска: ");
int index = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);

ShowArray(newArray);

bool result = CheckNum(newArray, index);
if (result == true)
{
Console.WriteLine("Число в массиве есть");
}
else Console.WriteLine("Искомого числа нет");

