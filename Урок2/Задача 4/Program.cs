// Найти расстояние между точками в пространстве 2D/3D

// (x2-x1)*(x2-x1)+(y2-y1)*y2-y1)+(z2-z1)*(z2-z1)
// Console.Write(Math.Sqrt(x)) - корень из x
// distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Point2D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Point3D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("Введите значение координат первой точки в 3D");
Console.WriteLine("Введите значение x1 = ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y1 = ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z1 = ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координат второй точки в 2D");
Console.WriteLine("Введите значение x2 = ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y2 = ");
double y2 = double.Parse(Console.ReadLine());
double z2 = 0;

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между двумя точками в плоскостях 2D и 3D: {distance}");
