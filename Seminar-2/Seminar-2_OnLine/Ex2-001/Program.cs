int Max(int arg1, int arg2, int arg3)
{
    int a = arg1;
    if (arg2 > a) a = arg2;
    if (arg3 > a) a = arg3;
    return a;
}

int a1 = 10;
int b1 = 1547;
int c1 = 30;
int a2 = 45;
int b2 = 605;
int c2 = 3643;
int a3 = 191;
int b3 = 42;
int c3 = 88;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);


//int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;


Console.WriteLine(max);