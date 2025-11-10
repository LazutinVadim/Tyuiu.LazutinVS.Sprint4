using Tyuiu.LazutinVS.Sprint4.Task1.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());


        int[] numsArray = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("Введите значение " + i + " Элемент массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}