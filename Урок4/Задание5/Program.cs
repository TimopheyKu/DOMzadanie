// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.WriteLine($"Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];
Console.WriteLine("Наш массив:"); 
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i]); 
}
Console.WriteLine();

int pow = 0;
int size = array.Length;
for (int i = 0; i < array.Length/2; i++)
 {
    pow = array[i]*array[size-1];
    size--;
    Console.WriteLine($"Произведение парных симметричных чисел равно = {pow}"); 
 }


