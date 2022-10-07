// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9999 && number < 100000)
// {
//     if ((number / 10000 == number % 10) && (number % 10000 / 1000  == number % 100 / 10))
//     System.Console.WriteLine("Да, число является палиндромом.");
//     else
//     {
//         System.Console.WriteLine("Число не является палиндромом.");
//     }
// }
// else
// {
//     System.Console.WriteLine("Число не является пятизначным.");
// }

bool IsPalindrom(int num)
{
    if ((number / 10000 == number % 10) && (number % 10000 / 1000 == number % 100 / 10))
        return true;
    else
    {
        return false;
    }
}
if (number > 9999 && number < 100000)
{
    if (IsPalindrom(number) == true)
    {
        System.Console.WriteLine("Да, число является палиндромом.");
    }
    else
    {
        System.Console.WriteLine("Нет, число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Число не является пятизначным.");
}