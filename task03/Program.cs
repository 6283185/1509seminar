// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите номер дня недели: ");
int day_number = Convert.ToInt32(Console.ReadLine());
if (day_number == 1) Console.WriteLine("Понедельник");
else if (day_number == 2) Console.WriteLine("Вторник");
else if (day_number == 3) Console.WriteLine("Среда");
else if (day_number == 4) Console.WriteLine("Четверг");
else if (day_number == 5) Console.WriteLine("Пятница");
else if (day_number == 6) Console.WriteLine("Суббота");
else if (day_number == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Нет такого дня недели.");