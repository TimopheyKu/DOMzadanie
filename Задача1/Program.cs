Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("Да, первое число является квадратом второго и равно ");
    Console.WriteLine(a);
}
else{
    Console.WriteLine("Нет, квадрат второго числа не ровняется первому");
}