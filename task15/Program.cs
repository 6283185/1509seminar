// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber > 0 && dayNumber < 8)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
    Console.Write("Да, этот день выходной!");
    }
    else
    {
        Console.Write("Нет, этот день рабочий.");
    }
}
else
{
    Console.Write("Нет такого дня недели!");
}