// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите значение A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень В");
int B = int.Parse(Console.ReadLine());
int pow = A;
int B1 = 1;
while (B1 < B)
{
    pow = pow * A;
    B1++;
}

Console.WriteLine($"Число {A} в натуральной степени {B} = {pow}");