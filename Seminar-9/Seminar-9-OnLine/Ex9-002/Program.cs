// Напишите программу, которая на вход принимает два числа A и B и возводит число A в целую степень B (Положительное и отрицательное)

double AtoBdegree(double a, int b)
{
    if(b > 0) return AtoBdegree(a, b - 1) * a;
    else if(b < 0) return AtoBdegree(a, b + 1) * (1 / a);
    else return 1;
}

Console.WriteLine(AtoBdegree(2, 3));