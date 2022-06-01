// Задать двумерный массив следующим правилом: Aₘₙ = m+n (Не совсем понял задание)
Console.WriteLine("Введите числа n и m");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] A = new int [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i,j] = new Random().Next(0,10);
        Console.WriteLine(A[i,j]);
    }
    Console.WriteLine();
}