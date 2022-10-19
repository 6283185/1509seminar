// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
//В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

int SumNumInRange(int[] array,int rangeStart,int rangeEnd)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= rangeStart && array[i] <= rangeEnd)
        {
            counter++;
        }
        
    }
    return counter;
}

int[] arrayRandom = CreateArrayRndInt(123, 0, 999);
PrintArray(arrayRandom);
int sumNumbersInRange = SumNumInRange(arrayRandom, 10, 99);
Console.WriteLine($"Количество элементов массива, которые лежат в диапазоне от 10 до 99 = {sumNumbersInRange}");