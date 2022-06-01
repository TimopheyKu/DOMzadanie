// Написать программу копирования массива

int[] array = new int[10];

void PrintFillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
        Console.WriteLine(array[i]);
    }
}
PrintFillArray(array);
Console.WriteLine();
void CopyArray (int [] array, int count)
{
    for (int j = 0; j < count; j++)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]  );
        }
        Console.WriteLine();
    }
    
}
Console.WriteLine("Задаем в функции колиство (count) копий нашего массива");
CopyArray(array, 5);
