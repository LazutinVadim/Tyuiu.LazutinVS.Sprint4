using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LazutinVS.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            foreach (string str in array)
            {
                if (str.Length > 5) 
                {
                    count++;
                }
            }

            return count;
        }
    }
}
