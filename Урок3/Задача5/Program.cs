// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    sum = sum + a%10;
    a = a/10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");