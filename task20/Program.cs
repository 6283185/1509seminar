// Math.Pow(2, 10);
// double num = Math.Sqrt(10);
// // 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки ");
Console.Write("aX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("bX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
int bY = Convert.ToInt32(Console.ReadLine());

double Distance(int ax, int ay, int bx, int by)
{
    double num = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
    double res = Math.Round(num, 2, MidpointRounding.ToZero);
    return res;
}

Console.WriteLine(Distance(aX, aY, bX, bY));