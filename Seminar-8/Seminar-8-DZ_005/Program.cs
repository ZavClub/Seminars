// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateRandom2dArray()
{
    Console.Clear();
    int rows = 4;
    int columns = 4;
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    int runX = 0;
    int runY = 0;

    for (int count = 1; count <= 16; count++)
    {
        if(runX < array.GetLength(0) || runY >= 0 || runY < array.GetLength(1) || runY >= 0)
        
        || (array[runX, runY] == 0))
        {
            array[runX, runY] = count;
            runX++;
        }
    
    }
    return array;
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

Console.Write("Заполняем массив по улитке. Нажмите любую клавишу");
Console.ReadLine();
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);