
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = GetArray(10, -9, 20);
Console.WriteLine(String.Join("  ", array));
SumOfOddIndex (array);

void SumOfOddIndex(int[] mass)
{

    int sum = 0;
    for (int i = 1; i < mass.Length; i++)
    {
        if (i % 2 == 1) sum = sum + mass[i];
    }
    Console.WriteLine ($"Сумма элементов, стоящих в массиве на нечетных позициях равна {sum}");
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