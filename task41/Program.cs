// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);



int CountOfPositiveNums(int[] arr)
{
    int counter = default;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (arr[i] > 0) counter++;
    }
    return counter;
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

PrintArray(numbers);
int сountOfPositiveNums = CountOfPositiveNums(numbers);
Console.WriteLine($"Количество введённых чисел больше 0 = {сountOfPositiveNums}");
