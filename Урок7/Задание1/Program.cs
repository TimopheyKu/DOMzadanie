// Написать программу, которая обменивает элементы первой строки и последней строки.

Console.Clear();
int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int[] tempmas = new int[4];
for (int i = 0, j = 0, k = 0; j < 4; j++, k++) // Занесли первую строки в пустой массив
{
    tempmas[k] = matrix[i, j];
    matrix[0, j] = matrix[3, j]; // Заменяем минимальную строку максимальной
    matrix[3, j] = tempmas[j];   // Заменяем максимальную строку минимальной
}

Console.WriteLine();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}