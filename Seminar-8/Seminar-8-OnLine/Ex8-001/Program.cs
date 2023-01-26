// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 < array.GetLength(0) && 
        r2 >= 0 && r2 < array.GetLength(0) &&
        r1 != r2)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.WriteLine("Введите первую строку для замены");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую строку для замены");
int row2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, row1, row2);
Show2dArray(newArray);
