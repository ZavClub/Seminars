/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

void Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    Console.Write($"Расстояние между точками = {Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2))}");
}
Console.Clear();

Console.Write("Введите координату ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату by: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

Distance(ax, ay, az, bx, by, bz);