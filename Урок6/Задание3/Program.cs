// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите число строк rows:" ?? "0");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число стобцов columns:" ?? "0");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

// int [,] array = new int[columns, rows];
void FillArray (int [,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int tmp = 0;
int qudr = 0;
void Quadr (int [,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i%2==0 && j%2==0) 
            {
                qudr = array[i,j]*array[i,j];
                tmp = array[i,j];
                array[i,j] = qudr;
                qudr = tmp;
            }
        }
        Console.WriteLine();
    }
}

int [,] arr = new int[columns, rows];
FillArray(arr);
PrintArray(arr);
Quadr(arr);
PrintArray(arr);
