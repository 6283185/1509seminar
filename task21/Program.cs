// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки ");
Console.Write("aX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("bX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double num = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz));
    double res = Math.Round(num, 2, MidpointRounding.ToZero);
    return res;
}

Console.WriteLine(Distance(aX, aY, aZ, bX, bY, bZ));