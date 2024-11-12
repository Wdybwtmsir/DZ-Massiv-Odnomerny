using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 2, 5, 4, 6, 5, 3, 7 };

        int localMaximaCount = CountLocalMaxima(array);
        Console.WriteLine($"Количество локальных максимумов: {localMaximaCount}");
    }

    static int CountLocalMaxima(int[] array)
    {
        if (array.Length < 3)
        {
            return 0; 
        }

        int count = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}