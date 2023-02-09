﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int [] array = GetRandomArray(10,-100,100);

Console.WriteLine($"[{String.Join(", ", array)}]");
int[] GetRandomArray(int size, int minValue, int maxValue)
{

int [] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(minValue, maxValue +1);
}
return result;
}

int sum = array[1];
for (int i = 3; i < array.Length; i=i+2)
{
    sum=sum+array[i];
}


Console.WriteLine($"Сумма элементов, стоящих на чётных позициях: {sum}");