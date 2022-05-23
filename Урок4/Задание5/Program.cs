// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] array = new int [5];
Console.WriteLine("Задаем массив из 5 элементов");

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i]);
}
