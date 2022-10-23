// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int side1,int side2,int side3)
{
    bool res = false;
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
    {
        res = true;
    }
    return res;
}
bool isTriangle = IsTriangle(firstNum, secondNum, thirdNum);
if (isTriangle) Console.Write($"Да, треугольник со сторонами {firstNum}, {secondNum}, {thirdNum} может существовать. ");
else Console.Write($"Нет, треугольник со сторонами {firstNum}, {secondNum}, {thirdNum} не может существовать. ");