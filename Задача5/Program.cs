// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a>999 || a<100) Console.WriteLine("Это не трехзначное число");
else 
{
    a = a/10%10;
    Console.WriteLine($"Второе число 3х значного числа: {a}");
}
    