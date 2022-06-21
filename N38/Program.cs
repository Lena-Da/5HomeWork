// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] array = new double[10];
FillArrayRandomNumbers(array);
PrintArray(array);
double diffMinMax = 0;
double min = 30;
double max = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
    if (max < array[i])
    max = array[i];
    }
}
Console.WriteLine($"Максимальное число массива: {max}");

for(int i = 0; i < array.Length; i++)
{   
    if (array[i] >= 0)
    {
    if (min > array[i])
    min = array[i];
    }
}
Console.WriteLine($"Минимальное число массива: {min}");


diffMinMax = max - min;
Console.WriteLine($"Разница между минимальным и максимальным числом массива: {diffMinMax}");


void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 30) / 10.0;
    }
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

