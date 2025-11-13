using Tyuiu.LazutinVS.Sprint4.Task3.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //DataService ds = new DataService();
        //int[,] mas = new int[5, 5] { { 7, 3, 5, 3, 6 },
        //                                { 4, 6, 2, 5, 7 },
        //                                { 2, 3, 3, 3, 5 },
        //                                { 2, 7, 7, 6, 2 },
        //                                { 6, 6, 4, 3, 6 } };

        //Console.WriteLine("Массив");
        //int rows = mas.GetUpperBound(0) + 1;
        //int cols = mas.Length / rows;

        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write($"{mas[i, j]}\t");

        //    }
        //    Console.WriteLine();
        //}



        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        //Console.WriteLine("***************************************************************************");
        //int res = ds.Calculate(mas);
        //Console.WriteLine("Произведение элементов четвертого столбца = " + res);

        //Console.ReadLine();
        int[,] array = new int[,] { { 1, 5, 9, 3 }, { 2, 6, 1, 4 }, { 7, 1, 5, 8 }, { 2, 6, 9, 4 } };

        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % 2 != 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}