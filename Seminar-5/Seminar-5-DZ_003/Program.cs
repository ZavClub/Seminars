// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.  Random. NextDouble()
//[3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, double minValue, double maxValue)
{

    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

double DiffNum(double[] array)
{
    double min = array[0], max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return Math.Round((max - min), 2);
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round (array[i], 2) + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
double max = Convert.ToInt32(Console.ReadLine());


double[] newArray = CreateRandomArray(length, min, max);

ShowArray(newArray);

double result = DiffNum(newArray);
Console.WriteLine("Разница между максимальныи и минимальным числом равна: " + Math.Round(result, 2));
Console.Read();