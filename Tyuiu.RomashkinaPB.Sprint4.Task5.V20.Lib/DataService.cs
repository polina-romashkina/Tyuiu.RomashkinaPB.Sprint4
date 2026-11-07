using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.RomashkinaPB.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
           int rows = matrix.GetLength(0);
            int colums = matrix.GetLength(1);

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
