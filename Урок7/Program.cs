// Написать программу, которая обменивает элементы первой строки и последней строки. Не получается поменять строки местами.
// Подскажите, как это сделать. Пробавал через tmp, но не получается

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

void ChangeValue (int[,] matr)
{
   int tmp = 0;
   int minstr = 0;
   int maxstr = matr.GetLength(0)-1;
   for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            while (j < matr.GetLength(1))
            {
                // tmp = matr[minstr,j];
                matr[minstr,j] = matr[maxstr, j];
                // matr[maxstr, j] = tmp;
                
                // matr[maxstr, j] = matr[minstr, j];
                j++;
            }  
        }
    }
}
int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeValue (matrix);
PrintArray(matrix);