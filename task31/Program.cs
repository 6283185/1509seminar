// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

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

int[] SumPositiveAndNegativeNums(int[] array)
{
    int sumPositive = default;
    int sumNegative =default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[] {sumPositive, sumNegative};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
int[] sumPositiveAndNegativeNums = SumPositiveAndNegativeNums(arr);
PrintArray(arr);
//PrintArray(sumPositiveAndNegativeNums);
Console.WriteLine($"Сумма положительных элементов массива = {sumPositiveAndNegativeNums[0]}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumPositiveAndNegativeNums[1]}");
