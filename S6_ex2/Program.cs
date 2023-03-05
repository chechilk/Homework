// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double lineOneValueOne = StringRead("Введите первую переменную первой прямой k1 = ");//k1
double lineOneValueTwo = StringRead("Введите вторую переменной первой прямой b1 = ");//b1
double lineTwoValueOne = StringRead("Введите первую переменную второй прямой k2 = ");//k2
double lineTwoValueTwo = StringRead("Введите вторую переменную второй прямой b2 = ");//b2

double resultX = SearchAbscissa(kOne: lineOneValueOne,
                                bOne: lineOneValueTwo,
                                kTwo: lineTwoValueOne,
                                bTwo: lineTwoValueTwo);
double resultY = SearchOrdinate(kOne: lineOneValueOne,
                                bOne: lineOneValueTwo,
                                kTwo: lineTwoValueOne,
                                bTwo: lineTwoValueTwo);
Answer(resultX,resultY);

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
//Вычисление значения y.
double SearchOrdinate(double kOne, double bOne, double kTwo, double bTwo)
{
    double y = 0;
    y = (kOne * (bTwo - bOne) / (kOne - kTwo)) + bOne;
    return y;
}

void Answer (double x, double y){
    if (x == y)
    {
        Console.Write($"Две прямые пересекаются в точке ({x},{y})");
    } else Console.Write("Прямые не пересекаются");
}
