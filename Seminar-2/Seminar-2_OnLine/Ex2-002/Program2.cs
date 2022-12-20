int Max(int arg1, int arg2, int arg3)
{
    int a = arg1;
    if (arg2 > a)
        a = arg2;
    if (arg3 > a)
        a = arg3;
    return a;
}

int[] arr = { 13, 35, 546, 7568, 8, 6, 53, 86, 888 };

int max = Max(
    Max(arr[0], arr[1], arr[2]),
    Max(arr[3], arr[4], arr[5]),
    Max(arr[6], arr[7], arr[8])
);

Console.WriteLine(max);
