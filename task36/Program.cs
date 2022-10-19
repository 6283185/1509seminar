// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int first, int last)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(first, last + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else Console.Write($"{array[i]}");

    }
    Console.WriteLine("]");
}

int SumOddPositionedNumsInArray(int[] array)
{
    int sumOddPositionNums = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumOddPositionNums += array[i];
    }
    return sumOddPositionNums;
}

int[] arrayResult = CreateArrayRndInt(10, 0, 99);
PrintArray(arrayResult); 
int sum = SumOddPositionedNumsInArray(arrayResult);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях массива = {sum}");