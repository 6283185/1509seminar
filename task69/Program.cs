// Задача 69: Напишите программу, которая на вход
// принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите основание, которое нужно возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую будем возводить: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetPowNum(int num1, int num2)
{    
    if (num2 == 0) return 1;    
    return num1 * GetPowNum(num1, num2 - 1);

}

Console.WriteLine(GetPowNum(number, number2));