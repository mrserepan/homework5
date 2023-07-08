﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] FillArray(int size = 123, int beginRange = 0, int endRange = 1000)
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
    System.Console.WriteLine(string.Join(",  ", array));
}

int SumTwoDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            System.Console.Write(array[i] + " ");
            count += 1; 
        }
    }
    return count;
}

//----------------------------------------------------------------------------

int[] array = FillArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {SumTwoDigit(array)}");
