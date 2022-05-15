// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число №1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2");
int num2 = int.Parse(Console.ReadLine());
if (num1 == num2*num2) Console.WriteLine("Число №1 является квадратом числа №2");
else if (num2 == num1*num1) Console.WriteLine("Число №2 является квадратом числа №1");
else Console.WriteLine("Ни одно из чисел не является квадратом другого");
