// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите количество элементов создаваемого массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива: ");
int minNumInArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива: ");
int maxNumInArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число для проверки наличия в массиве: ");
int numIsInArray = Convert.ToInt32(Console.ReadLine());


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

bool IsInArray(int[] array,int isInArray)
{
    bool checkResult = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == isInArray)
        {
            checkResult = true;
            break;
        }
        
    }
    return checkResult;
    
}

int[] arrayResult = CreateArrayRndInt(sizeArray, minNumInArray, maxNumInArray);
PrintArray(arrayResult); 
bool checkNumIsInArray = IsInArray(arrayResult, numIsInArray);


if (checkNumIsInArray) Console.WriteLine($"Да, число {numIsInArray} находится в массиве.");
else Console.WriteLine($"Нет, числа {numIsInArray} нет в массиве.");
