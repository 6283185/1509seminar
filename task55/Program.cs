// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк создаваемой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов создаваемой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplaceRowsOnColumns(matrix);
}
else
{
    Console.WriteLine("Матрица не соответствует условиям");
}

int[,] ReplaceRowsOnColumns(int[,] mtx)
{
    int[,] newArray = new int[rows,columns];
}
int[,] matrix = CreateMatrixRndInt(rows, columns, 0, 10);
PrintArray(matrix);

Console.WriteLine();
PrintArray(matrix);
