// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int length = ReadString("Введите количество цифр в строке: ");
int[] arrayNumber = InputArray(length);
Console.Write($"Массив чисел: [{String.Join(",", arrayNumber)}]"); //вывод массива
SearchPositiveNumber(arrayNumber, length); //Поиск чисел больше 0

//считать информацию с консоли
int ReadString(string massege)
{
    Console.Write(massege);
    string readLine = Console.ReadLine();
    int result = Int32.Parse(readLine);
    return result;
}
//Записать числа с консоли в массив
int[] InputArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        arrayNumber[i] = ReadString($"Введите {i} число: ");
    }
    return arrayNumber;
}
//Поиск количества чисел больше 0
void SearchPositiveNumber(int[] array, int length)
{
    int countPositiveNumber = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            countPositiveNumber++;
        } 
    }
    if (countPositiveNumber > 0)
    {
        Console.WriteLine($"Чисел больше 0 = {countPositiveNumber}");
    } Console.WriteLine($"Чисел больше 0 не обнаружено!");
}

//Вроде работает, а вроде и нет)
// Console.Write("Введите M чисел через запятую или пробел ");
// string number = Console.ReadLine();
// int count = 0;
// for (int i = 0; i < number.Length; i++)
// {
//     if (number[i] == ',' || number[i] == ' ')
//     {
//         continue;
//     }
//     else if (number[i] > '0')
//     {
//         count++;
//     }
// }
// Console.Write(count);

//Вариант с массивом.
// Console.Write("Введите массив чисел: ");
// int size = 7, countPositive = 0;
// int[] arrayNumber = new int[size];
// for (int i = 0; i < size; i++)
// {
//     arrayNumber[i] = new Random().Next(-10, 11);
//     if (arrayNumber[i] > 0)
//     {
//         countPositive++;
//     }
// }
// Console.Write($"Массив чисел [{String.Join("; ", arrayNumber)}] , чисел больше 0 = {countPositive}");


