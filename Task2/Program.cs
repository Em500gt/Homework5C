//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
using static System.Console;
Clear();

int[] Arr(int len)
{
    int[] result = new int[len];
    for(int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

void CountArray(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 != 0) count++;
    }
    Write($" -> {count}");
}

Write("Введите количество элементов массива: ");
int l = int.Parse(ReadLine()!);
int[] array = Arr(l) ;
Write($"[{String.Join(",",array)}]");
CountArray(array);
