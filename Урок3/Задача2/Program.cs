// Найти кубы чисел от 1 до N

Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine());
int start = 1;
Console.WriteLine($"Кубы чисел от 1 до {N}");
while (start <= N)
{
    Console.WriteLine($"{start}|{start*start*start}");
    start++;
}
