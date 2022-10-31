// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("Введите количество строк создаваемой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов создаваемой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateMatrixRndInt(rows, columns, 0, 10);
int[,] secondMatrix = CreateMatrixRndInt(rows, columns, 0, 10);


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

int[,] MatrixMultiply(int[,] array1, int[,] array2, int rows, int columns)
{
    int[,] resultArray = new int[rows, columns];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}



void PrintArray2D(int[,] array)
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



PrintArray2D(firstMatrix);
Console.WriteLine();
PrintArray2D(secondMatrix);
Console.WriteLine();
int[,] resArray = MatrixMultiply(firstMatrix, secondMatrix, rows, columns);
if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
}
else
{
    PrintArray2D(resArray);
}

