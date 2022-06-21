// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = new int[10];
FillArrayRandomNumbers(array);
PrintArray(array);
int sumEven = 0;
 
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    sumEven += array[i];   
}
Console.WriteLine($"Сумма четных чисел массива: {sumEven}");
