// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumsInNum(int num)
{
    int counter = 0;
    int numTemp = num;
    int sum = 0;
    while (numTemp > 0)
    {
        numTemp /= 10;
        counter++;
    }
    for (int i = 1; i <= counter; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;

}

Console.WriteLine($"В числе {number} сумма цифр {SumNumsInNum(Math.Abs(number))}");
