// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int numLen = number.ToString().Length;
if (numLen < 3)
{
    Console.WriteLine("Число меньше трёх знаков");
}
else if (numLen > 3)
{
    Console.WriteLine("Число больше трёх знаков");
}
else
{
    Console.Write((number % 100) / 10);
}

