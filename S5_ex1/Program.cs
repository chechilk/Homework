// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.Write($"Количество чётных чисел в массиве [{String.Join("; " , array)}] равно {SearchCount(array, size)}");

int[] GetArray(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;
}

int SearchCount(int[] mass, int length)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

