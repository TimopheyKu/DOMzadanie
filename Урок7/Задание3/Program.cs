// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //  0 это 3 из [3,4]
    {
        for (int j = 0; j < matr.GetLength(1); j++) //  - 1 это 4 из [3,4]
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();

    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangeColumnLine (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            if (i == j)
            {
                int tmp = matr[i,j];
                matr[i,j] = matr[j,i];
                matr[j,i] = tmp;
            }
            else Console.WriteLine("матрица не квадратная");
            break;
        }
    }
}
int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeColumnLine(matrix);
PrintArray(matrix);
