// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
if (a%2==0)
{
 a = a*a*a;
 Console.WriteLine($"Куб числа а = {a}");
}
else Console.WriteLine("Число не заканчивается на четную цифру");