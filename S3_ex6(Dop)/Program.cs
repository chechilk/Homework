// Назовём число «интересным», если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
// (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
// 591: (5*9*1)/(5+9+1)=45/15=3

int[] array = new int[10];
Console.WriteLine($"Массив: [ {String.Join(", ", GetArray(array, 10))} ]");

int[] GetArray(int[] mass, int length)
{
    int j = 0;
    while (j < length)
    {
        for (int i = 0; i < length; i++)
        {
            int number = new Random().Next(10, 1001);
            int summ = 0, multi = 1;
            while (number > 0)
            {
                multi = multi * (number % 10);
                summ = summ + (number % 10);
                number = number / 10;
            }
            if (multi % summ == 0)
            {
                mass[i] = number;
                j++;
                break;
            }
        }
    }
    return mass;
}


