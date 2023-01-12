// Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Ввод значений пользователем!!!
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение в ячейку {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[ ");
        Console.Write(array[i]);
        if (i >= 0 && i != array.Length - 1) Console.Write(", ");
        else Console.Write(" ]");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray);
ShowArray(array);

