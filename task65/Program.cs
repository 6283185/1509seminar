// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите стартовое число: ");
int numberStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int numberEnd = Convert.ToInt32(Console.ReadLine());

void NaturalNumbersUntilN(int num1, int num2)
{
    if (num1 < num2)
    {        
        Console.Write($"{num1} ");    
        NaturalNumbersUntilN(num1 +1, num2);            
    }
    if (num1 > num2)
    {        
        Console.Write($"{num1} ");
        NaturalNumbersUntilN(num1 -1, num2);        
    }
    if (num1 == num2) Console.Write($"{num1} ");

}

NaturalNumbersUntilN(numberStart, numberEnd);