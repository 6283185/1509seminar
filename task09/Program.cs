// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int first_digit = number / 10;
// int second_digit = number % 10;
// if (first_digit == second_digit)
// {
//     Console.WriteLine("Цифры равны");
// }
// else if (first_digit > second_digit)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {first_digit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа {number}: {second_digit}");
// }

// int maxDigit = first_digit;
// if (second_digit > first_digit) maxDigit = second_digit;
// int maxDigit = first_digit > second_digit ? first_digit : second_digit;

//Console.WriteLine();

int MaxDigit(int num)
{
    int first_digit = num / 10;
    int second_digit = num % 10;
    //if (first_digit == second_digit) Console.WriteLine("Цифры равны");
    // if (first_digit > second_digit) return first_digit;
    // return second_digit;
    if (first_digit == second_digit) return 0;
    return first_digit > second_digit ? first_digit : second_digit;
}



int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number}: {result}");


