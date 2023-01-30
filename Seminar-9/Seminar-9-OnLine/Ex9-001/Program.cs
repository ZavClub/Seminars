// Задайте значения m и n. Напишите программу, которая выводит все натуральные числа в промежутке от m до n.

void ShowNum(int m, int n)
{
    // if(m > n)
    // {
    //     Console.Write(m + " ");
    //     ShowNum(m - 1, n);
    // }    
    // else if(n > m)
    // {
    //     ShowNum(m, n - 1);
    //     Console.Write(n + " ");
    // }
    // else Console.Write(n + " ");

    Console.Write(m + " ");
    if (m < n) ShowNum(m + 1, n);
    if (m > n) ShowNum(m - 1, n);
}

Console.WriteLine();
ShowNum(10, 15);