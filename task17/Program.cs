// int num = 13;
// int count = 0;

// int[] arr = new int[num / 2];
// while (count <= 13)
// {
//     if (count % 2 == 0)
//     {
//         arr[count] = count + 2;
//     }
//     //Console.Write($"{count} ");
//     count++;
// }

// int[] EvenNums(int num)
// {
//     int count = 0;
//     int[] arr = new int[num / 2];
//     while (count <= num)
//     {
//         if (count % 2 == 0)
//         arr[count] = count + 2;
//     count++;
//     }
//     return arr;
// }



// void EvenNums2(int num)
// {
//     int count = 2;
//     while (count <= num)
//     {

//         Console.Write($"{count} ");
//         count += 2;
//     }

// }

// Console.WriteLine(EvenNums);
// Console.WriteLine(EvenNums2);

// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки ");
Console.Write("x: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Введены некорректные координаты." : quarter);
string quarterStr = QuarterStr(xC, yC);
Console.WriteLine(quarterStr);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return "Число находится в первой четверти плоскости.";
    if (x < 0 && y > 0) return "Число находится в второй четверти плоскости.";
    if (x < 0 && y < 0) return "Число находится в третьей четверти плоскости.";
    if (x > 0 && y < 0) return "Число находится в четвертой четверти плоскости.";
    return "Введены некорректные координаты.";
}