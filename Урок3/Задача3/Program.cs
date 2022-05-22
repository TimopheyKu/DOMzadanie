// Найти сумму чисел от 1 до А

Console.WriteLine("Введите значение А");
int A = int.Parse(Console.ReadLine());
int start = 1;
int sum = 0;
Console.WriteLine($"Сумма чисел от 1 до {A}");
while (start <= A)
{
    sum = sum + start;
    start++;
}
Console.WriteLine($"{sum}");