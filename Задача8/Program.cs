// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите заданное число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную b");
int b = int.Parse(Console.ReadLine());
if (a%b == 0)  Console.WriteLine($"Число {a} кратно числу {b} ");
else Console.WriteLine($"{a%b}");