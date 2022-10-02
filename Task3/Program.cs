//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
using static System.Console;
Clear();

double[] Arr(int len)
{
    double[] result = new double[len];
    for(int i = 0; i < len; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

void difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    foreach (int item in arr)
    {
        if(item > max) max = item;
        if(item < min) min = item;    
    }

    Write($" -> {max - min}");
}

Write("Введите количество элементов массива: ");
int l = int.Parse(ReadLine()!);
double[] array = Arr(l) ;
Write($"[{String.Join(",",array)}]");
difference(array);