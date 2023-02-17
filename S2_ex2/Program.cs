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
    int x = number / 10000;
    int y = x / 10 * 10;
    Console.WriteLine($"Третья цифра числа {number} = {x - y}");
}


