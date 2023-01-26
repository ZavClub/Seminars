﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = 5;//Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = 5; //Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = 10; //Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение: ");
    int maxValue = 99; //Convert.ToInt32(Console.ReadLine());

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

void SortingArray(int[,] array)
{
    int temp = array[0, 0];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
    int count = 1;
        while (count > 0)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    count = 0;
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    count++;
                    Console.WriteLine($"i {i}, j {j}, count {count}");
                }
            }
        }
        Console.WriteLine($"count {count}");
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
SortingArray(newArray);
Show2dArray(newArray);

