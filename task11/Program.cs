// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//без функции:

// int number = new Random().Next(100, 1000);

// int firstNum = number / 100;
// int lastNum = number % 10;
// Console.WriteLine($"Случайное трёхзначное число: {number}, без второй цифры: {(firstNum * 10) + lastNum}");

//функция:

int number = new Random().Next(100, 1000);
int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

Console.WriteLine($"Случайное трёхзначное число: {number}, без второй цифры: {RemoveSecondDigit(number)}");