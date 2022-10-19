// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и 
// минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
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

double DifferenceBetweenMinAndMaxValue(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    double result = default;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
    }
    result = maxValue - minValue;
    return result;
}

double[] arrayRandInt = CreateArrayRndInt(10, 0, 99);
PrintArray(arrayRandInt);
double difference =Math.Round(DifferenceBetweenMinAndMaxValue(arrayRandInt), 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {difference}");