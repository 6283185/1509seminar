// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int counter = 2;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter = counter + 2;
}