// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите значение x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значени y");
int y = int.Parse(Console.ReadLine());
if (x > 0 && x < 1000 && y > 0 && y < 1000) Console.WriteLine("Первая четверть");
else if (x > 0 && x < 1000 && y < 0 && y > -1000) Console.WriteLine("Вторая четверть");
else if (x < 0 && x > -1000 && y < 0 && y > -1000 ) Console.WriteLine("Третья четверть");
else if (x < 0 && x > -1000 && y > 0 && y < 1000) Console.WriteLine("Четвертая четверть");
else Console.WriteLine("Значение вне диапазона от -1000 до 1000");
