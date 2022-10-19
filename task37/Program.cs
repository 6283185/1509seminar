// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов создаваемого массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива: ");
int minNumInArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива: ");
int maxNumInArray = Convert.ToInt32(Console.ReadLine());

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

int[] MultiplyArrayElements(int[] array)
{
    int arrSize = default;    
    if (array.Length % 2 == 0)
    {
        arrSize = array.Length / 2;
        
    }
    else
    {
        arrSize = array.Length / 2 + 1;
    }
    int[] newArray = new int[arrSize];

    for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 -i];
        }
    
    if (array.Length % 2 != 0) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}

int[] arrayRandInt = CreateArrayRndInt(sizeArray, minNumInArray, maxNumInArray);
PrintArray(arrayRandInt);
int[] arrayMulty = MultiplyArrayElements(arrayRandInt);
PrintArray(arrayMulty);