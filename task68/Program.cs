// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AkkermanF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return AkkermanF(m - 1, 1);
    }
    return (AkkermanF(m - 1, AkkermanF(m, n - 1)));    
}

int akkerman = AkkermanF(numberM, numberN);
Console.WriteLine($"Результат работы функции Аккермана для чисел M({numberM}) и N({numberN}) = {akkerman}");