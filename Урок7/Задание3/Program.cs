// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[num1, num2];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = i + 1; j < matrix.GetLength(1); j++)
    {
        if (num1 == num2)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
if (num1 != num2) Console.WriteLine("массив не квадратный, замена невозможна");
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
