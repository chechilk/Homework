// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int lengthBinaryArray = SearchLength(number);
ArrayMod(lengthBinaryArray, number);

int SearchLength(int number)
{
    int size = 0;
    while (number >= 2)
    {
        number = number / 2;
        size++;
    }
    return (size + 1);
}

void ArrayMod(int length, int number)
{
    int firstValue = number;
    int num = 0;
    int[] arrayModNumber = new int[length];
    for (int i = length - 1; i < length; i--)
    {
        while (number >= 2)
        {
            num = number / 2; //ищем целое значение
            arrayModNumber[i] = number - (num * 2); //ищем остаток
            if (i == 0)
            {
                arrayModNumber[i] = num / 2;
            }
            Console.WriteLine($"Число {number} вычитаемое {num * 2} остаток {arrayModNumber[i]}");
            number = number / 2;
            break;
        }
    }
    Console.Write($" Число {firstValue} в двоичной системе = {String.Join(",", arrayModNumber)}");
}