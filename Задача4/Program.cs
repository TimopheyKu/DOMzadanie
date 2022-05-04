// Показать четные числа от 1 до N
Console.WriteLine("Введите любое число больше 1: ");
int N = int.Parse(Console.ReadLine());
int a = 1;
if (N < 1) Console.WriteLine("Это число меньше 1 ");
else Console.WriteLine($"Все четные числа от 1 до {N}: ");
{ 
 while (a <= N)
 {
    if (a%2 == 0) 
    { 
        Console.WriteLine($"{a}");
    }
  a++; 
 }
}