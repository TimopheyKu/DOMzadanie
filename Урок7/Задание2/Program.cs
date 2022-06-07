// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
    for (int i = 0; i < matr.GetLength(0); i++) //  0 это 3 из [3,4]
    {
        for (int j = 0; j < matr.GetLength(1); j++) // - 1 это 4 из [3,4]
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortNumber(int[,] matr)
{
    int[] temp = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp[j] =  matr[i,j];
        }
        Array.Sort(temp);
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            matr[i, k] = temp[k];
        }
    }
}


int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SortNumber(matrix);
//ChangeNumber(matrix);
PrintArray(matrix);
