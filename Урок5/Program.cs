﻿// Найти точку пересечения двух прямых заданных уравнением: 
// y = k1 * x + b1, 
// y = k2 * x + b2,        b1 k1 и b2 и k2 заданы   


Console.WriteLine("Введите переменную b1");
int b1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите переменную k1");
int k1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите переменную b2");
int b2 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите переменную k2");
int k2 = int.Parse(Console.ReadLine()); 

int x = (b2 - b1)/(k1 - k2);
int y = k2 * x + b2;
if (k1 * x + b1 == k2 * x + b2 )
{
    Console.WriteLine($"Координаты точки пересечения: {x} and {y}");
}
else Console.WriteLine("Линии не пересекаются");

