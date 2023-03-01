// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 11;
double[] array = GetArray(size);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
SearchMaxMin(array, size);

double[] GetArray(int length)
{
    double[] mass = new double[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = Math.Round(new Random().NextDouble() * 100);
    }
    return mass;
}

void SearchMaxMin(double[] mass, int length)
{
    double max = 0;
    for (int i = 0; i < length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
    }
    double min = max;
    for (int i = 0; i < length; i++)
    {
        if (mass[i] < min)
        {
            min = mass[i];
        }
    }
    Console.WriteLine($"Максимальное число = {max} \nМинимальное число = {min}");
    Console.WriteLine($"Разность {max} - {min} = {max - min}");
}