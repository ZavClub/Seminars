// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7    -2  - 0,2
//  1   -3,3    8  - 9,9
//  8    7,8  -7,1    9


double[,] CreateRandomDouble2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    double minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    double maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void ShowDouble2dArray(double[,] array)
{   double tmp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp = array[i, j];
            Console.Write(Math.Round(tmp, 2) + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandomDouble2dArray();
ShowDouble2dArray(newArray);