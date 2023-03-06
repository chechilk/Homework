// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int size = 10;
// int[] array = Vvodarray(size);
// int foundNumber = new Random().Next(11);// 0-9
// bool isMath = PoiskNumber(foundNumber, size, array);;
// Console.Write($"Число {foundNumber} {Result(isMath)} в массиве [{String.Join("; ", array)}]");

// int[] Vvodarray(int lenght)
// {
//     int[] mass = new int[lenght];
//     for (int i = 0; i < lenght; i++)
//     {
//         mass[i] = new Random().Next(11);
//         // Ввод массива с клавиатуры
//         // Console.Write($"Введите {i} элемент массива: ");
//         // mass[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return mass;
// }

// bool PoiskNumber(int found, int length, int[] mass)
// {
//     bool isfound = false;
//     for (int i = 0; i < length; i++)
//     {
//         if (mass[i] == found)
//         {
//             isfound = true;
//             break;
//         }
//     }
//     return isfound;
// }

// string Result(bool isfound)
// {
//     string result = null;
//     if (isfound == true)
//     {
//         result = "найдено";
//     }
//     else result = "не найдено";
//     return result;
// }

//---------------------------------------------------------------------------------
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int size = 10;
// int[] array = Vvodarray(size);
// int foundNumber = new Random().Next(0, 150);// 0-9
// //int count = PoiskCount(size, array);
// Console.Write($"В массиве [{String.Join("; ", array)}] \n{PoiskCount(size, array)} элементов в отрезке [10;99]");

// int[] Vvodarray(int length)
// {
//     int[] mass = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         mass[i] = new Random().Next(0, 100);
//     }
//     return mass;
// }

// int PoiskCount(int length, int[] mass)
// {
//     int n = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (mass[i] >= 10 && mass[i] <= 99)
//         {
//             n++;
//         }
//     }
//     return n;
// }
//---------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Введите сторону a = ");
// int a = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введите сторону b = ");
// int b = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введите сторону c = ");
// int c = Convert.ToInt16(Console.ReadLine());

// bool IsTriangle(int a, int b, int c){
//     return (a + b > c && b + c > a && c + a > b);
// }
// Console.WriteLine(IsTriangle(a,b,c));

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Console.Write("Введите количество чисел Фибоначчи: ");
// int countFibonacci = Convert.ToInt32(Console.ReadLine());
// int firstFibonacci = 0;
// int secondFibonacci = 1;
// Console.Write($"{firstFibonacci} \n{secondFibonacci} \n");

// int nextFibonacci = 0;
// for (int i = 3; i <= countFibonacci; i++)
// {
//     nextFibonacci = firstFibonacci + secondFibonacci;
//     firstFibonacci = secondFibonacci;
//     secondFibonacci = nextFibonacci;

//     Console.Write(nextFibonacci + "\n");
// }
//----------------------------------------------------------------
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените
// эти элементы на их квадраты.
// Матрица - таблица, размерностью m строк на n столбцов

int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");
int[,] matrix = InputMatrix(rows, column);
OutputMatrix("Изначальная матрица",matrix);
int[,] resultMatrix = ChangeMatrix(matrix, rows, column);
OutputMatrix("Изменённая матрица:", resultMatrix);

//Вывод текста и возврат инфорации с консоли
int ReadString(string massege)
{
    Console.Write(massege);
    string readLine = Console.ReadLine();
    int result = Int32.Parse(readLine);
    return result;
}
//Заполнение массива рандомными числами от 1 до 10
int[,] InputMatrix(int rows, int column)
{
    int[,] matrix = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

//Поиск чётных индексов матрицы и замена элементов на квадраты
int[,] ChangeMatrix(int[,] matrix, int rows, int column)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}
//вывод матрицы
void OutputMatrix(string text, int[,] matrix)
{
    Console.WriteLine(text);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}



