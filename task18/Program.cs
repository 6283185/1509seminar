// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarterNum = Convert.ToInt32(Console.ReadLine());
string result = RangeStr(quarterNum);
Console.WriteLine(result);


// void Range(int quarterX)
// {
//     if (quarterX == 1) Console.WriteLine("x > 0, y > 0");
//     else if (quarterX == 2) Console.WriteLine("x < 0, y > 0");
//     else if (quarterX == 3) Console.WriteLine("x < 0, y < 0");
//     else if (quarterX == 4) Console.WriteLine("x > 0, y < 0");
//     else Console.WriteLine("Введены некорректные данные.");
// }

// Range(quarterNum);

string RangeStr(int quarter1)
{
    if (quarter1 == 1) return "x > 0 ; y > 0";
    if (quarter1 == 2) return "x < 0 ; y > 0";
    if (quarter1 == 3) return "x < 0 ; y < 0";
    if (quarter1 == 4) return "x > 0 ; y < 0";
    return "Введены некорректные данные.";
}
