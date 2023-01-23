// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7->элемента с такими индексами в массиве нет

int[,] CreateRandom2dArray()
{
    int rows = 5;
    int columns = 5;
    int minValue = 0;
    int maxValue = 9;

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

void SearchPosition(int[,] array, int rows, int columns)
{
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine($"Элемента с позицией {rows} , {columns} нет");
    }
    else Console.WriteLine($"Элемент с позицией {rows} , {columns} имеет значение: " + array[rows - 1, columns - 1]);
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

Console.Write("Введите индекс в строке: ");
int searchRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс в столбце: ");
int searchColumns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SearchPosition(newArray, searchRows, searchColumns);