// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//1(строчка) 7 (столбец) -> такого числа в массиве нет


int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");
int[,] matrix = InputMatrix(rows, column);
OutputMatrix(matrix);
int number = ReadString("Введите искомое число: ");
SearchNumber(matrix, number);

int ReadString(string massege)
{
    Console.Write(massege);
    string readLine = Console.ReadLine();
    int result = Int32.Parse(readLine);
    return result;
}

//Заполнение матрицы рандомными вещественными числами
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

//Вывод заполненного массива
void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Поиск числа в матрице 
void SearchNumber(int[,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == num)
            {
                Console.WriteLine($"Число {num} находится в {i} строке {j} столбце");
            } 
        }   
    }
}