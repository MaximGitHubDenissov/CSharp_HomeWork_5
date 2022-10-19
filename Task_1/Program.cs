// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = GetArray(10); // В условии задачи не был указан размер массива, указал самостоятельно
Console.WriteLine(String.Join("  ", array));
CheckEvenNumber(array);

void CheckEvenNumber (int [] mass)
{
    int count = 0;
    for (int i=0; i < mass.Length; i++)
    {
        if (mass [i]%2 ==0) count++;
    }
    Console.WriteLine ($"В массиве {count} четных числа");
}

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}
