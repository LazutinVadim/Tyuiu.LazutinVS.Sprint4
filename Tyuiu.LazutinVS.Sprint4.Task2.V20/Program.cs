using Tyuiu.LazutinVS.Sprint4.Task2.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        int len;
        Console.Write("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArry = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArry[i] = rnd.Next(2, 7);
        }
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArry[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArry);
        Console.WriteLine("Сумма четных элементов = " + res);
        Console.ReadKey();
    }
}