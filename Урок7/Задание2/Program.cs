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

void CorrectArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            int minnumber = matr[i, j];
            if (matr[i, j] < minnumber) 
            {
                int tmp = matr[i, j];
                matr[i, j] = minnumber;
                minnumber = tmp;
            }
        }
    }
}


int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
CorrectArray (matrix);
PrintArray(matrix);
