// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите 3х значное число");
int a = int.Parse(Console.ReadLine());
if (a>999 || a<100) Console.WriteLine("Это не трехзначное число");
else
{
    int b = int.Parse(a.ToString().Remove(1, 1));
    Console.WriteLine($"Убираем вторую цифру, получается число {b}");
}