﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = new Random().Next(5,16);
int[] array = GetArray(size);
Console.WriteLine($"Изначальный массив [{String.Join("; ", array)}]");
int[] NewArray = SearchPairNumbers(array, size);
Console.Write($"Новый массив [{String.Join("; ", NewArray)}]");

int[] GetArray(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = new Random().Next(10);
    }
    return mass;
}

int[] SearchPairNumbers(int[] mass, int length)
{
    int[] arraymass = new int[length];
    for (int i = 0, j = length - 1; i <= j; i++, j--)
    {
        if (length % 2 == 1)
        {
            if (i == j)
            {
                arraymass[(length / 2)] = array[i];
                break;
            }
            int multi = 1;
            multi = mass[i] * mass[j];
            arraymass[i] = multi;
        }
        else
        {
            int multi = 1;
            multi = mass[i] * mass[j];
            arraymass[i] = multi;
        }
    }
    return arraymass;
}


