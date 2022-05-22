// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] array = new int [20];
Console.WriteLine("Задаем массив из 20 элементов");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,999);
    Console.WriteLine(array[i]);
}

int sum = 0; 
int summin = 0; 

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        sum++;
    }
    else if (array[i]%2 != 0)
    {
        summin++;
    }
}

Console.WriteLine($"Количество четных чисел = {sum}");
Console.WriteLine($"Количество нечетных чисел = {summin}");