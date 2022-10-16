// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum *i;
    }
    return sum;
}
if (number > 0)
{
    Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
}
else
{
    System.Console.WriteLine("Введено некорректное число.");
}