// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random(). Next(10,99); 
Console.WriteLine($"Число из отрезка от 10 до 99: {a}");
int b = a/10;
int c = a%10;
if (b > c) Console.WriteLine($"Наибольшее число: {b}");
else Console.WriteLine($"Наибольшее число: {c}");
