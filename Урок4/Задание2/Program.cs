// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int [] array = new int [12];
Console.WriteLine("Задаем массив из 12 элементов");
for (int i = 0; i < array.Length; i++) 
{
    array[i] =  new Random().Next(-9,9);
    Console.WriteLine(array[i]);
}
int sumplus = 0;
int summin = 0;

for (int i = 0; i < array.Length; i++) 
  if (array[i] < 0)
    {
        summin = summin + array[i];
    }
  else if (array[i] > 0)
    {
        sumplus = sumplus + array[i];
    }

Console.WriteLine($"Сумма положительных чисел = {sumplus}");
Console.WriteLine($"Сумма отрицательных чисел = {summin}"); 