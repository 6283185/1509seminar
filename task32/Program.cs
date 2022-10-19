// Задача 32: Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ReflectNumSimbol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    
}

int[] arrayResult = CreateArrayRndInt(sizeArray, minNumInArray, maxNumInArray);
PrintArray(arrayResult);
ReflectNumSimbol(arrayResult);
PrintArray(arrayResult);