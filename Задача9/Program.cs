// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 99 && a > -99) Console.WriteLine("Третьей цифры числа нет. Введите другое число");
else 
{
         string b = a.ToString();
         Console.WriteLine($"Третья цефра числа = {b[2]}");
}
