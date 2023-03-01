// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 11;
int[] array = GetArray(size);
Console.Write($"Сумма элементов нечётных позиций массива [{String.Join("; ", array)}] равна {Summ(array, size)}");

int[] GetArray(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = new Random().Next(10);
    }
    return mass;
}

int Summ(int[] mass, int length)
{
    length = length / 2;
    int summ = 0;
    for (int i = 1; i < length; i = +2)
    {
        summ = summ + mass[i];
    }
    return summ;
}
