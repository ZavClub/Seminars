// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. Новый квадратный массив с проверкой

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

int[] MinArrayIndex(int[,] array)
{
    int[] indexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] RemoveMinIndex(int[] indexes, int[,] array)
{
    int[,] resmas = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int i2 = 0;
    int j2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexes[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexes[1])
                {
                    resmas[i2, j2] = array[i, j];
                    j2++;
                }
            }
            j2 = 0;
            i2++;
        }
    }
    return resmas;
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

int[,] array2 = RemoveMinIndex(MinArrayIndex(newArray), newArray);
Show2dArray(array2);
