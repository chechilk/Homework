// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int x)
{
    int sum = 0, i = 0;
    while (x > 0)
    {
        sum += (x % 10);
        i++;
        x /= 10;
    }
    return sum;
}
Console.Write($"Сумма всех чисел числа {number} = {GetSum(number)}");