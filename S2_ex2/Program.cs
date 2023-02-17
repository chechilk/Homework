// Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, 
// что третьей цифры нет.
// 78 -> третьей цифры нет
// 3267900 -> 6


Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    int x1 = number / 10000;
    int y1 = x1 / 10 * 10;
    int x2 = number % 1000 / 100;
    Console.WriteLine($"Третья цифра числа c левой стороны {number} = {x1 - y1}, с правой стороны = {x2}");
}



