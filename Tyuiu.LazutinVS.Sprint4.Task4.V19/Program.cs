using Tyuiu.LazutinVS.Sprint4.Task4.V19.Lib;
internal class Program

    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите количество строк в матрице: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в матрице: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] x = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите {i},{j} элемент матрицы: ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМатрица: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{x[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечетных элементов матрицы = " + ds.Calculate(x));
            Console.ReadKey();
        
    }
}