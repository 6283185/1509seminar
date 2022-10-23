// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число для преобразования в двоичный код: ");
int numToConvert = Convert.ToInt32(Console.ReadLine());

int ConvertIntoBinary(int num)
{
    int binaryNum = default;
    int count = 1;
    while (num > 0)
    {
        binaryNum += num % 2 * count;
        count *= 10;
        num /= 2;

    }
    return binaryNum;
}

int binaryNum = ConvertIntoBinary(numToConvert);
Console.WriteLine(binaryNum);

