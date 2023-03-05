// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double lineOneValueOne = StringRead("Введите первую переменную первой прямой k1 = ");//k1
double lineOneValueTwo = StringRead("Введите вторую переменной первой прямой b1 = ");//b1
double lineTwoValueOne = StringRead("Введите первую переменную второй прямой k2 = ");//k2
double lineTwoValueTwo = StringRead("Введите вторую переменную второй прямой b2 = ");//b2
double ResultX = SearchAbscissa(lineOneValueOne, lineOneValueTwo, lineTwoValueOne, lineTwoValueTwo);
SearchOrdinate(ResultX, lineOneValueOne, lineOneValueTwo, lineTwoValueOne, lineTwoValueTwo);

//Ввод переменных прямых
double StringRead(string massege)
{
    Console.Write(massege);
    string readLine = Console.ReadLine();
    double result = Double.Parse(readLine);
    return result;
}
//Вычисление значения x.
double SearchAbscissa(double kOne, double bOne, double kTwo, double bTwo)
{
    double x = 0;
    x = (bTwo - bOne) / (kOne - kTwo);
    return x;
}
//Вычисление значения y двух прямых.
void SearchOrdinate(double x, double kOne, double bOne, double kTwo, double bTwo)
{
    double yOne = 0, yTwo = 0;
    yOne = (kOne * x) + bOne;
    yTwo = (kTwo * x) + bTwo;
    if (yOne == yTwo)
    {
        Console.Write($"Прямые пересекаются в точках ({ResultX},{yOne})");
    } else Console.Write($"Прямые не пересекаются");
}
