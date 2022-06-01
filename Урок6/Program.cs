// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintFillArray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.WriteLine(array[i,j]);
        }
    Console.WriteLine();    
    }
}

Console.WriteLine("Введите число m, n: ");
int m = int.Parse(Console.ReadLine()??"0");
int n = int.Parse(Console.ReadLine()??"0");
int [,] matrix = new int [n,m];
Console.WriteLine();   
PrintFillArray(matrix);