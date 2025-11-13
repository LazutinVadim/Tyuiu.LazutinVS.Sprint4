using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LazutinVS.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task4V25
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            int p = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                    {


                        p *= matrix[i, j];
                    }
                }
            }
            return p;
        }
    }
}
