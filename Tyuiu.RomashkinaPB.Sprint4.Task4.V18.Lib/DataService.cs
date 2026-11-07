using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RomashkinaPB.Sprint4.Task4.V18.Lib
{
    public class DataService : ISprint4Task4V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int colums = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < colums; j++)
                {
                    if (matrix[i,j] % 2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
