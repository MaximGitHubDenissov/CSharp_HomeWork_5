// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] array = GetArray (10, -100000, 100000);
Console.WriteLine(String.Join("  ", array));
DiffMaxMin (array);

void DiffMaxMin (int [] res)
{
    int max = res [0];
    int min = res [0];
    for (int i=0; i < res.Length; i++)
    {
        if (res [i] > max) max = res [i];
        if (res [i] < min) min = res [i];
    }
    Console.WriteLine ($"Разница между максимальным элеметном {max} и минимальным {min} составляет {max-min}");
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}