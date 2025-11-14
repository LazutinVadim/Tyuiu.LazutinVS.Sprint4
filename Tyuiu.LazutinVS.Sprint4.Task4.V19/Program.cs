using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { -5, -9, 8 },
            { -4, -9, -8 },
            { 2, 5, 4 }
        };

        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > 0)
                {
                    count += array[i, j];
                }
            }
        }

        Console.WriteLine(count); // → 24
    }
}