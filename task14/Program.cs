// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//без функции
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)  Console.Write("Да");
// else Console.Write("Нет");

//с функцией
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool IsAliqout7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
if (IsAliqout7and23(number))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}