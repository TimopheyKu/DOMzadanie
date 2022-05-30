// // Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine("Введите во сколько k раз должен увеличиться/уменьшиться квадрат: ");
double k = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите начальную координату квадрата по оси x: ");
double x0 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите начальную координату квадрата по оси y: ");
double y0 = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите следующую координату квадрата по оси x: ");
double x1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите следующую координату квадрата по оси y: ");
double y1 = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine($"Начальные координаты точки a[{x0}, {y0}]");
Console.WriteLine($"Начальные координаты точки b[{x0}, {y1}]");
Console.WriteLine($"Начальные координаты точки c[{x1}, {y0}]");
Console.WriteLine($"Начальные координаты точки d[{x1}, {y1}]");
Console.WriteLine();

if(k!=1)
{
    x1 = x1*k;
    y1 = y1*k;
    Console.WriteLine($"Координаты точки a1[{x0}, {y0}]");
    Console.WriteLine($"Координаты точки b1[{x0}, {y1}]");
    Console.WriteLine($"Координаты точки c1[{x1}, {y0}]");
    Console.WriteLine($"Координаты точки d1[{x1}, {y1}]");
}
else Console.WriteLine($"Координаты точек квадрата a[{x0}, {y0}]; b[{x0}, {y1}]; c[{x1}, {y0}];d[{x1}, {y1}] ");
