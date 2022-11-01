// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите стартовое число: ");
int numberStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int numberEnd = Convert.ToInt32(Console.ReadLine());

int NaturalNumbersSumFromMToN(int num1, int num2)
{
    int sum = num1;
    if (num1 < num2)
    {        
        sum += NaturalNumbersSumFromMToN(num1 +1, num2);
                    
    }    
    if (num1 > num2)
    {        
        sum += NaturalNumbersSumFromMToN(num1 -1, num2);        
    }
    
    if (num1 == num2) return sum;
    return sum;

}

int naturalNumbersSumFromMToN = NaturalNumbersSumFromMToN(numberStart, numberEnd);
Console.Write($"Сумма элементов в промежутке от {numberStart} до {numberEnd} = {naturalNumbersSumFromMToN}");