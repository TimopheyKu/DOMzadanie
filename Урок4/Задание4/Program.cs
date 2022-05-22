// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array = new int [123];
Console.WriteLine("Задаем массив из 20 элементов");
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.WriteLine(array[i]);
    if (array[i] > 10 && array[i] < 99)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine ($"Количество элементов из отрезка [10,99] в массиве = {sum}");

