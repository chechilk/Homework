// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");

double[,] resultMatrix = InputMatrix(rows, column);
OutputMatrix(resultMatrix);

//Вывод текста и возврат инфорации с консоли
int ReadString(string massege)
{
    Console.Write(massege);
    string readLine = Console.ReadLine();
    int result = Int32.Parse(readLine);
    return result;
}
//Заполнение матрицы рандомными вещественными числами
double[,] InputMatrix(int rows, int column)
{
    double[,] matrix = new double[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble()) * 10, 2);
        }
    }
    return matrix;
}
//Вывод матрицы
void OutputMatrix(double[,] matrix)
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