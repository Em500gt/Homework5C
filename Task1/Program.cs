//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using static System.Console;
Clear();

int[] Arr(int len)
{
    int[] result = new int[len];
    for(int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void CountArray(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0) count++;
    }
    Write($" -> {count}");
}

Write("Введите количество элементов массива: ");
int l = int.Parse(ReadLine()!);
int[] array = Arr(l) ;
Write($"[{String.Join(",",array)}]");
CountArray(array);


// void PrintArray(int[] arr)
// {
//     foreach (int item in arr)
//     {
//         Write(item + " ");
//     }
// }
