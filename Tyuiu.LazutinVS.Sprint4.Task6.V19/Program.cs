using Tyuiu.LazutinVS.Sprint4.Task6.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
        int countOfLongNames = dataService.Calculate(browsers);
        Console.WriteLine($"Количество элементов, длина которых больше 5: {countOfLongNames}");
        Console.WriteLine("************************************************************************");
        Console.ReadLine();
    }
}