// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[num1, num2];
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int [] sum = new int [num1];
int summa = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summa = summa + matrix[i, j];
    }
    sum[i] = summa;
}

int min = 100000;
int imin = 0;
for (int i = 0; i < matrix.GetLength(0); i++) //ищем минимальный элемент
{
    if (sum[i] < min)
    {
        min = sum[i];
        imin = i;
    }
    Console.WriteLine($"Минимальная сумма строки = {min} и находится она в строке {imin}");
    break;
}           


