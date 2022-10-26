// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
Console.Write("Введите количество строк создаваемой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов создаваемой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки: ");
int rowsRequested = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columnsRequsted = Convert.ToInt32(Console.ReadLine());


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

void PrintMatrix(int[,] mtx)
{
    
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            if (j < mtx.GetLength(1) - 1)
            {
                Console.Write($"{mtx[i, j], 4}, ");
            }
            else Console.Write($"{mtx[i, j], 4}");

        }
        Console.WriteLine("]");
    }   
}

int ValueOfMatrixElement(int[,] mtx, int row, int column)
{
    return mtx[row, column];    
}

int[,] array2D = CreateMatrixRndInt(rows, columns, 0, 100);
PrintMatrix(array2D);

if (rowsRequested >= rows || columnsRequsted >= columns) Console.WriteLine("Элемента с таким индексом не существует.");
else
{
    int valueOfMatrix = ValueOfMatrixElement(array2D, rowsRequested, columnsRequsted);
    Console.WriteLine($"Элемент массива под индексами [{rowsRequested},{columnsRequsted}] = {valueOfMatrix}");
}

