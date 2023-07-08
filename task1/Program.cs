﻿
﻿// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int beginRange = 100, int endRange = 1000)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(beginRange, endRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(", ", array));
}

int SumEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}

//--------------------------------------------------------------------------------------

int size = ReadInt("Задайте размер массива: ");
int[] array = FillArray(size);
PrintArray(array);

System.Console.WriteLine($"Количество чётных элементов в массиве: {SumEven(array)}");