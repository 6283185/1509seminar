// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNum = number / 100;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (number > 999)
    {
        Console.WriteLine($"Третья цифра числа {number}: {(number / 100) % 10}");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {number}: {thirdNum}");
    }
}