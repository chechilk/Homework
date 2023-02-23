// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] resultArray = vvodArray(size);
vivodArray(resultArray,size);

int[] vvodArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

void vivodArray(int[] array, int length){
    Console.Write($"Массив из {length} чисел: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

//Ещё один вариант.
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] resultArray = GetArray(size);

// int[] GetArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(100);
//         Console.Write(array[i] + "\t");
//     }
//     return array;
// }

//Один из вариантов вывода массива.
//Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");

