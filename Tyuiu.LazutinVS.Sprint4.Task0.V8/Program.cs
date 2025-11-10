
using Tyuiu.LazutinVS.Sprint4.Task0.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[] array = new int[] { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
        

        Console.WriteLine(ds.GetMultEvenArrEl(array));
    }
}