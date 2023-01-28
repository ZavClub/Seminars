// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int num = 1;

int[,] CreateArray()
{
    Console.Clear();
    Console.WriteLine("Заполняем массив 4*4 по улитке");
    Console.WriteLine();

    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];

    return array;
}

void FillArray(int[,] array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int tmp = xSize * ySize;
    int x = 0;
    int y = 0;
    
    while (num <= tmp)
    {
        for (; y < array.GetLength(1) - 1 && num <= tmp + 1;)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = num; y++; num++;
            }
            else
            {
                x++; y++;
            }
        }
        for (; x < array.GetLength(0) - 1 && num <= tmp + 1;)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = num; x++; num++;
            }
            else
            {
                x++; y--;
            }
        }
        for (; y > 0 && num <= tmp + 1;)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = num; y--; num++;
            }
            else
            {
                x--; y--;
            }
        }
        for (;  x > 0 && num <= tmp + 1;)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = num; x--; num++;
            }
            else
            {
                x--; y++;
            }
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

int[,] newArray = CreateArray();
FillArray(newArray);
Show2dArray(newArray);