// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях


int[] array = new int[10];
FillArrayRandomNumbers(array);
PrintArray(array);
int sumEvenPosition = 0;

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.Length; i = i + 2)
{
    sumEvenPosition += array[i];
}
Console.WriteLine($"Сумма четных индексов массива: {sumEvenPosition}");