// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

int [] array = GetRandomArray(5,0,100);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] GetRandomArray(int size, int minValue, int maxValue)
{

int [] result = new int[size];
for (int i = 0; i <size; i++)
{
result[i] = new Random().Next(minValue, maxValue +1);
}
return result;
}

Array.Sort(array);
int minValue = array[0];
int maxValue = array[array.Length-1];
Console.WriteLine(minValue);
Console.WriteLine(maxValue);
int result = maxValue-minValue;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:  {result}");