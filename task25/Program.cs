// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
long numberA = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
long numberB = Convert.ToInt64(Console.ReadLine());

long Exponentiation(long numA,long numB)
{
    long res = numA;
    int counter = 1;
    while(counter < numB)
    {
        res = res * numA;
        counter++;
        
    }
    return res;
}
if (numberB > 0)
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = {Exponentiation(numberA, numberB)}");
}
else
{
    Console.WriteLine("Число B не соответствует заданным параметрам.");
}
