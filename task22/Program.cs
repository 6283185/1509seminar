// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//без метода
// int counter = 1;
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (counter <= number)
// {
//     Console.WriteLine($"{counter} => {counter * counter} ");
//     counter++;
// }
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"|{counter, 4}| => |{counter * counter, 4}| ");
        counter++;
    }
}
if (number > 0) SquareTable(number);
else Console.WriteLine("Введено некорректное значение.");